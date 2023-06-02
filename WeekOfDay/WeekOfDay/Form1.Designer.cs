namespace WindowsFormApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("メイリオ", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(35, 9);
            label1.Name = "label1";
            label1.Size = new Size(66, 27);
            label1.TabIndex = 0;
            label1.Text = "西暦年";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("メイリオ", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(190, 9);
            label2.Name = "label2";
            label2.Size = new Size(30, 27);
            label2.TabIndex = 1;
            label2.Text = "月";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("メイリオ", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(323, 9);
            label3.Name = "label3";
            label3.Size = new Size(30, 27);
            label3.TabIndex = 2;
            label3.Text = "日";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("メイリオ", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(461, 40);
            label4.Name = "label4";
            label4.Size = new Size(102, 27);
            label4.TabIndex = 3;
            label4.Text = "金曜日です";
            label4.Click += label4_Click;
            // 
            // button1
            // 
            button1.Location = new Point(35, 108);
            button1.Name = "button1";
            button1.Size = new Size(565, 29);
            button1.TabIndex = 4;
            button1.Text = "曜日算出";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(190, 40);
            numericUpDown1.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(82, 27);
            numericUpDown1.TabIndex = 5;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(323, 39);
            numericUpDown2.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            numericUpDown2.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(87, 27);
            numericUpDown2.TabIndex = 6;
            numericUpDown2.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(35, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(88, 27);
            textBox1.TabIndex = 7;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 153);
            Controls.Add(textBox1);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "曜日算出";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private TextBox textBox1;
    }
}