namespace Cirkus
{
    partial class CirkusNärvaror
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
            this.LboxMedlem = new System.Windows.Forms.ListBox();
            this.BtSökdatum = new System.Windows.Forms.Button();
            this.TxtboxTill = new System.Windows.Forms.TextBox();
            this.Cboxledare = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtBoxFrån = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtSökledare = new System.Windows.Forms.Button();
            this.BtGruppLäggtill = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LbLäggtillgrupp = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtGruppsök = new System.Windows.Forms.Button();
            this.CboxTräningsgrupp = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Lbhuvud = new System.Windows.Forms.Label();
            this.LboxAktivitet = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.LboxLedare = new System.Windows.Forms.ListBox();
            this.label18 = new System.Windows.Forms.Label();
            this.LbGrupp = new System.Windows.Forms.Label();
            this.Btstäng = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // LboxMedlem
            // 
            this.LboxMedlem.FormattingEnabled = true;
            this.LboxMedlem.Location = new System.Drawing.Point(25, 279);
            this.LboxMedlem.Name = "LboxMedlem";
            this.LboxMedlem.Size = new System.Drawing.Size(319, 173);
            this.LboxMedlem.TabIndex = 0;
            this.LboxMedlem.SelectedIndexChanged += new System.EventHandler(this.LboxMedlem_SelectedIndexChanged);
            // 
            // BtSökdatum
            // 
            this.BtSökdatum.Location = new System.Drawing.Point(145, 65);
            this.BtSökdatum.Name = "BtSökdatum";
            this.BtSökdatum.Size = new System.Drawing.Size(75, 23);
            this.BtSökdatum.TabIndex = 2;
            this.BtSökdatum.Text = "Sök";
            this.BtSökdatum.UseVisualStyleBackColor = true;
            // 
            // TxtboxTill
            // 
            this.TxtboxTill.Location = new System.Drawing.Point(120, 39);
            this.TxtboxTill.Name = "TxtboxTill";
            this.TxtboxTill.Size = new System.Drawing.Size(100, 20);
            this.TxtboxTill.TabIndex = 3;
            // 
            // Cboxledare
            // 
            this.Cboxledare.FormattingEnabled = true;
            this.Cboxledare.Location = new System.Drawing.Point(6, 35);
            this.Cboxledare.Name = "Cboxledare";
            this.Cboxledare.Size = new System.Drawing.Size(121, 21);
            this.Cboxledare.TabIndex = 4;
            this.Cboxledare.SelectedIndexChanged += new System.EventHandler(this.Cboxledare_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ledare";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Från";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Till";
            // 
            // TxtBoxFrån
            // 
            this.TxtBoxFrån.Location = new System.Drawing.Point(17, 39);
            this.TxtBoxFrån.Name = "TxtBoxFrån";
            this.TxtBoxFrån.Size = new System.Drawing.Size(100, 20);
            this.TxtBoxFrån.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtBoxFrån);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtboxTill);
            this.groupBox1.Controls.Add(this.BtSökdatum);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(337, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sök datum";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtSökledare);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.Cboxledare);
            this.groupBox2.Location = new System.Drawing.Point(592, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(166, 100);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sök på specifik ledare";
            // 
            // BtSökledare
            // 
            this.BtSökledare.Location = new System.Drawing.Point(51, 63);
            this.BtSökledare.Name = "BtSökledare";
            this.BtSökledare.Size = new System.Drawing.Size(75, 23);
            this.BtSökledare.TabIndex = 6;
            this.BtSökledare.Text = "Sök";
            this.BtSökledare.UseVisualStyleBackColor = true;
            this.BtSökledare.Click += new System.EventHandler(this.BtSökledare_Click);
            // 
            // BtGruppLäggtill
            // 
            this.BtGruppLäggtill.Location = new System.Drawing.Point(134, 33);
            this.BtGruppLäggtill.Name = "BtGruppLäggtill";
            this.BtGruppLäggtill.Size = new System.Drawing.Size(75, 23);
            this.BtGruppLäggtill.TabIndex = 9;
            this.BtGruppLäggtill.Text = "Läggtill";
            this.BtGruppLäggtill.UseVisualStyleBackColor = true;
            this.BtGruppLäggtill.Click += new System.EventHandler(this.BtGruppLäggtill_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LbLäggtillgrupp);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.BtGruppsök);
            this.groupBox3.Controls.Add(this.CboxTräningsgrupp);
            this.groupBox3.Controls.Add(this.BtGruppLäggtill);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(309, 100);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sök träningsgrupper";
            // 
            // LbLäggtillgrupp
            // 
            this.LbLäggtillgrupp.AutoSize = true;
            this.LbLäggtillgrupp.Location = new System.Drawing.Point(10, 74);
            this.LbLäggtillgrupp.Name = "LbLäggtillgrupp";
            this.LbLäggtillgrupp.Size = new System.Drawing.Size(48, 13);
            this.LbLäggtillgrupp.TabIndex = 12;
            this.LbLäggtillgrupp.Text = "Grupper:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Träningsgrupper";
            // 
            // BtGruppsök
            // 
            this.BtGruppsök.Location = new System.Drawing.Point(216, 33);
            this.BtGruppsök.Name = "BtGruppsök";
            this.BtGruppsök.Size = new System.Drawing.Size(75, 23);
            this.BtGruppsök.TabIndex = 10;
            this.BtGruppsök.Text = "Sök";
            this.BtGruppsök.UseVisualStyleBackColor = true;
            this.BtGruppsök.Click += new System.EventHandler(this.BtGruppsök_Click);
            // 
            // CboxTräningsgrupp
            // 
            this.CboxTräningsgrupp.FormattingEnabled = true;
            this.CboxTräningsgrupp.Location = new System.Drawing.Point(7, 35);
            this.CboxTräningsgrupp.Name = "CboxTräningsgrupp";
            this.CboxTräningsgrupp.Size = new System.Drawing.Size(121, 21);
            this.CboxTräningsgrupp.TabIndex = 0;
            this.CboxTräningsgrupp.SelectedIndexChanged += new System.EventHandler(this.CboxTräningsgrupp_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Medlemsnr:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(90, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Förnamn";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(155, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Efternamn";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(216, 263);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Förelsedatum";
            // 
            // Lbhuvud
            // 
            this.Lbhuvud.AutoSize = true;
            this.Lbhuvud.Location = new System.Drawing.Point(22, 134);
            this.Lbhuvud.Name = "Lbhuvud";
            this.Lbhuvud.Size = new System.Drawing.Size(75, 13);
            this.Lbhuvud.TabIndex = 11;
            this.Lbhuvud.Text = "Träningsgrupp";
            // 
            // LboxAktivitet
            // 
            this.LboxAktivitet.FormattingEnabled = true;
            this.LboxAktivitet.Location = new System.Drawing.Point(350, 279);
            this.LboxAktivitet.Name = "LboxAktivitet";
            this.LboxAktivitet.Size = new System.Drawing.Size(296, 173);
            this.LboxAktivitet.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(351, 263);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Aktivitet";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(419, 263);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Datum";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(479, 263);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(22, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "Tid";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(347, 475);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 11;
            this.label14.Text = "label6";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(286, 719);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 13);
            this.label15.TabIndex = 11;
            this.label15.Text = "label6";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(454, 475);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 13);
            this.label16.TabIndex = 11;
            this.label16.Text = "label6";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(22, 192);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 13);
            this.label17.TabIndex = 12;
            this.label17.Text = "Ledare";
            // 
            // LboxLedare
            // 
            this.LboxLedare.FormattingEnabled = true;
            this.LboxLedare.Location = new System.Drawing.Point(25, 208);
            this.LboxLedare.Name = "LboxLedare";
            this.LboxLedare.Size = new System.Drawing.Size(225, 43);
            this.LboxLedare.TabIndex = 0;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(541, 263);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(30, 13);
            this.label18.TabIndex = 11;
            this.label18.Text = "Plats";
            // 
            // LbGrupp
            // 
            this.LbGrupp.AutoSize = true;
            this.LbGrupp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbGrupp.Location = new System.Drawing.Point(29, 156);
            this.LbGrupp.Name = "LbGrupp";
            this.LbGrupp.Size = new System.Drawing.Size(138, 25);
            this.LbGrupp.TabIndex = 13;
            this.LbGrupp.Text = "                  ";
            // 
            // Btstäng
            // 
            this.Btstäng.Location = new System.Drawing.Point(658, 518);
            this.Btstäng.Name = "Btstäng";
            this.Btstäng.Size = new System.Drawing.Size(75, 23);
            this.Btstäng.TabIndex = 14;
            this.Btstäng.Text = "Stäng närvarokort";
            this.Btstäng.UseVisualStyleBackColor = true;
            this.Btstäng.Click += new System.EventHandler(this.Btstäng_Click);
            // 
            // CirkusNärvaror
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 553);
            this.Controls.Add(this.Btstäng);
            this.Controls.Add(this.LbGrupp);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Lbhuvud);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LboxLedare);
            this.Controls.Add(this.LboxAktivitet);
            this.Controls.Add(this.LboxMedlem);
            this.Name = "CirkusNärvaror";
            this.Text = "Närvarokort";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LboxMedlem;
        private System.Windows.Forms.Button BtSökdatum;
        private System.Windows.Forms.TextBox TxtboxTill;
        private System.Windows.Forms.ComboBox Cboxledare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtBoxFrån;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtSökledare;
        private System.Windows.Forms.Button BtGruppLäggtill;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label LbLäggtillgrupp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtGruppsök;
        private System.Windows.Forms.ComboBox CboxTräningsgrupp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Lbhuvud;
        private System.Windows.Forms.ListBox LboxAktivitet;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ListBox LboxLedare;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label LbGrupp;
        private System.Windows.Forms.Button Btstäng;
    }
}