namespace Cirkus
{
    partial class Cirkusmain
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
            this.button1 = new System.Windows.Forms.Button();
            this.medlemLbox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.laggmedlemBt = new System.Windows.Forms.Button();
            this.MedlNrLb = new System.Windows.Forms.Label();
            this.förnamnLb = new System.Windows.Forms.Label();
            this.EfterNamnLb = new System.Windows.Forms.Label();
            this.träningsgruppBT = new System.Windows.Forms.Button();
            this.narvaroBt = new System.Windows.Forms.Button();
            this.updateMedlemBt = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 418);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // medlemLbox
            // 
            this.medlemLbox.FormattingEnabled = true;
            this.medlemLbox.Location = new System.Drawing.Point(33, 54);
            this.medlemLbox.Name = "medlemLbox";
            this.medlemLbox.Size = new System.Drawing.Size(482, 147);
            this.medlemLbox.TabIndex = 1;
            this.medlemLbox.SelectedIndexChanged += new System.EventHandler(this.medlemLbox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Medlem";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(33, 207);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Uppdatera";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // laggmedlemBt
            // 
            this.laggmedlemBt.Location = new System.Drawing.Point(643, 54);
            this.laggmedlemBt.Name = "laggmedlemBt";
            this.laggmedlemBt.Size = new System.Drawing.Size(122, 23);
            this.laggmedlemBt.TabIndex = 4;
            this.laggmedlemBt.Text = "Lägg till medlem";
            this.laggmedlemBt.UseVisualStyleBackColor = true;
            this.laggmedlemBt.Click += new System.EventHandler(this.laggmedlemBt_Click);
            // 
            // MedlNrLb
            // 
            this.MedlNrLb.AutoSize = true;
            this.MedlNrLb.Location = new System.Drawing.Point(33, 38);
            this.MedlNrLb.Name = "MedlNrLb";
            this.MedlNrLb.Size = new System.Drawing.Size(58, 13);
            this.MedlNrLb.TabIndex = 5;
            this.MedlNrLb.Text = "Medlemsnr";
            this.MedlNrLb.Click += new System.EventHandler(this.MedlNrLb_Click);
            // 
            // förnamnLb
            // 
            this.förnamnLb.AutoSize = true;
            this.förnamnLb.Location = new System.Drawing.Point(97, 38);
            this.förnamnLb.Name = "förnamnLb";
            this.förnamnLb.Size = new System.Drawing.Size(48, 13);
            this.förnamnLb.TabIndex = 6;
            this.förnamnLb.Text = "Förnman";
            this.förnamnLb.Click += new System.EventHandler(this.förnamnLb_Click);
            // 
            // EfterNamnLb
            // 
            this.EfterNamnLb.AutoSize = true;
            this.EfterNamnLb.Location = new System.Drawing.Point(152, 38);
            this.EfterNamnLb.Name = "EfterNamnLb";
            this.EfterNamnLb.Size = new System.Drawing.Size(55, 13);
            this.EfterNamnLb.TabIndex = 7;
            this.EfterNamnLb.Text = "Efternamn";
            // 
            // träningsgruppBT
            // 
            this.träningsgruppBT.Location = new System.Drawing.Point(643, 235);
            this.träningsgruppBT.Name = "träningsgruppBT";
            this.träningsgruppBT.Size = new System.Drawing.Size(122, 29);
            this.träningsgruppBT.TabIndex = 8;
            this.träningsgruppBT.Text = "Träningsgrupper";
            this.träningsgruppBT.UseVisualStyleBackColor = true;
            this.träningsgruppBT.Click += new System.EventHandler(this.träningsgruppBT_Click);
            // 
            // narvaroBt
            // 
            this.narvaroBt.Location = new System.Drawing.Point(643, 299);
            this.narvaroBt.Name = "narvaroBt";
            this.narvaroBt.Size = new System.Drawing.Size(95, 23);
            this.narvaroBt.TabIndex = 9;
            this.narvaroBt.Text = "Närvarokort";
            this.narvaroBt.UseVisualStyleBackColor = true;
            this.narvaroBt.Click += new System.EventHandler(this.narvaroBt_Click);
            // 
            // updateMedlemBt
            // 
            this.updateMedlemBt.Location = new System.Drawing.Point(643, 83);
            this.updateMedlemBt.Name = "updateMedlemBt";
            this.updateMedlemBt.Size = new System.Drawing.Size(122, 23);
            this.updateMedlemBt.TabIndex = 10;
            this.updateMedlemBt.Text = "Uppdatera medlem";
            this.updateMedlemBt.UseVisualStyleBackColor = true;
            this.updateMedlemBt.Click += new System.EventHandler(this.updateMedlemBt_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(643, 113);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(122, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "Ta bort medlem";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Cirkusmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 453);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.updateMedlemBt);
            this.Controls.Add(this.narvaroBt);
            this.Controls.Add(this.träningsgruppBT);
            this.Controls.Add(this.EfterNamnLb);
            this.Controls.Add(this.förnamnLb);
            this.Controls.Add(this.MedlNrLb);
            this.Controls.Add(this.laggmedlemBt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.medlemLbox);
            this.Controls.Add(this.button1);
            this.Name = "Cirkusmain";
            this.Text = "Cirkus - Kul & Bus  Admin";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox medlemLbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button laggmedlemBt;
        private System.Windows.Forms.Label MedlNrLb;
        private System.Windows.Forms.Label förnamnLb;
        private System.Windows.Forms.Label EfterNamnLb;
        private System.Windows.Forms.Button träningsgruppBT;
        private System.Windows.Forms.Button narvaroBt;
        private System.Windows.Forms.Button updateMedlemBt;
        private System.Windows.Forms.Button button4;
    }
}

