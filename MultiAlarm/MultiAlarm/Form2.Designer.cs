namespace MultiAlarm
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
            this.numerichour = new System.Windows.Forms.NumericUpDown();
            this.numericminute = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numerichour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericminute)).BeginInit();
            this.SuspendLayout();
            // 
            // numerichour
            // 
            this.numerichour.Location = new System.Drawing.Point(22, 61);
            this.numerichour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numerichour.Name = "numerichour";
            this.numerichour.Size = new System.Drawing.Size(120, 25);
            this.numerichour.TabIndex = 0;
            // 
            // numericminute
            // 
            this.numericminute.Location = new System.Drawing.Point(237, 61);
            this.numericminute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericminute.Name = "numericminute";
            this.numericminute.Size = new System.Drawing.Size(120, 25);
            this.numericminute.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(94, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "設定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(237, 164);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 28);
            this.button2.TabIndex = 3;
            this.button2.Text = "戻る";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 237);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericminute);
            this.Controls.Add(this.numerichour);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numerichour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericminute)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numerichour;
        private System.Windows.Forms.NumericUpDown numericminute;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}