
namespace 第六章練習問題
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownHour = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMnt = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMnt)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "時";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "分";
            // 
            // numericUpDownHour
            // 
            this.numericUpDownHour.Location = new System.Drawing.Point(182, 25);
            this.numericUpDownHour.Name = "numericUpDownHour";
            this.numericUpDownHour.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownHour.TabIndex = 2;
            // 
            // numericUpDownMnt
            // 
            this.numericUpDownMnt.Location = new System.Drawing.Point(182, 106);
            this.numericUpDownMnt.Name = "numericUpDownMnt";
            this.numericUpDownMnt.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownMnt.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(118, 242);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 42);
            this.button2.TabIndex = 5;
            this.button2.Text = "キャンセル";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDownMnt);
            this.Controls.Add(this.numericUpDownHour);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "時刻設定";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMnt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownHour;
        private System.Windows.Forms.NumericUpDown numericUpDownMnt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}