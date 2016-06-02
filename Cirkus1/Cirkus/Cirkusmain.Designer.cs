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
            this.button2 = new System.Windows.Forms.Button();
            this.träningsgruppBT = new System.Windows.Forms.Button();
            this.narvaroBt = new System.Windows.Forms.Button();
            this.updateMedlemBt = new System.Windows.Forms.Button();
            this.tillfälleBox = new System.Windows.Forms.ListBox();
            this.NyttTräningstillfälleBt = new System.Windows.Forms.Button();
            this.LbMedlem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 418);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(33, 207);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Uppdatera";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // träningsgruppBT
            // 
            this.träningsgruppBT.Location = new System.Drawing.Point(562, 113);
            this.träningsgruppBT.Name = "träningsgruppBT";
            this.träningsgruppBT.Size = new System.Drawing.Size(146, 53);
            this.träningsgruppBT.TabIndex = 8;
            this.träningsgruppBT.Text = "Hantera Träningsgrupper";
            this.träningsgruppBT.UseVisualStyleBackColor = true;
            this.träningsgruppBT.Click += new System.EventHandler(this.träningsgruppBT_Click);
            // 
            // narvaroBt
            // 
            this.narvaroBt.Location = new System.Drawing.Point(562, 323);
            this.narvaroBt.Name = "narvaroBt";
            this.narvaroBt.Size = new System.Drawing.Size(145, 70);
            this.narvaroBt.TabIndex = 9;
            this.narvaroBt.Text = "Närvarokort";
            this.narvaroBt.UseVisualStyleBackColor = true;
            this.narvaroBt.Click += new System.EventHandler(this.narvaroBt_Click);
            // 
            // updateMedlemBt
            // 
            this.updateMedlemBt.Location = new System.Drawing.Point(562, 38);
            this.updateMedlemBt.Name = "updateMedlemBt";
            this.updateMedlemBt.Size = new System.Drawing.Size(145, 53);
            this.updateMedlemBt.TabIndex = 10;
            this.updateMedlemBt.Text = "Hantera medlemar";
            this.updateMedlemBt.UseVisualStyleBackColor = true;
            this.updateMedlemBt.Click += new System.EventHandler(this.updateMedlemBt_Click);
            // 
            // tillfälleBox
            // 
            this.tillfälleBox.FormattingEnabled = true;
            this.tillfälleBox.Location = new System.Drawing.Point(36, 246);
            this.tillfälleBox.Name = "tillfälleBox";
            this.tillfälleBox.Size = new System.Drawing.Size(482, 147);
            this.tillfälleBox.TabIndex = 12;
            // 
            // NyttTräningstillfälleBt
            // 
            this.NyttTräningstillfälleBt.Location = new System.Drawing.Point(562, 246);
            this.NyttTräningstillfälleBt.Name = "NyttTräningstillfälleBt";
            this.NyttTräningstillfälleBt.Size = new System.Drawing.Size(146, 53);
            this.NyttTräningstillfälleBt.TabIndex = 13;
            this.NyttTräningstillfälleBt.Text = "Skapa nytt träningstillfälle";
            this.NyttTräningstillfälleBt.UseVisualStyleBackColor = true;
            this.NyttTräningstillfälleBt.Click += new System.EventHandler(this.NyttTräningstillfälleBt_Click);
            // 
            // LbMedlem
            // 
            this.LbMedlem.AutoSize = true;
            this.LbMedlem.Location = new System.Drawing.Point(45, 78);
            this.LbMedlem.Name = "LbMedlem";
            this.LbMedlem.Size = new System.Drawing.Size(35, 13);
            this.LbMedlem.TabIndex = 14;
            this.LbMedlem.Text = "label1";
            // 
            // Cirkusmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 453);
            this.Controls.Add(this.LbMedlem);
            this.Controls.Add(this.NyttTräningstillfälleBt);
            this.Controls.Add(this.tillfälleBox);
            this.Controls.Add(this.updateMedlemBt);
            this.Controls.Add(this.narvaroBt);
            this.Controls.Add(this.träningsgruppBT);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Cirkusmain";
            this.Text = "Cirkus - Kul & Bus  Admin";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button träningsgruppBT;
        private System.Windows.Forms.Button narvaroBt;
        private System.Windows.Forms.Button updateMedlemBt;
        private System.Windows.Forms.ListBox tillfälleBox;
        private System.Windows.Forms.Button NyttTräningstillfälleBt;
        private System.Windows.Forms.Label LbMedlem;
    }
}

