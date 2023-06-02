
namespace WeekOfDay
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
            this.youbi = new System.Windows.Forms.Label();
            this.labelweek = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.TextBox();
            this.month = new System.Windows.Forms.NumericUpDown();
            this.day = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.month)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.day)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "西暦年";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "月";
            // 
            // youbi
            // 
            this.youbi.AutoSize = true;
            this.youbi.Location = new System.Drawing.Point(378, 54);
            this.youbi.Name = "youbi";
            this.youbi.Size = new System.Drawing.Size(26, 18);
            this.youbi.TabIndex = 2;
            this.youbi.Text = "日";
            // 
            // labelweek
            // 
            this.labelweek.AutoSize = true;
            this.labelweek.Location = new System.Drawing.Point(493, 112);
            this.labelweek.Name = "labelweek";
            this.labelweek.Size = new System.Drawing.Size(44, 18);
            this.labelweek.TabIndex = 3;
            this.labelweek.Text = "曜日";
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(85, 110);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(100, 25);
            this.year.TabIndex = 4;
            // 
            // month
            // 
            this.month.Location = new System.Drawing.Point(230, 111);
            this.month.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.month.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(60, 25);
            this.month.TabIndex = 5;
            this.month.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // day
            // 
            this.day.Location = new System.Drawing.Point(381, 110);
            this.day.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.day.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(56, 25);
            this.day.TabIndex = 6;
            this.day.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(85, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(460, 65);
            this.button1.TabIndex = 7;
            this.button1.Text = "曜日算出";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 305);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.day);
            this.Controls.Add(this.month);
            this.Controls.Add(this.year);
            this.Controls.Add(this.labelweek);
            this.Controls.Add(this.youbi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.month)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.day)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label youbi;
        private System.Windows.Forms.Label labelweek;
        private System.Windows.Forms.TextBox year;
        private System.Windows.Forms.NumericUpDown month;
        private System.Windows.Forms.NumericUpDown day;
        private System.Windows.Forms.Button button1;
    }
}

