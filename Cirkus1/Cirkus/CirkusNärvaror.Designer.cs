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
            this.LbMedlemr = new System.Windows.Forms.Label();
            this.LbFörnamn = new System.Windows.Forms.Label();
            this.Lbefternamn = new System.Windows.Forms.Label();
            this.LbFöresle = new System.Windows.Forms.Label();
            this.Lbhuvud = new System.Windows.Forms.Label();
            this.LboxAktivitet = new System.Windows.Forms.ListBox();
            this.LbAktivitet = new System.Windows.Forms.Label();
            this.Lbdatum = new System.Windows.Forms.Label();
            this.Lbtid = new System.Windows.Forms.Label();
            this.lbl_med = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbl_aktiv = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.LboxLedare = new System.Windows.Forms.ListBox();
            this.Lbplats = new System.Windows.Forms.Label();
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
            this.BtSökdatum.Click += new System.EventHandler(this.BtSökdatum_Click);
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
            // LbMedlemr
            // 
            this.LbMedlemr.AutoSize = true;
            this.LbMedlemr.Location = new System.Drawing.Point(358, 263);
            this.LbMedlemr.Name = "LbMedlemr";
            this.LbMedlemr.Size = new System.Drawing.Size(61, 13);
            this.LbMedlemr.TabIndex = 11;
            this.LbMedlemr.Text = "Medlemsnr:";
            // 
            // LbFörnamn
            // 
            this.LbFörnamn.AutoSize = true;
            this.LbFörnamn.Location = new System.Drawing.Point(426, 263);
            this.LbFörnamn.Name = "LbFörnamn";
            this.LbFörnamn.Size = new System.Drawing.Size(48, 13);
            this.LbFörnamn.TabIndex = 11;
            this.LbFörnamn.Text = "Förnamn";
            // 
            // Lbefternamn
            // 
            this.Lbefternamn.AutoSize = true;
            this.Lbefternamn.Location = new System.Drawing.Point(491, 263);
            this.Lbefternamn.Name = "Lbefternamn";
            this.Lbefternamn.Size = new System.Drawing.Size(55, 13);
            this.Lbefternamn.TabIndex = 11;
            this.Lbefternamn.Text = "Efternamn";
            // 
            // LbFöresle
            // 
            this.LbFöresle.AutoSize = true;
            this.LbFöresle.Location = new System.Drawing.Point(552, 263);
            this.LbFöresle.Name = "LbFöresle";
            this.LbFöresle.Size = new System.Drawing.Size(70, 13);
            this.LbFöresle.TabIndex = 11;
            this.LbFöresle.Text = "Förelsedatum";
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
            // LbAktivitet
            // 
            this.LbAktivitet.AutoSize = true;
            this.LbAktivitet.Location = new System.Drawing.Point(31, 263);
            this.LbAktivitet.Name = "LbAktivitet";
            this.LbAktivitet.Size = new System.Drawing.Size(45, 13);
            this.LbAktivitet.TabIndex = 11;
            this.LbAktivitet.Text = "Aktivitet";
            // 
            // Lbdatum
            // 
            this.Lbdatum.AutoSize = true;
            this.Lbdatum.Location = new System.Drawing.Point(99, 263);
            this.Lbdatum.Name = "Lbdatum";
            this.Lbdatum.Size = new System.Drawing.Size(38, 13);
            this.Lbdatum.TabIndex = 11;
            this.Lbdatum.Text = "Datum";
            // 
            // Lbtid
            // 
            this.Lbtid.AutoSize = true;
            this.Lbtid.Location = new System.Drawing.Point(159, 263);
            this.Lbtid.Name = "Lbtid";
            this.Lbtid.Size = new System.Drawing.Size(22, 13);
            this.Lbtid.TabIndex = 11;
            this.Lbtid.Text = "Tid";
            // 
            // lbl_med
            // 
            this.lbl_med.AutoSize = true;
            this.lbl_med.Location = new System.Drawing.Point(27, 455);
            this.lbl_med.Name = "lbl_med";
            this.lbl_med.Size = new System.Drawing.Size(35, 13);
            this.lbl_med.TabIndex = 11;
            this.lbl_med.Text = "label6";
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
            // lbl_aktiv
            // 
            this.lbl_aktiv.AutoSize = true;
            this.lbl_aktiv.Location = new System.Drawing.Point(351, 455);
            this.lbl_aktiv.Name = "lbl_aktiv";
            this.lbl_aktiv.Size = new System.Drawing.Size(35, 13);
            this.lbl_aktiv.TabIndex = 11;
            this.lbl_aktiv.Text = "label6";
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
            // Lbplats
            // 
            this.Lbplats.AutoSize = true;
            this.Lbplats.Location = new System.Drawing.Point(221, 263);
            this.Lbplats.Name = "Lbplats";
            this.Lbplats.Size = new System.Drawing.Size(30, 13);
            this.Lbplats.TabIndex = 11;
            this.Lbplats.Text = "Plats";
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
            this.Controls.Add(this.LbFöresle);
            this.Controls.Add(this.Lbefternamn);
            this.Controls.Add(this.LbFörnamn);
            this.Controls.Add(this.Lbplats);
            this.Controls.Add(this.Lbtid);
            this.Controls.Add(this.lbl_aktiv);
            this.Controls.Add(this.Lbdatum);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lbl_med);
            this.Controls.Add(this.LbAktivitet);
            this.Controls.Add(this.Lbhuvud);
            this.Controls.Add(this.LbMedlemr);
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
        private System.Windows.Forms.Label LbMedlemr;
        private System.Windows.Forms.Label LbFörnamn;
        private System.Windows.Forms.Label Lbefternamn;
        private System.Windows.Forms.Label LbFöresle;
        private System.Windows.Forms.Label Lbhuvud;
        private System.Windows.Forms.ListBox LboxAktivitet;
        private System.Windows.Forms.Label LbAktivitet;
        private System.Windows.Forms.Label Lbdatum;
        private System.Windows.Forms.Label Lbtid;
        private System.Windows.Forms.Label lbl_med;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbl_aktiv;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ListBox LboxLedare;
        private System.Windows.Forms.Label Lbplats;
        private System.Windows.Forms.Label LbGrupp;
        private System.Windows.Forms.Button Btstäng;
    }
}