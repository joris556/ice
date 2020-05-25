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
            this.dropWie = new System.Windows.Forms.ComboBox();
            this.dropDoorWie = new System.Windows.Forms.ComboBox();
            this.numTijd = new System.Windows.Forms.NumericUpDown();
            this.dropDag = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.numTijd)).BeginInit();
            this.SuspendLayout();
            // 
            // dropWie
            // 
            this.dropWie.Font = new System.Drawing.Font("Cambria", 20.25F);
            this.dropWie.FormattingEnabled = true;
            this.dropWie.Location = new System.Drawing.Point(11, 33);
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
            this.dropDoorWie.Location = new System.Drawing.Point(12, 79);
            this.dropDoorWie.Name = "dropDoorWie";
            this.dropDoorWie.Size = new System.Drawing.Size(320, 40);
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
            this.numTijd.Location = new System.Drawing.Point(13, 125);
            this.numTijd.Maximum = new decimal(new int[] {
            2400,
            0,
            0,
            0});
            this.numTijd.Name = "numTijd";
            this.numTijd.Size = new System.Drawing.Size(319, 39);
            this.numTijd.TabIndex = 2;
            this.numTijd.Tag = "";
            this.numTijd.Value = new decimal(new int[] {
            1400,
            0,
            0,
            0});
            // 
            // dropDag
            // 
            this.dropDag.Font = new System.Drawing.Font("Cambria", 20.25F);
            this.dropDag.FormattingEnabled = true;
            this.dropDag.Location = new System.Drawing.Point(13, 170);
            this.dropDag.Name = "dropDag";
            this.dropDag.Size = new System.Drawing.Size(319, 40);
            this.dropDag.TabIndex = 3;
            this.dropDag.Text = "Welke dag is het?";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(13, 216);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(319, 39);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1305, 682);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dropDag);
            this.Controls.Add(this.numTijd);
            this.Controls.Add(this.dropDoorWie);
            this.Controls.Add(this.dropWie);
            this.Name = "Form1";
            this.Text = "Ice statistieken";
            ((System.ComponentModel.ISupportInitialize)(this.numTijd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox dropWie;
        private System.Windows.Forms.ComboBox dropDoorWie;
        private System.Windows.Forms.NumericUpDown numTijd;
        private System.Windows.Forms.ComboBox dropDag;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

