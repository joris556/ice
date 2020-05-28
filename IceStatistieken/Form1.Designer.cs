namespace IceStatistieken
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dropWie = new System.Windows.Forms.ComboBox();
            this.dropDoorWie = new System.Windows.Forms.ComboBox();
            this.numTijd = new System.Windows.Forms.NumericUpDown();
            this.dropDag = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dropCalBet = new System.Windows.Forms.ComboBox();
            this.dropCallert = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.butAdd = new System.Windows.Forms.Button();
            this.finalText = new System.Windows.Forms.Label();
            this.devmode = new System.Windows.Forms.CheckBox();
            this.inputbox = new System.Windows.Forms.TextBox();
            this.outputbox = new System.Windows.Forms.TextBox();
            this.querybutton = new System.Windows.Forms.Button();
            this.plekbox = new System.Windows.Forms.TextBox();
            this.comment = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label9 = new System.Windows.Forms.Label();
            this.statbox1 = new System.Windows.Forms.ComboBox();
            this.statnamebox1 = new System.Windows.Forms.ComboBox();
            this.statbutton1 = new System.Windows.Forms.Button();
            this.charttypebox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numTijd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // dropWie
            // 
            this.dropWie.Font = new System.Drawing.Font("Cambria", 20.25F);
            this.dropWie.FormattingEnabled = true;
            this.dropWie.Location = new System.Drawing.Point(12, 50);
            this.dropWie.Name = "dropWie";
            this.dropWie.Size = new System.Drawing.Size(321, 40);
            this.dropWie.TabIndex = 0;
            this.dropWie.Text = "Wie vond de Ice?";
            this.dropWie.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dropDoorWie
            // 
            this.dropDoorWie.Font = new System.Drawing.Font("Cambria", 20.25F);
            this.dropDoorWie.FormattingEnabled = true;
            this.dropDoorWie.Location = new System.Drawing.Point(12, 96);
            this.dropDoorWie.Name = "dropDoorWie";
            this.dropDoorWie.Size = new System.Drawing.Size(321, 40);
            this.dropDoorWie.TabIndex = 1;
            this.dropDoorWie.Text = "Wie verstopte de Ice?";
            this.dropDoorWie.SelectedIndexChanged += new System.EventHandler(this.dropDoorWie_SelectedIndexChanged);
            // 
            // numTijd
            // 
            this.numTijd.Font = new System.Drawing.Font("Cambria", 20.25F);
            this.numTijd.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numTijd.Location = new System.Drawing.Point(12, 142);
            this.numTijd.Maximum = new decimal(new int[] {
            2300,
            0,
            0,
            0});
            this.numTijd.Name = "numTijd";
            this.numTijd.Size = new System.Drawing.Size(321, 39);
            this.numTijd.TabIndex = 2;
            this.numTijd.Tag = "";
            this.numTijd.Value = new decimal(new int[] {
            1400,
            0,
            0,
            0});
            this.numTijd.ValueChanged += new System.EventHandler(this.numTijd_ValueChanged);
            // 
            // dropDag
            // 
            this.dropDag.Font = new System.Drawing.Font("Cambria", 20.25F);
            this.dropDag.FormattingEnabled = true;
            this.dropDag.Location = new System.Drawing.Point(12, 187);
            this.dropDag.Name = "dropDag";
            this.dropDag.Size = new System.Drawing.Size(321, 40);
            this.dropDag.TabIndex = 3;
            this.dropDag.Text = "Welke dag is het?";
            this.dropDag.SelectedIndexChanged += new System.EventHandler(this.dropDag_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 233);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(321, 39);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 20.25F);
            this.label1.Location = new System.Drawing.Point(339, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Vindert*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 20.25F);
            this.label2.Location = new System.Drawing.Point(339, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Verstoppert*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 20.25F);
            this.label3.Location = new System.Drawing.Point(339, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tijd*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 20.25F);
            this.label4.Location = new System.Drawing.Point(339, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Dag*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 20.25F);
            this.label5.Location = new System.Drawing.Point(339, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 32);
            this.label5.TabIndex = 9;
            this.label5.Text = "Datum*";
            // 
            // dropCalBet
            // 
            this.dropCalBet.Font = new System.Drawing.Font("Cambria", 20.25F);
            this.dropCalBet.FormattingEnabled = true;
            this.dropCalBet.Location = new System.Drawing.Point(12, 368);
            this.dropCalBet.Name = "dropCalBet";
            this.dropCalBet.Size = new System.Drawing.Size(321, 40);
            this.dropCalBet.TabIndex = 10;
            this.dropCalBet.Text = "Gecalled of betrapt?";
            this.dropCalBet.Visible = false;
            this.dropCalBet.SelectedIndexChanged += new System.EventHandler(this.dropCalBet_SelectedIndexChanged);
            // 
            // dropCallert
            // 
            this.dropCallert.Font = new System.Drawing.Font("Cambria", 20.25F);
            this.dropCallert.FormattingEnabled = true;
            this.dropCallert.Location = new System.Drawing.Point(12, 414);
            this.dropCallert.Name = "dropCallert";
            this.dropCallert.Size = new System.Drawing.Size(321, 40);
            this.dropCallert.TabIndex = 11;
            this.dropCallert.Text = "Door wie?";
            this.dropCallert.Visible = false;
            this.dropCallert.SelectedIndexChanged += new System.EventHandler(this.dropCallert_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 24.25F);
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 38);
            this.label6.TabIndex = 12;
            this.label6.Text = "Toevoegen:";
            // 
            // butAdd
            // 
            this.butAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butAdd.Font = new System.Drawing.Font("Cambria", 20.25F);
            this.butAdd.Location = new System.Drawing.Point(12, 497);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(321, 40);
            this.butAdd.TabIndex = 13;
            this.butAdd.Text = "Toevoegen";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // finalText
            // 
            this.finalText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.finalText.AutoSize = true;
            this.finalText.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.finalText.Location = new System.Drawing.Point(12, 472);
            this.finalText.Name = "finalText";
            this.finalText.Size = new System.Drawing.Size(199, 22);
            this.finalText.TabIndex = 14;
            this.finalText.Text = "WieWatWaarWanneer?";
            // 
            // devmode
            // 
            this.devmode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.devmode.AutoSize = true;
            this.devmode.Location = new System.Drawing.Point(12, 758);
            this.devmode.Name = "devmode";
            this.devmode.Size = new System.Drawing.Size(147, 17);
            this.devmode.TabIndex = 15;
            this.devmode.Text = "Devmodus (is voor joris :))";
            this.devmode.UseVisualStyleBackColor = true;
            this.devmode.CheckedChanged += new System.EventHandler(this.devmode_CheckedChanged);
            // 
            // inputbox
            // 
            this.inputbox.AcceptsReturn = true;
            this.inputbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.inputbox.Font = new System.Drawing.Font("Courier New", 10.25F);
            this.inputbox.Location = new System.Drawing.Point(12, 543);
            this.inputbox.Multiline = true;
            this.inputbox.Name = "inputbox";
            this.inputbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.inputbox.Size = new System.Drawing.Size(321, 97);
            this.inputbox.TabIndex = 16;
            this.inputbox.TextChanged += new System.EventHandler(this.inputbox_TextChanged);
            // 
            // outputbox
            // 
            this.outputbox.AcceptsReturn = true;
            this.outputbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.outputbox.Font = new System.Drawing.Font("Courier New", 10.25F);
            this.outputbox.Location = new System.Drawing.Point(12, 646);
            this.outputbox.Multiline = true;
            this.outputbox.Name = "outputbox";
            this.outputbox.ReadOnly = true;
            this.outputbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.outputbox.Size = new System.Drawing.Size(321, 97);
            this.outputbox.TabIndex = 17;
            this.outputbox.Text = "Outputbox";
            this.outputbox.WordWrap = false;
            // 
            // querybutton
            // 
            this.querybutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.querybutton.Location = new System.Drawing.Point(166, 752);
            this.querybutton.Name = "querybutton";
            this.querybutton.Size = new System.Drawing.Size(167, 23);
            this.querybutton.TabIndex = 18;
            this.querybutton.Text = "Query";
            this.querybutton.UseVisualStyleBackColor = true;
            this.querybutton.Click += new System.EventHandler(this.querybutton_Click);
            // 
            // plekbox
            // 
            this.plekbox.Font = new System.Drawing.Font("Cambria", 20.25F);
            this.plekbox.Location = new System.Drawing.Point(12, 278);
            this.plekbox.Name = "plekbox";
            this.plekbox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.plekbox.Size = new System.Drawing.Size(321, 39);
            this.plekbox.TabIndex = 19;
            this.plekbox.TextChanged += new System.EventHandler(this.plekbox_TextChanged);
            // 
            // comment
            // 
            this.comment.Font = new System.Drawing.Font("Cambria", 20.25F);
            this.comment.Location = new System.Drawing.Point(12, 323);
            this.comment.Name = "comment";
            this.comment.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.comment.Size = new System.Drawing.Size(321, 39);
            this.comment.TabIndex = 20;
            this.comment.TextChanged += new System.EventHandler(this.comment_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 20.25F);
            this.label7.Location = new System.Drawing.Point(339, 281);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(138, 32);
            this.label7.TabIndex = 21;
            this.label7.Text = "Vindplaats";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 20.25F);
            this.label8.Location = new System.Drawing.Point(339, 326);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 32);
            this.label8.TabIndex = 22;
            this.label8.Text = "Comment";
            // 
            // chart1
            // 
            this.chart1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(689, 281);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "main";
            series1.YValuesPerPoint = 2;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(604, 494);
            this.chart1.TabIndex = 23;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 24.25F);
            this.label9.Location = new System.Drawing.Point(682, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(180, 38);
            this.label9.TabIndex = 24;
            this.label9.Text = "Statistieken";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // statbox1
            // 
            this.statbox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.statbox1.Font = new System.Drawing.Font("Cambria", 20.25F);
            this.statbox1.FormattingEnabled = true;
            this.statbox1.Location = new System.Drawing.Point(689, 50);
            this.statbox1.Name = "statbox1";
            this.statbox1.Size = new System.Drawing.Size(321, 40);
            this.statbox1.TabIndex = 25;
            this.statbox1.Text = "Stats zijn de shit";
            this.statbox1.SelectedIndexChanged += new System.EventHandler(this.statbox1_SelectedIndexChanged);
            // 
            // statnamebox1
            // 
            this.statnamebox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.statnamebox1.Font = new System.Drawing.Font("Cambria", 20.25F);
            this.statnamebox1.FormattingEnabled = true;
            this.statnamebox1.Location = new System.Drawing.Point(689, 96);
            this.statnamebox1.Name = "statnamebox1";
            this.statnamebox1.Size = new System.Drawing.Size(321, 40);
            this.statnamebox1.TabIndex = 26;
            this.statnamebox1.Text = "Van wie?";
            this.statnamebox1.SelectedIndexChanged += new System.EventHandler(this.statnamebox1_SelectedIndexChanged);
            // 
            // statbutton1
            // 
            this.statbutton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.statbutton1.Font = new System.Drawing.Font("Cambria", 20.25F);
            this.statbutton1.Location = new System.Drawing.Point(689, 186);
            this.statbutton1.Name = "statbutton1";
            this.statbutton1.Size = new System.Drawing.Size(321, 40);
            this.statbutton1.TabIndex = 27;
            this.statbutton1.Text = "Vraag op";
            this.statbutton1.UseVisualStyleBackColor = true;
            this.statbutton1.Click += new System.EventHandler(this.statbutton1_Click);
            // 
            // charttypebox
            // 
            this.charttypebox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.charttypebox.Font = new System.Drawing.Font("Cambria", 20.25F);
            this.charttypebox.FormattingEnabled = true;
            this.charttypebox.Location = new System.Drawing.Point(689, 141);
            this.charttypebox.Name = "charttypebox";
            this.charttypebox.Size = new System.Drawing.Size(321, 40);
            this.charttypebox.TabIndex = 28;
            this.charttypebox.Text = "Grafiektype";
            this.charttypebox.SelectedIndexChanged += new System.EventHandler(this.charttypebox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1305, 788);
            this.Controls.Add(this.charttypebox);
            this.Controls.Add(this.statbutton1);
            this.Controls.Add(this.statnamebox1);
            this.Controls.Add(this.statbox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comment);
            this.Controls.Add(this.plekbox);
            this.Controls.Add(this.querybutton);
            this.Controls.Add(this.outputbox);
            this.Controls.Add(this.inputbox);
            this.Controls.Add(this.devmode);
            this.Controls.Add(this.finalText);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dropCallert);
            this.Controls.Add(this.dropCalBet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dropDag);
            this.Controls.Add(this.numTijd);
            this.Controls.Add(this.dropDoorWie);
            this.Controls.Add(this.dropWie);
            this.Name = "Form1";
            this.Text = "Ice statistieken";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numTijd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox dropWie;
        private System.Windows.Forms.ComboBox dropDoorWie;
        private System.Windows.Forms.NumericUpDown numTijd;
        private System.Windows.Forms.ComboBox dropDag;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox dropCalBet;
        private System.Windows.Forms.ComboBox dropCallert;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Label finalText;
        private System.Windows.Forms.CheckBox devmode;
        private System.Windows.Forms.TextBox inputbox;
        private System.Windows.Forms.TextBox outputbox;
        private System.Windows.Forms.Button querybutton;
        private System.Windows.Forms.TextBox plekbox;
        private System.Windows.Forms.TextBox comment;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox statbox1;
        private System.Windows.Forms.ComboBox statnamebox1;
        private System.Windows.Forms.Button statbutton1;
        private System.Windows.Forms.ComboBox charttypebox;
    }
}

