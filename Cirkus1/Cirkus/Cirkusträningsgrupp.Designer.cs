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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NyGruppBt = new System.Windows.Forms.Button();
            this.NytränareBt = new System.Windows.Forms.Button();
            this.TräningsgruppCbox = new System.Windows.Forms.ComboBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(41, 205);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(384, 186);
            this.listBox1.TabIndex = 0;
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
            this.NyGruppBt.Location = new System.Drawing.Point(186, 27);
            this.NyGruppBt.Name = "NyGruppBt";
            this.NyGruppBt.Size = new System.Drawing.Size(75, 23);
            this.NyGruppBt.TabIndex = 2;
            this.NyGruppBt.Text = "Ny grupp";
            this.NyGruppBt.UseVisualStyleBackColor = true;
            // 
            // NytränareBt
            // 
            this.NytränareBt.Location = new System.Drawing.Point(278, 27);
            this.NytränareBt.Name = "NytränareBt";
            this.NytränareBt.Size = new System.Drawing.Size(75, 23);
            this.NytränareBt.TabIndex = 3;
            this.NytränareBt.Text = "Ny tränare";
            this.NytränareBt.UseVisualStyleBackColor = true;
            // 
            // TräningsgruppCbox
            // 
            this.TräningsgruppCbox.FormattingEnabled = true;
            this.TräningsgruppCbox.Location = new System.Drawing.Point(41, 27);
            this.TräningsgruppCbox.Name = "TräningsgruppCbox";
            this.TräningsgruppCbox.Size = new System.Drawing.Size(121, 21);
            this.TräningsgruppCbox.TabIndex = 4;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(42, 68);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(384, 82);
            this.listBox2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Gruppmedlemar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tränare";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(350, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Ny medlem";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Cirkusträningsgrupp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 418);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.TräningsgruppCbox);
            this.Controls.Add(this.NytränareBt);
            this.Controls.Add(this.NyGruppBt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "Cirkusträningsgrupp";
            this.Text = "Cirkusträningsgrupp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button NyGruppBt;
        private System.Windows.Forms.Button NytränareBt;
        private System.Windows.Forms.ComboBox TräningsgruppCbox;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}