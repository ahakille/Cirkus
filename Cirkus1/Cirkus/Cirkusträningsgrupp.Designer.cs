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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(42, 99);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(384, 160);
            this.listBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // NyGruppBt
            // 
            this.NyGruppBt.Location = new System.Drawing.Point(187, 60);
            this.NyGruppBt.Name = "NyGruppBt";
            this.NyGruppBt.Size = new System.Drawing.Size(75, 23);
            this.NyGruppBt.TabIndex = 2;
            this.NyGruppBt.Text = "Ny grupp";
            this.NyGruppBt.UseVisualStyleBackColor = true;
            // 
            // NytränareBt
            // 
            this.NytränareBt.Location = new System.Drawing.Point(279, 60);
            this.NytränareBt.Name = "NytränareBt";
            this.NytränareBt.Size = new System.Drawing.Size(75, 23);
            this.NytränareBt.TabIndex = 3;
            this.NytränareBt.Text = "Ny tränare";
            this.NytränareBt.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(42, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // Cirkusträningsgrupp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 314);
            this.Controls.Add(this.comboBox1);
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
        private System.Windows.Forms.ComboBox comboBox1;
    }
}