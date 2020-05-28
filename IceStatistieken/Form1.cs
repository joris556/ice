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
        private string vindert = "", verstoppert = "", dag = "", datum = "", tijd = "", calBetrapper = "", plaats = "", ice_comment = "", vanWie = "";
        private bool called = false, betrapt = false, pieChart = true;
        private SQLiteConnection icedb_connection;

        //statistieken
        private string[] statOpties = { "Ices per tijd", "Ices per dag", "Ices per datum","Totaal verstopt pp", "Totaal gevonden pp", "Ices verstopt door:", "Ices gevonden door", "Kosten pp" };
        private string[] ctypes = { "Pie", "Histogram" };
        private string[] statQueries =
        {
            "SELECT tijd, COUNT(vinder) FROM Vergev GROUP BY tijd ORDER BY tijd ASC;",
            "SELECT dag, COUNT(vinder) FROM Vergev GROUP BY dag ORDER BY dag ASC;",
            "SELECT datum, COUNT(vinder) FROM Vergev GROUP BY datum ORDER BY datum ASC;",
            "SELECT verstopper, COUNT(vinder) FROM Vergev GROUP BY verstopper ORDER BY verstopper ASC;",
            "SELECT vinder, COUNT(vinder) FROM Vergev GROUP BY vinder ORDER BY vinder ASC;",
            "SELECT vinder, COUNT(vinder) FROM Vergev WHERE verstopper = 'yeet' GROUP BY vinder ORDER BY vinder ASC;",
            "SELECT verstopper, COUNT(verstopper) FROM Vergev WHERE vinder = 'yeet' GROUP BY verstopper ORDER BY verstopper ASC;",
            "SELECT verstopper, COUNT(verstopper) * 3.14 FROM Vergev GROUP BY verstopper ORDER BY verstopper ASC;"
        };

        private string[] statTitles = { "Terror tijden", "Dolle dagen", "Dodelijke data", "Vriendelijke verstoppers", "Vrolijke vinders", "Vertoppelt door: ", "Gevonden door: ", "Stevige spendeerders"};

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

            //stats
            statnamebox1.Items.AddRange(names);
            statnamebox1.Visible = false;
            charttypebox.Items.AddRange(ctypes);
            statbox1.Items.AddRange(statOpties);

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
            if (vindert != "" && verstoppert != "" && dag != "" && datum != "" && tijd != "")
            {
                if ((!betrapt && !called) && vindert != verstoppert)
                {
                    LaunchQuery();
                    reset();
                }
                else if (calBetrapper != "")
                {
                    LaunchQuery();
                    reset();
                }
                else
                    MessageBox.Show("Vul alle velden in");
            }
            else
                MessageBox.Show("Vul alle velden in");
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
                command = new SQLiteCommand(s, icedb_connection);
                SQLiteDataReader reader = command.ExecuteReader();
                reader.Read();
                string vgid = reader[0] + "";
                s = "INSERT INTO Betrapt VALUES ('" + vgid + "', '" + calBetrapper + "');";
                command = new SQLiteCommand(s, icedb_connection);
                command.ExecuteNonQuery();
            }
            else if (called)
            {
                string s = "SELECT vgid FROM Vergev WHERE vinder = '" + vindert + "' AND dag = '" + dag + "' AND datum = '" + datum +
                    "' AND tijd = '" + tijd + "';";
                command = new SQLiteCommand(s, icedb_connection);
                SQLiteDataReader reader = command.ExecuteReader();
                reader.Read();
                string vgid = reader[0] + "";
                s = "INSERT INTO Called VALUES ('" + vgid + "', '" + calBetrapper + "');";
                command = new SQLiteCommand(s, icedb_connection);
                command.ExecuteNonQuery();
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
            else if (inputbox.Text[0] == '?')
            {
                outputbox.Text = "Begin SQL queries met een '.'";
                outputbox.AppendText(Environment.NewLine);
                outputbox.AppendText("Dit is om het idiootproof te maken :)");
                outputbox.AppendText(Environment.NewLine);
                outputbox.AppendText("Doe -e filenaam om te exporteren in csv");
                outputbox.AppendText(Environment.NewLine);
                outputbox.AppendText("Doe -i filenaam om te importeren uit csv");
                outputbox.AppendText(Environment.NewLine);
                outputbox.AppendText("data moet \"data\", \"data2\" ");
                outputbox.AppendText(Environment.NewLine);
                outputbox.AppendText("En in de volgorde:");
                outputbox.AppendText(Environment.NewLine);
                outputbox.AppendText("vind|verstop|dag|datum|tijd|plek|comment");
                outputbox.AppendText(Environment.NewLine);
                outputbox.AppendText("De laatste 2 zijn optioneel");
                outputbox.AppendText(Environment.NewLine);
                outputbox.AppendText("Credits naar Joris 2020");
            }
            else if (inputbox.Text[0] == '-')
            {
                if (inputbox.Text[1] == 'e')
                {

                }
                else if (inputbox.Text[1] == 'i')
                {

                }
            }

        }

        private void inputbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ResetChart()
        {
            chart1.Series["Ices"].Points.Clear();
            chart1.Titles.Clear();
            chart1.Series["Ices"].IsValueShownAsLabel = true;
        }

        private string[] Alltimes()
        {
            string[] t = new string[24];
            for (int i = 0; i < 24; i++)
                t[i] = i + "0:00";

            return t;
        }

        private void SetChartType(string type = "Pie")
        {
            if (type == "Pie")
                pieChart = true;
            else
                pieChart = false;
        }

        private void FillChart(string query, string title)
        {
            ResetChart();

            icedb_connection.Open();
            SQLiteCommand command = new SQLiteCommand(query, icedb_connection);
            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                chart1.Series["Ices"].Points.AddXY(reader[0].ToString(), reader[1].ToString());
            }
            chart1.Titles.Add(title);

            if (pieChart)
                chart1.Series["Ices"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            else
                chart1.Series["Ices"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            icedb_connection.Close();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void statbox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (statbox1.Text.ToString() == statOpties[5] || statbox1.Text.ToString() == statOpties[6])
                statnamebox1.Visible = true;
            else
                statnamebox1.Visible = false;
        }

        private void statnamebox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            vanWie = statnamebox1.Text.ToString();
        }

        private void statbutton1_Click(object sender, EventArgs e)
        {
            if (statbox1.Text.ToString() == "Stats zijn de shit")
            {
                MessageBox.Show("Kies een optie");
                return;
            }

            string q;
            int i;
            for (i = 0; i < statOpties.Length; i++)
                if (statbox1.Text.ToString() == statOpties[i])
                    break;

            string title;

            q = statQueries[i];
            if (i == 5 || i == 6)
            {
                if (statnamebox1.Text.ToString() == "Van wie?")
                {
                    MessageBox.Show("Vul alle velden in");
                    return;
                }
                q = q.Replace("yeet", statnamebox1.Text.ToString());
                title = statTitles[i] + statnamebox1.Text.ToString();

            }
            else
                title = statTitles[i];

            FillChart(q, title);

            reset();
        }

        private void charttypebox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetChartType(charttypebox.Text.ToString());
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
            vanWie = "";
            statnamebox1.Visible = false;
            statnamebox1.Text = "Van wie?";
            statbox1.Text = "Stats zijn de shit";
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
            if (s == "0")
                s = "0000";
            tijd = s.Insert(s.Length-2, ":");
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
