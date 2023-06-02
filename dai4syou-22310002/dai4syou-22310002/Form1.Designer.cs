namespace dai4syou_22310002
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.seireki = new System.Windows.Forms.Label();
            this.tuki = new System.Windows.Forms.Label();
            this.hi = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.youbidasu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // seireki
            // 
            this.seireki.AutoSize = true;
            this.seireki.Location = new System.Drawing.Point(91, 61);
            this.seireki.Name = "seireki";
            this.seireki.Size = new System.Drawing.Size(62, 18);
            this.seireki.TabIndex = 0;
            this.seireki.Text = "西暦年";
            // 
            // tuki
            // 
            this.tuki.AutoSize = true;
            this.tuki.Location = new System.Drawing.Point(276, 61);
            this.tuki.Name = "tuki";
            this.tuki.Size = new System.Drawing.Size(26, 18);
            this.tuki.TabIndex = 1;
            this.tuki.Text = "月";
            // 
            // hi
            // 
            this.hi.AutoSize = true;
            this.hi.Location = new System.Drawing.Point(456, 61);
            this.hi.Name = "hi";
            this.hi.Size = new System.Drawing.Size(26, 18);
            this.hi.TabIndex = 2;
            this.hi.Text = "日";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(94, 122);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 25);
            this.textBox1.TabIndex = 3;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(255, 121);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(135, 25);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(442, 122);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(135, 25);
            this.numericUpDown2.TabIndex = 5;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(648, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 28);
            this.label1.TabIndex = 6;
            // 
            // youbidasu
            // 
            this.youbidasu.Location = new System.Drawing.Point(162, 184);
            this.youbidasu.Name = "youbidasu";
            this.youbidasu.Size = new System.Drawing.Size(330, 29);
            this.youbidasu.TabIndex = 7;
            this.youbidasu.Text = "曜日算出";
            this.youbidasu.UseVisualStyleBackColor = true;
            this.youbidasu.Click += new System.EventHandler(this.youbidasu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 235);
            this.Controls.Add(this.youbidasu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.hi);
            this.Controls.Add(this.tuki);
            this.Controls.Add(this.seireki);
            this.Name = "Form1";
            this.Text = "曜日算出";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label seireki;
        private System.Windows.Forms.Label tuki;
        private System.Windows.Forms.Label hi;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button youbidasu;
    }
}

