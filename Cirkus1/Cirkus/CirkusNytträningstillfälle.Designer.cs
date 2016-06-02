namespace Cirkus
{
    partial class CirkusNytträningstillfälle
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
            this.AvbrytBt = new System.Windows.Forms.Button();
            this.NyttträningstillfälleBt = new System.Windows.Forms.Button();
            this.CboxPlats = new System.Windows.Forms.ComboBox();
            this.CboxTräningsgrupper = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EfterNamnLb = new System.Windows.Forms.Label();
            this.förnamnLb = new System.Windows.Forms.Label();
            this.MedlNrLb = new System.Windows.Forms.Label();
            this.läggtillmedlemBt = new System.Windows.Forms.Button();
            this.MedlmLbox = new System.Windows.Forms.ListBox();
            this.LboxDeltagit = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtTypav = new System.Windows.Forms.TextBox();
            this.BtFinish = new System.Windows.Forms.Button();
            this.TxtBdatum = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Cboxtränare = new System.Windows.Forms.ComboBox();
            this.LboxTränare = new System.Windows.Forms.ListBox();
            this.BtNytrännare = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // AvbrytBt
            // 
            this.AvbrytBt.Location = new System.Drawing.Point(460, 489);
            this.AvbrytBt.Name = "AvbrytBt";
            this.AvbrytBt.Size = new System.Drawing.Size(75, 34);
            this.AvbrytBt.TabIndex = 0;
            this.AvbrytBt.Text = "Avbryt";
            this.AvbrytBt.UseVisualStyleBackColor = true;
            this.AvbrytBt.Click += new System.EventHandler(this.AvbrytBt_Click);
            // 
            // NyttträningstillfälleBt
            // 
            this.NyttträningstillfälleBt.Location = new System.Drawing.Point(370, 75);
            this.NyttträningstillfälleBt.Name = "NyttträningstillfälleBt";
            this.NyttträningstillfälleBt.Size = new System.Drawing.Size(75, 23);
            this.NyttträningstillfälleBt.TabIndex = 1;
            this.NyttträningstillfälleBt.Text = "Lägg till";
            this.NyttträningstillfälleBt.UseVisualStyleBackColor = true;
            this.NyttträningstillfälleBt.Click += new System.EventHandler(this.NyttträningstillfälleBt_Click);
            // 
            // CboxPlats
            // 
            this.CboxPlats.FormattingEnabled = true;
            this.CboxPlats.Items.AddRange(new object[] {
            "Cirkustältet",
            "Utomhus",
            "Cirkushallen"});
            this.CboxPlats.Location = new System.Drawing.Point(44, 35);
            this.CboxPlats.Name = "CboxPlats";
            this.CboxPlats.Size = new System.Drawing.Size(145, 21);
            this.CboxPlats.TabIndex = 2;
            // 
            // CboxTräningsgrupper
            // 
            this.CboxTräningsgrupper.FormattingEnabled = true;
            this.CboxTräningsgrupper.Location = new System.Drawing.Point(300, 34);
            this.CboxTräningsgrupper.Name = "CboxTräningsgrupper";
            this.CboxTräningsgrupper.Size = new System.Drawing.Size(145, 21);
            this.CboxTräningsgrupper.TabIndex = 5;
            this.CboxTräningsgrupper.SelectedIndexChanged += new System.EventHandler(this.CboxTräningsgrupper_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Plats";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Datum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Typ av aktivitet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(297, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Träningsgrupp";
            // 
            // EfterNamnLb
            // 
            this.EfterNamnLb.AutoSize = true;
            this.EfterNamnLb.Location = new System.Drawing.Point(142, 284);
            this.EfterNamnLb.Name = "EfterNamnLb";
            this.EfterNamnLb.Size = new System.Drawing.Size(55, 13);
            this.EfterNamnLb.TabIndex = 37;
            this.EfterNamnLb.Text = "Efternamn";
            // 
            // förnamnLb
            // 
            this.förnamnLb.AutoSize = true;
            this.förnamnLb.Location = new System.Drawing.Point(87, 284);
            this.förnamnLb.Name = "förnamnLb";
            this.förnamnLb.Size = new System.Drawing.Size(48, 13);
            this.förnamnLb.TabIndex = 36;
            this.förnamnLb.Text = "Förnman";
            // 
            // MedlNrLb
            // 
            this.MedlNrLb.AutoSize = true;
            this.MedlNrLb.Location = new System.Drawing.Point(23, 284);
            this.MedlNrLb.Name = "MedlNrLb";
            this.MedlNrLb.Size = new System.Drawing.Size(58, 13);
            this.MedlNrLb.TabIndex = 35;
            this.MedlNrLb.Text = "Medlemsnr";
            // 
            // läggtillmedlemBt
            // 
            this.läggtillmedlemBt.Enabled = false;
            this.läggtillmedlemBt.Location = new System.Drawing.Point(244, 359);
            this.läggtillmedlemBt.Name = "läggtillmedlemBt";
            this.läggtillmedlemBt.Size = new System.Drawing.Size(75, 23);
            this.läggtillmedlemBt.TabIndex = 33;
            this.läggtillmedlemBt.Text = ">>>>";
            this.läggtillmedlemBt.UseVisualStyleBackColor = true;
            this.läggtillmedlemBt.Click += new System.EventHandler(this.läggtillmedlemBt_Click);
            // 
            // MedlmLbox
            // 
            this.MedlmLbox.FormattingEnabled = true;
            this.MedlmLbox.Location = new System.Drawing.Point(22, 300);
            this.MedlmLbox.Name = "MedlmLbox";
            this.MedlmLbox.Size = new System.Drawing.Size(203, 186);
            this.MedlmLbox.TabIndex = 32;
            this.MedlmLbox.SelectedIndexChanged += new System.EventHandler(this.MedlmLbox_SelectedIndexChanged);
            // 
            // LboxDeltagit
            // 
            this.LboxDeltagit.FormattingEnabled = true;
            this.LboxDeltagit.Location = new System.Drawing.Point(325, 298);
            this.LboxDeltagit.Name = "LboxDeltagit";
            this.LboxDeltagit.Size = new System.Drawing.Size(202, 186);
            this.LboxDeltagit.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(322, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Medlemsnr";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(386, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Förnman";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(441, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Efternamn";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(322, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Tillagda";
            // 
            // TxtBox
            // 
            this.TxtBox.Location = new System.Drawing.Point(177, 78);
            this.TxtBox.Name = "TxtBox";
            this.TxtBox.Size = new System.Drawing.Size(103, 20);
            this.TxtBox.TabIndex = 39;
            this.TxtBox.Text = "HH:MM";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(177, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "Tid";
            // 
            // TxtTypav
            // 
            this.TxtTypav.Location = new System.Drawing.Point(13, 75);
            this.TxtTypav.Name = "TxtTypav";
            this.TxtTypav.Size = new System.Drawing.Size(141, 20);
            this.TxtTypav.TabIndex = 41;
            // 
            // BtFinish
            // 
            this.BtFinish.Location = new System.Drawing.Point(361, 489);
            this.BtFinish.Name = "BtFinish";
            this.BtFinish.Size = new System.Drawing.Size(93, 34);
            this.BtFinish.TabIndex = 42;
            this.BtFinish.Text = "Klart";
            this.BtFinish.UseVisualStyleBackColor = true;
            this.BtFinish.Click += new System.EventHandler(this.BtFinish_Click);
            // 
            // TxtBdatum
            // 
            this.TxtBdatum.Location = new System.Drawing.Point(215, 35);
            this.TxtBdatum.Name = "TxtBdatum";
            this.TxtBdatum.Size = new System.Drawing.Size(100, 20);
            this.TxtBdatum.TabIndex = 43;
            this.TxtBdatum.Text = "ÅÅÅÅ-MM-DD";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CboxTräningsgrupper);
            this.groupBox1.Controls.Add(this.NyttträningstillfälleBt);
            this.groupBox1.Controls.Add(this.TxtBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtTypav);
            this.groupBox1.Location = new System.Drawing.Point(35, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 115);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fyll först i";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.BtNytrännare);
            this.groupBox2.Controls.Add(this.LboxTränare);
            this.groupBox2.Controls.Add(this.Cboxtränare);
            this.groupBox2.Location = new System.Drawing.Point(35, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(466, 86);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lägg till tränare";
            // 
            // Cboxtränare
            // 
            this.Cboxtränare.FormattingEnabled = true;
            this.Cboxtränare.Location = new System.Drawing.Point(304, 30);
            this.Cboxtränare.Name = "Cboxtränare";
            this.Cboxtränare.Size = new System.Drawing.Size(141, 21);
            this.Cboxtränare.TabIndex = 0;
            this.Cboxtränare.SelectedIndexChanged += new System.EventHandler(this.Cboxtränare_SelectedIndexChanged);
            // 
            // LboxTränare
            // 
            this.LboxTränare.FormattingEnabled = true;
            this.LboxTränare.Location = new System.Drawing.Point(6, 19);
            this.LboxTränare.Name = "LboxTränare";
            this.LboxTränare.Size = new System.Drawing.Size(274, 43);
            this.LboxTränare.TabIndex = 1;
            // 
            // BtNytrännare
            // 
            this.BtNytrännare.Location = new System.Drawing.Point(370, 57);
            this.BtNytrännare.Name = "BtNytrännare";
            this.BtNytrännare.Size = new System.Drawing.Size(75, 23);
            this.BtNytrännare.TabIndex = 2;
            this.BtNytrännare.Text = "Lägg till";
            this.BtNytrännare.UseVisualStyleBackColor = true;
            this.BtNytrännare.Click += new System.EventHandler(this.BtNytrännare_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(304, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Tillgängliga tränare";
            // 
            // CirkusNytträningstillfälle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 613);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.TxtBdatum);
            this.Controls.Add(this.BtFinish);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.EfterNamnLb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.förnamnLb);
            this.Controls.Add(this.MedlNrLb);
            this.Controls.Add(this.läggtillmedlemBt);
            this.Controls.Add(this.LboxDeltagit);
            this.Controls.Add(this.MedlmLbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CboxPlats);
            this.Controls.Add(this.AvbrytBt);
            this.Controls.Add(this.groupBox1);
            this.Name = "CirkusNytträningstillfälle";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AvbrytBt;
        private System.Windows.Forms.Button NyttträningstillfälleBt;
        private System.Windows.Forms.ComboBox CboxPlats;
        private System.Windows.Forms.ComboBox CboxTräningsgrupper;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label EfterNamnLb;
        private System.Windows.Forms.Label förnamnLb;
        private System.Windows.Forms.Label MedlNrLb;
        private System.Windows.Forms.Button läggtillmedlemBt;
        private System.Windows.Forms.ListBox MedlmLbox;
        private System.Windows.Forms.ListBox LboxDeltagit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtTypav;
        private System.Windows.Forms.Button BtFinish;
        private System.Windows.Forms.TextBox TxtBdatum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BtNytrännare;
        private System.Windows.Forms.ListBox LboxTränare;
        private System.Windows.Forms.ComboBox Cboxtränare;
    }
}