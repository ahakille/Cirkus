namespace Cirkus
{
    partial class Nyträningsgrupp
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
            this.laggtillBt = new System.Windows.Forms.Button();
            this.laggtillTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AvbrytBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // laggtillBt
            // 
            this.laggtillBt.Location = new System.Drawing.Point(27, 78);
            this.laggtillBt.Name = "laggtillBt";
            this.laggtillBt.Size = new System.Drawing.Size(75, 23);
            this.laggtillBt.TabIndex = 0;
            this.laggtillBt.Text = "Lägg till";
            this.laggtillBt.UseVisualStyleBackColor = true;
            this.laggtillBt.Click += new System.EventHandler(this.laggtillBt_Click);
            // 
            // laggtillTxt
            // 
            this.laggtillTxt.Location = new System.Drawing.Point(27, 52);
            this.laggtillTxt.Name = "laggtillTxt";
            this.laggtillTxt.Size = new System.Drawing.Size(156, 20);
            this.laggtillTxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Namnet";
            // 
            // AvbrytBt
            // 
            this.AvbrytBt.Location = new System.Drawing.Point(108, 78);
            this.AvbrytBt.Name = "AvbrytBt";
            this.AvbrytBt.Size = new System.Drawing.Size(75, 23);
            this.AvbrytBt.TabIndex = 3;
            this.AvbrytBt.Text = "Avbryt";
            this.AvbrytBt.UseVisualStyleBackColor = true;
            this.AvbrytBt.Click += new System.EventHandler(this.AvbrytBt_Click);
            // 
            // Nyträningsgrupp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 160);
            this.Controls.Add(this.AvbrytBt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.laggtillTxt);
            this.Controls.Add(this.laggtillBt);
            this.Name = "Nyträningsgrupp";
            this.Text = "Nyträningsgrupp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button laggtillBt;
        private System.Windows.Forms.TextBox laggtillTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AvbrytBt;
    }
}