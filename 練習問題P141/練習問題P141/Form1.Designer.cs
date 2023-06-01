
namespace 練習問題P141
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
            this.textBoxseireki = new System.Windows.Forms.TextBox();
            this.numericmonth = new System.Windows.Forms.NumericUpDown();
            this.numericday = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericmonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericday)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "西暦年";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "月";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(334, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "日";
            // 
            // textBoxseireki
            // 
            this.textBoxseireki.Location = new System.Drawing.Point(66, 87);
            this.textBoxseireki.Name = "textBoxseireki";
            this.textBoxseireki.Size = new System.Drawing.Size(100, 22);
            this.textBoxseireki.TabIndex = 3;
            // 
            // numericmonth
            // 
            this.numericmonth.Location = new System.Drawing.Point(225, 87);
            this.numericmonth.Name = "numericmonth";
            this.numericmonth.Size = new System.Drawing.Size(58, 22);
            this.numericmonth.TabIndex = 4;
            // 
            // numericday
            // 
            this.numericday.Location = new System.Drawing.Point(337, 88);
            this.numericday.Name = "numericday";
            this.numericday.Size = new System.Drawing.Size(64, 22);
            this.numericday.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(90, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(283, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "曜日算出";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(479, 90);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(28, 15);
            this.labelResult.TabIndex = 7;
            this.labelResult.Text = "aaa";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericday);
            this.Controls.Add(this.numericmonth);
            this.Controls.Add(this.textBoxseireki);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericmonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericday)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxseireki;
        private System.Windows.Forms.NumericUpDown numericmonth;
        private System.Windows.Forms.NumericUpDown numericday;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelResult;
    }
}

