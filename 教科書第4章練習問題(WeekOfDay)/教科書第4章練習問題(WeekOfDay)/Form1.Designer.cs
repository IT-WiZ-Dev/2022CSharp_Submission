
namespace 教科書第4章練習問題_WeekOfDay_
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSeireki = new System.Windows.Forms.TextBox();
            this.numericUpDownMonth = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDay = new System.Windows.Forms.NumericUpDown();
            this.labelYoubi = new System.Windows.Forms.Label();
            this.buttonYoubisansyutsu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDay)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "西暦年";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "月";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(330, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "日";
            // 
            // textBoxSeireki
            // 
            this.textBoxSeireki.Location = new System.Drawing.Point(40, 80);
            this.textBoxSeireki.Name = "textBoxSeireki";
            this.textBoxSeireki.Size = new System.Drawing.Size(100, 25);
            this.textBoxSeireki.TabIndex = 3;
            // 
            // numericUpDownMonth
            // 
            this.numericUpDownMonth.Location = new System.Drawing.Point(167, 80);
            this.numericUpDownMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMonth.Name = "numericUpDownMonth";
            this.numericUpDownMonth.Size = new System.Drawing.Size(120, 25);
            this.numericUpDownMonth.TabIndex = 4;
            this.numericUpDownMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownDay
            // 
            this.numericUpDownDay.Location = new System.Drawing.Point(333, 80);
            this.numericUpDownDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numericUpDownDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDay.Name = "numericUpDownDay";
            this.numericUpDownDay.Size = new System.Drawing.Size(120, 25);
            this.numericUpDownDay.TabIndex = 5;
            this.numericUpDownDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelYoubi
            // 
            this.labelYoubi.AutoSize = true;
            this.labelYoubi.Location = new System.Drawing.Point(492, 80);
            this.labelYoubi.Name = "labelYoubi";
            this.labelYoubi.Size = new System.Drawing.Size(52, 18);
            this.labelYoubi.TabIndex = 6;
            this.labelYoubi.Text = "label4";
            // 
            // buttonYoubisansyutsu
            // 
            this.buttonYoubisansyutsu.Location = new System.Drawing.Point(40, 148);
            this.buttonYoubisansyutsu.Name = "buttonYoubisansyutsu";
            this.buttonYoubisansyutsu.Size = new System.Drawing.Size(499, 32);
            this.buttonYoubisansyutsu.TabIndex = 7;
            this.buttonYoubisansyutsu.Text = "曜日算出";
            this.buttonYoubisansyutsu.UseVisualStyleBackColor = true;
            this.buttonYoubisansyutsu.Click += new System.EventHandler(this.buttonYoubisansyutsu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 224);
            this.Controls.Add(this.buttonYoubisansyutsu);
            this.Controls.Add(this.labelYoubi);
            this.Controls.Add(this.numericUpDownDay);
            this.Controls.Add(this.numericUpDownMonth);
            this.Controls.Add(this.textBoxSeireki);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSeireki;
        private System.Windows.Forms.NumericUpDown numericUpDownMonth;
        private System.Windows.Forms.NumericUpDown numericUpDownDay;
        private System.Windows.Forms.Label labelYoubi;
        private System.Windows.Forms.Button buttonYoubisansyutsu;
    }
}

