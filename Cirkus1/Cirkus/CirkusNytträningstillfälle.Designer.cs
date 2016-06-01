﻿namespace Cirkus
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.CboxTräningstyp = new System.Windows.Forms.ComboBox();
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
            this.SuspendLayout();
            // 
            // AvbrytBt
            // 
            this.AvbrytBt.Location = new System.Drawing.Point(413, 78);
            this.AvbrytBt.Name = "AvbrytBt";
            this.AvbrytBt.Size = new System.Drawing.Size(75, 23);
            this.AvbrytBt.TabIndex = 0;
            this.AvbrytBt.Text = "Avbryt";
            this.AvbrytBt.UseVisualStyleBackColor = true;
            this.AvbrytBt.Click += new System.EventHandler(this.AvbrytBt_Click);
            // 
            // NyttträningstillfälleBt
            // 
            this.NyttträningstillfälleBt.Location = new System.Drawing.Point(324, 78);
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
            this.CboxPlats.Location = new System.Drawing.Point(34, 35);
            this.CboxPlats.Name = "CboxPlats";
            this.CboxPlats.Size = new System.Drawing.Size(121, 21);
            this.CboxPlats.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(161, 35);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // CboxTräningstyp
            // 
            this.CboxTräningstyp.FormattingEnabled = true;
            this.CboxTräningstyp.Location = new System.Drawing.Point(367, 34);
            this.CboxTräningstyp.Name = "CboxTräningstyp";
            this.CboxTräningstyp.Size = new System.Drawing.Size(121, 21);
            this.CboxTräningstyp.TabIndex = 4;
            // 
            // CboxTräningsgrupper
            // 
            this.CboxTräningsgrupper.FormattingEnabled = true;
            this.CboxTräningsgrupper.Location = new System.Drawing.Point(34, 78);
            this.CboxTräningsgrupper.Name = "CboxTräningsgrupper";
            this.CboxTräningsgrupper.Size = new System.Drawing.Size(121, 21);
            this.CboxTräningsgrupper.TabIndex = 5;
            this.CboxTräningsgrupper.SelectedIndexChanged += new System.EventHandler(this.CboxTräningsgrupper_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Plats";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Datum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(364, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "label1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Träningsgrupp";
            // 
            // EfterNamnLb
            // 
            this.EfterNamnLb.AutoSize = true;
            this.EfterNamnLb.Location = new System.Drawing.Point(154, 137);
            this.EfterNamnLb.Name = "EfterNamnLb";
            this.EfterNamnLb.Size = new System.Drawing.Size(55, 13);
            this.EfterNamnLb.TabIndex = 37;
            this.EfterNamnLb.Text = "Efternamn";
            // 
            // förnamnLb
            // 
            this.förnamnLb.AutoSize = true;
            this.förnamnLb.Location = new System.Drawing.Point(99, 137);
            this.förnamnLb.Name = "förnamnLb";
            this.förnamnLb.Size = new System.Drawing.Size(48, 13);
            this.förnamnLb.TabIndex = 36;
            this.förnamnLb.Text = "Förnman";
            // 
            // MedlNrLb
            // 
            this.MedlNrLb.AutoSize = true;
            this.MedlNrLb.Location = new System.Drawing.Point(35, 137);
            this.MedlNrLb.Name = "MedlNrLb";
            this.MedlNrLb.Size = new System.Drawing.Size(58, 13);
            this.MedlNrLb.TabIndex = 35;
            this.MedlNrLb.Text = "Medlemsnr";
            // 
            // läggtillmedlemBt
            // 
            this.läggtillmedlemBt.Enabled = false;
            this.läggtillmedlemBt.Location = new System.Drawing.Point(303, 216);
            this.läggtillmedlemBt.Name = "läggtillmedlemBt";
            this.läggtillmedlemBt.Size = new System.Drawing.Size(75, 23);
            this.läggtillmedlemBt.TabIndex = 33;
            this.läggtillmedlemBt.Text = ">>>>";
            this.läggtillmedlemBt.UseVisualStyleBackColor = true;
            // 
            // MedlmLbox
            // 
            this.MedlmLbox.FormattingEnabled = true;
            this.MedlmLbox.Location = new System.Drawing.Point(34, 153);
            this.MedlmLbox.Name = "MedlmLbox";
            this.MedlmLbox.Size = new System.Drawing.Size(253, 186);
            this.MedlmLbox.TabIndex = 32;
            // 
            // LboxDeltagit
            // 
            this.LboxDeltagit.FormattingEnabled = true;
            this.LboxDeltagit.Location = new System.Drawing.Point(384, 151);
            this.LboxDeltagit.Name = "LboxDeltagit";
            this.LboxDeltagit.Size = new System.Drawing.Size(202, 186);
            this.LboxDeltagit.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(385, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Medlemsnr";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(449, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Förnman";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(504, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Efternamn";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(385, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Tillagda";
            // 
            // CirkusNytträningstillfälle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 612);
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
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CboxTräningsgrupper);
            this.Controls.Add(this.CboxTräningstyp);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.CboxPlats);
            this.Controls.Add(this.NyttträningstillfälleBt);
            this.Controls.Add(this.AvbrytBt);
            this.Name = "CirkusNytträningstillfälle";
            this.Text = "Skapa Nytt träningstillfälle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AvbrytBt;
        private System.Windows.Forms.Button NyttträningstillfälleBt;
        private System.Windows.Forms.ComboBox CboxPlats;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox CboxTräningstyp;
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
    }
}