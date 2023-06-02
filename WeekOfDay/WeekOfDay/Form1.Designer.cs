
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
            this.label3 = new System.Windows.Forms.Label();
            this.text = new System.Windows.Forms.TextBox();
            this.NumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.NumericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.ans = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "西暦年";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "月";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "日";
            // 
            // text
            // 
            this.text.Location = new System.Drawing.Point(28, 64);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(97, 25);
            this.text.TabIndex = 1;
            // 
            // NumericUpDown1
            // 
            this.NumericUpDown1.Location = new System.Drawing.Point(167, 64);
            this.NumericUpDown1.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.NumericUpDown1.Name = "NumericUpDown1";
            this.NumericUpDown1.Size = new System.Drawing.Size(63, 25);
            this.NumericUpDown1.TabIndex = 2;
            // 
            // NumericUpDown2
            // 
            this.NumericUpDown2.Location = new System.Drawing.Point(272, 64);
            this.NumericUpDown2.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.NumericUpDown2.Name = "NumericUpDown2";
            this.NumericUpDown2.Size = new System.Drawing.Size(63, 25);
            this.NumericUpDown2.TabIndex = 2;
            // 
            // ans
            // 
            this.ans.AutoSize = true;
            this.ans.Location = new System.Drawing.Point(379, 64);
            this.ans.Name = "ans";
            this.ans.Size = new System.Drawing.Size(0, 18);
            this.ans.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(461, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "曜日算出";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 175);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ans);
            this.Controls.Add(this.NumericUpDown2);
            this.Controls.Add(this.NumericUpDown1);
            this.Controls.Add(this.text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text;
        private System.Windows.Forms.NumericUpDown NumericUpDown1;
        private System.Windows.Forms.NumericUpDown NumericUpDown2;
        private System.Windows.Forms.Label ans;
        private System.Windows.Forms.Button button1;
    }
}

