using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IceStatistieken
{
    public partial class Form1 : Form
    {
        //Bart, Eduardo, Mantas, Joris, Gini, Thijs, Martijn, Len, outsiders
        private string[] names = { "Bart", "Eduardo", "Gini", "Joris", "Len", "Mantas", "Martijn", "Thijs", "Een outsider" };
        private string[] dagen = { "Maandag", "Dinsdag", "Woensdag", "Donderdag", "Vrijdag", "Zaterdag", "Zondag" };
        private string[] exOpties = { "Gecalled", "Betrapt" };
        private string vindert = "", verstoppert = "", dag = "", datum = "", tijd = "", calBetrapper = "";
        private bool called = false, betrapt = false;

        public Form1()
        {
            InitializeComponent();
            dropWie.Items.AddRange(names);
            dropDoorWie.Items.AddRange(names);
            dropDag.Items.AddRange(dagen);
            dropCalBet.Items.AddRange(exOpties);
            dropCalBet.Visible = false;
            dropCallert.Items.AddRange(names);
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            //launch query
            reset();
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
            tijd = numTijd.Value.ToString();
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
