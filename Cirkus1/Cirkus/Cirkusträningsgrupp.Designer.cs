namespace Cirkus
{
    partial class Cirkusträningsgrupp
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
            this.MedlmLbox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NyGruppBt = new System.Windows.Forms.Button();
            this.NytränareBt = new System.Windows.Forms.Button();
            this.TräningsgruppCbox = new System.Windows.Forms.ComboBox();
            this.tränareLbox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nymedlemBt = new System.Windows.Forms.Button();
            this.NymedlemCbox = new System.Windows.Forms.ComboBox();
            this.NytränareCbox = new System.Windows.Forms.ComboBox();
            this.abortBt = new System.Windows.Forms.Button();
            this.EfterNamnLb = new System.Windows.Forms.Label();
            this.förnamnLb = new System.Windows.Forms.Label();
            this.MedlNrLb = new System.Windows.Forms.Label();
            this.Mednr2Lb = new System.Windows.Forms.Label();
            this.Förnamn2Lb = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MedlmLbox
            // 
            this.MedlmLbox.FormattingEnabled = true;
            this.MedlmLbox.Location = new System.Drawing.Point(41, 229);
            this.MedlmLbox.Name = "MedlmLbox";
            this.MedlmLbox.Size = new System.Drawing.Size(384, 186);
            this.MedlmLbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Välj grupp";
            // 
            // NyGruppBt
            // 
            this.NyGruppBt.Location = new System.Drawing.Point(235, 27);
            this.NyGruppBt.Name = "NyGruppBt";
            this.NyGruppBt.Size = new System.Drawing.Size(75, 23);
            this.NyGruppBt.TabIndex = 2;
            this.NyGruppBt.Text = "Ny grupp";
            this.NyGruppBt.UseVisualStyleBackColor = true;
            this.NyGruppBt.Click += new System.EventHandler(this.NyGruppBt_Click);
            // 
            // NytränareBt
            // 
            this.NytränareBt.Location = new System.Drawing.Point(350, 168);
            this.NytränareBt.Name = "NytränareBt";
            this.NytränareBt.Size = new System.Drawing.Size(75, 23);
            this.NytränareBt.TabIndex = 3;
            this.NytränareBt.Text = "Ny tränare";
            this.NytränareBt.UseVisualStyleBackColor = true;
            this.NytränareBt.Click += new System.EventHandler(this.NytränareBt_Click);
            // 
            // TräningsgruppCbox
            // 
            this.TräningsgruppCbox.FormattingEnabled = true;
            this.TräningsgruppCbox.Location = new System.Drawing.Point(41, 27);
            this.TräningsgruppCbox.Name = "TräningsgruppCbox";
            this.TräningsgruppCbox.Size = new System.Drawing.Size(176, 21);
            this.TräningsgruppCbox.TabIndex = 4;
            this.TräningsgruppCbox.SelectedIndexChanged += new System.EventHandler(this.TräningsgruppCbox_SelectedIndexChanged);
            // 
            // tränareLbox
            // 
            this.tränareLbox.FormattingEnabled = true;
            this.tränareLbox.Location = new System.Drawing.Point(41, 82);
            this.tränareLbox.Name = "tränareLbox";
            this.tränareLbox.Size = new System.Drawing.Size(384, 82);
            this.tränareLbox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Gruppmedlemar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tränare";
            // 
            // nymedlemBt
            // 
            this.nymedlemBt.Location = new System.Drawing.Point(350, 419);
            this.nymedlemBt.Name = "nymedlemBt";
            this.nymedlemBt.Size = new System.Drawing.Size(75, 23);
            this.nymedlemBt.TabIndex = 8;
            this.nymedlemBt.Text = "Ny medlem";
            this.nymedlemBt.UseVisualStyleBackColor = true;
            this.nymedlemBt.Click += new System.EventHandler(this.nymedlemBt_Click);
            // 
            // NymedlemCbox
            // 
            this.NymedlemCbox.FormattingEnabled = true;
            this.NymedlemCbox.Location = new System.Drawing.Point(41, 421);
            this.NymedlemCbox.Name = "NymedlemCbox";
            this.NymedlemCbox.Size = new System.Drawing.Size(303, 21);
            this.NymedlemCbox.TabIndex = 9;
            this.NymedlemCbox.SelectedIndexChanged += new System.EventHandler(this.NymedlemCbox_SelectedIndexChanged);
            // 
            // NytränareCbox
            // 
            this.NytränareCbox.FormattingEnabled = true;
            this.NytränareCbox.Location = new System.Drawing.Point(41, 170);
            this.NytränareCbox.Name = "NytränareCbox";
            this.NytränareCbox.Size = new System.Drawing.Size(303, 21);
            this.NytränareCbox.TabIndex = 10;
            this.NytränareCbox.SelectedIndexChanged += new System.EventHandler(this.NytränareCbox_SelectedIndexChanged);
            // 
            // abortBt
            // 
            this.abortBt.Location = new System.Drawing.Point(350, 27);
            this.abortBt.Name = "abortBt";
            this.abortBt.Size = new System.Drawing.Size(75, 23);
            this.abortBt.TabIndex = 28;
            this.abortBt.Text = "Avbryt";
            this.abortBt.UseVisualStyleBackColor = true;
            this.abortBt.Click += new System.EventHandler(this.abortBt_Click);
            // 
            // EfterNamnLb
            // 
            this.EfterNamnLb.AutoSize = true;
            this.EfterNamnLb.Location = new System.Drawing.Point(161, 213);
            this.EfterNamnLb.Name = "EfterNamnLb";
            this.EfterNamnLb.Size = new System.Drawing.Size(55, 13);
            this.EfterNamnLb.TabIndex = 31;
            this.EfterNamnLb.Text = "Efternamn";
            // 
            // förnamnLb
            // 
            this.förnamnLb.AutoSize = true;
            this.förnamnLb.Location = new System.Drawing.Point(106, 213);
            this.förnamnLb.Name = "förnamnLb";
            this.förnamnLb.Size = new System.Drawing.Size(48, 13);
            this.förnamnLb.TabIndex = 30;
            this.förnamnLb.Text = "Förnman";
            this.förnamnLb.Click += new System.EventHandler(this.förnamnLb_Click);
            // 
            // MedlNrLb
            // 
            this.MedlNrLb.AutoSize = true;
            this.MedlNrLb.Location = new System.Drawing.Point(42, 213);
            this.MedlNrLb.Name = "MedlNrLb";
            this.MedlNrLb.Size = new System.Drawing.Size(58, 13);
            this.MedlNrLb.TabIndex = 29;
            this.MedlNrLb.Text = "Medlemsnr";
            this.MedlNrLb.Click += new System.EventHandler(this.MedlNrLb_Click);
            // 
            // Mednr2Lb
            // 
            this.Mednr2Lb.AutoSize = true;
            this.Mednr2Lb.Location = new System.Drawing.Point(42, 66);
            this.Mednr2Lb.Name = "Mednr2Lb";
            this.Mednr2Lb.Size = new System.Drawing.Size(58, 13);
            this.Mednr2Lb.TabIndex = 29;
            this.Mednr2Lb.Text = "Medlemsnr";
            this.Mednr2Lb.Click += new System.EventHandler(this.Mednr2Lb_Click);
            // 
            // Förnamn2Lb
            // 
            this.Förnamn2Lb.AutoSize = true;
            this.Förnamn2Lb.Location = new System.Drawing.Point(106, 66);
            this.Förnamn2Lb.Name = "Förnamn2Lb";
            this.Förnamn2Lb.Size = new System.Drawing.Size(48, 13);
            this.Förnamn2Lb.TabIndex = 30;
            this.Förnamn2Lb.Text = "Förnman";
            this.Förnamn2Lb.Click += new System.EventHandler(this.Förnamn2Lb_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(161, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Efternamn";
            // 
            // Cirkusträningsgrupp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 492);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.EfterNamnLb);
            this.Controls.Add(this.Förnamn2Lb);
            this.Controls.Add(this.Mednr2Lb);
            this.Controls.Add(this.förnamnLb);
            this.Controls.Add(this.MedlNrLb);
            this.Controls.Add(this.abortBt);
            this.Controls.Add(this.NytränareCbox);
            this.Controls.Add(this.NymedlemCbox);
            this.Controls.Add(this.nymedlemBt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tränareLbox);
            this.Controls.Add(this.TräningsgruppCbox);
            this.Controls.Add(this.NytränareBt);
            this.Controls.Add(this.NyGruppBt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MedlmLbox);
            this.Name = "Cirkusträningsgrupp";
            this.Text = "Cirkusträningsgrupp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox MedlmLbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button NyGruppBt;
        private System.Windows.Forms.Button NytränareBt;
        private System.Windows.Forms.ComboBox TräningsgruppCbox;
        private System.Windows.Forms.ListBox tränareLbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button nymedlemBt;
        private System.Windows.Forms.ComboBox NymedlemCbox;
        private System.Windows.Forms.ComboBox NytränareCbox;
        private System.Windows.Forms.Button abortBt;
        private System.Windows.Forms.Label EfterNamnLb;
        private System.Windows.Forms.Label förnamnLb;
        private System.Windows.Forms.Label MedlNrLb;
        private System.Windows.Forms.Label Mednr2Lb;
        private System.Windows.Forms.Label Förnamn2Lb;
        private System.Windows.Forms.Label label6;
    }
}