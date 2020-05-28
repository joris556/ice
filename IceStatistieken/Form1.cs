using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace IceStatistieken
{
    public partial class Form1 : Form
    {
        //Bart, Eduardo, Mantas, Joris, Gini, Thijs, Martijn, Len, outsiders
        private string[] names = { "Bart", "Eduardo", "Gini", "Joris", "Len", "Mantas", "Martijn", "Thijs", "Een outsider" };
        private string[] dagen = { "Maandag", "Dinsdag", "Woensdag", "Donderdag", "Vrijdag", "Zaterdag", "Zondag" };
        private string[] exOpties = { "Gecalled", "Betrapt" };
        private string vindert = "", verstoppert = "", dag = "", datum = "", tijd = "", calBetrapper = "", plaats = "", ice_comment = "";
        private bool called = false, betrapt = false;
        private SQLiteConnection icedb_connection;

        public Form1()
        {
            InitializeComponent();
            icedb_connection = new SQLiteConnection("Data Source=icedb.sqlite;Version=3;");

            dropWie.Items.AddRange(names);
            dropDoorWie.Items.AddRange(names);
            dropDag.Items.AddRange(dagen);
            dropCalBet.Items.AddRange(exOpties);
            dropCalBet.Visible = false;
            dropCallert.Items.AddRange(names);

            //devmodus
            inputbox.Visible = false;
            outputbox.Visible = false;
            querybutton.Visible = false;
        }

        private void CreateDB() //Doe maar 1 keer, ooit
        {
            SQLiteConnection.CreateFile("icedb.sqlite");
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            //launch query

            reset();
        }

        private void LaunchQuery()
        {
            icedb_connection.Open();
            SQLiteCommand command;
            string q = "INSERT INTO Vergev (vinder, verstopper, dag, datum, tijd, plek, comment) VALUES ('"
                + vindert + "', '" + verstoppert + "', '" + dag + "', '" + datum + "', '" + tijd + "', '" + plaats + "', '" + ice_comment + "');";
            command = new SQLiteCommand(q, icedb_connection);
            command.ExecuteNonQuery();

            if (betrapt)
            {
                string s = "SELECT vgid FROM Vergev WHERE vinder = '" + vindert + "' AND dag = '" + dag + "' AND datum = '" + datum +
                    "' AND tijd = '" + tijd + "';"; 
            }
            else if (called)
            {

            }

            icedb_connection.Close();
        }

        private void UpdateFinalText()
        {
            if (called)
                finalText.Text = "De Ice van " + vindert + " werd gecalled door " + calBetrapper + " om " + tijd + " op " + dag + " " + datum;
            else if (betrapt)
                finalText.Text = vindert + " werd betrapt tijdens het verstoppen door " + calBetrapper + " om " + tijd + " op " + dag + " " + datum;
            else
                finalText.Text = vindert + " vond de Ice van " + verstoppert + " om " + tijd + " op " + dag + " " + datum;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            datum = dateTimePicker1.Value.ToString().Split()[0];
            string[] s = datum.Split('/');
            datum = s[2] + "-" + s[1] + "-" + s[0];
            UpdateFinalText();
        }

        private void dropDag_SelectedIndexChanged(object sender, EventArgs e)
        {
            dag = dropDag.SelectedItem.ToString();
            UpdateFinalText();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void devmode_CheckedChanged(object sender, EventArgs e)
        {
            if (devmode.Checked)
            {
                inputbox.Visible = true;
                outputbox.Visible = true;
                querybutton.Visible = true;
            }
            else
            {
                inputbox.Visible = false;
                outputbox.Visible = false;
                querybutton.Visible = false;
            }
        }

        private void querybutton_Click(object sender, EventArgs e)
        {
            //try
            //{
                if (inputbox.Text[0] == '.')
                {
                    string query = inputbox.Text.Substring(1, inputbox.Text.Length - 1);

                    icedb_connection.Open();
                    SQLiteCommand command;
                    if (query.Contains("SELECT") || query.Contains("select") || query.Contains("Select"))
                    {
                        command = new SQLiteCommand(query, icedb_connection);
                        SQLiteDataReader reader = command.ExecuteReader();

                        outputbox.Text = "";
                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                outputbox.AppendText(reader[i] + " | ");
                                
                            }
                            outputbox.AppendText(Environment.NewLine);
                        }

                    }
                    else
                    {
                        command = new SQLiteCommand(query, icedb_connection);
                        command.ExecuteNonQuery();
                    }
                    icedb_connection.Close();
                }
            //}
            //catch (Exception ex)
            //{
            //    outputbox.Text = "Invalid input";
            //}

            //outputbox.Text = "hey ";
            //outputbox.AppendText(Environment.NewLine);
            //outputbox.AppendText("hoi");
        }

        private void inputbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void plekbox_TextChanged(object sender, EventArgs e)
        {
            plaats = plekbox.Text;
        }

        private void comment_TextChanged(object sender, EventArgs e)
        {
            ice_comment = comment.Text;
        }

        private void reset()
        {
            vindert = "";
            verstoppert = "";
            dag = "";
            datum = "";
            tijd = "";
            calBetrapper = "";
            called = false;
            betrapt = false;
            dropDoorWie.Text = "Wie verstopte de Ice?";
            dropWie.Text = "Wie vond de Ice?";
            dropDag.Text = "Welke dag is het?";
            dropCalBet.Text = "Gecalled of betrapt?";
            dropCallert.Text = "Door wie?";
            dropCallert.Visible = false;
            dropCalBet.Visible = false;
            finalText.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            vindert = dropWie.SelectedItem.ToString();
            if (dropWie.SelectedItem == dropDoorWie.SelectedItem)
            {
                dropCalBet.Visible = true;
                dropCallert.Visible = true;
            }
            else
            {
                dropCallert.Visible = false;
                dropCalBet.Visible = false;
            }

            UpdateFinalText();
        }

        private void dropDoorWie_SelectedIndexChanged(object sender, EventArgs e)
        {
            verstoppert = dropDoorWie.SelectedItem.ToString();
            if (dropWie.SelectedItem == dropDoorWie.SelectedItem)
            {
                dropCalBet.Visible = true;
                dropCallert.Visible = true;
            }
            else
            {
                dropCallert.Visible = false;
                dropCalBet.Visible = false;
            }

            UpdateFinalText();
        }

        private void numTijd_ValueChanged(object sender, EventArgs e)
        {
            string s = numTijd.Value.ToString();
            tijd = s.Insert(2, ":");
            UpdateFinalText();
        }

        private void dropCalBet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dropCalBet.SelectedItem.ToString() == "Gecalled")
            {
                betrapt = false;
                called = true;
            }
            else if (dropCalBet.SelectedItem.ToString() == "Betrapt")
            {
                called = false;
                betrapt = true;
            }
            UpdateFinalText();
        }

        private void dropCallert_SelectedIndexChanged(object sender, EventArgs e)
        {
            calBetrapper = dropCallert.SelectedItem.ToString();
            UpdateFinalText();
        }
    }
}
