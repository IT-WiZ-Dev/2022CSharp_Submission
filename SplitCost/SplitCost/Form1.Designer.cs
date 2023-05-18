
namespace SplitCost
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
            this.textBoxMoney = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxHuman = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelMoney1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelMoney2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "税抜き金額";
            // 
            // textBoxMoney
            // 
            this.textBoxMoney.Location = new System.Drawing.Point(16, 35);
            this.textBoxMoney.Name = "textBoxMoney";
            this.textBoxMoney.Size = new System.Drawing.Size(122, 25);
            this.textBoxMoney.TabIndex = 0;
            this.textBoxMoney.Text = "0";
            this.textBoxMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // textBoxHuman
            // 
            this.textBoxHuman.Location = new System.Drawing.Point(230, 35);
            this.textBoxHuman.Name = "textBoxHuman";
            this.textBoxHuman.Size = new System.Drawing.Size(122, 25);
            this.textBoxHuman.TabIndex = 1;
            this.textBoxHuman.Text = "0";
            this.textBoxHuman.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "円";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(358, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "人";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "一人あたり";
            // 
            // labelMoney1
            // 
            this.labelMoney1.AutoSize = true;
            this.labelMoney1.Location = new System.Drawing.Point(19, 139);
            this.labelMoney1.Name = "labelMoney1";
            this.labelMoney1.Size = new System.Drawing.Size(35, 18);
            this.labelMoney1.TabIndex = 7;
            this.labelMoney1.Text = "0円";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(230, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 18);
            this.label7.TabIndex = 8;
            this.label7.Text = "余り";
            // 
            // labelMoney2
            // 
            this.labelMoney2.AutoSize = true;
            this.labelMoney2.Location = new System.Drawing.Point(230, 139);
            this.labelMoney2.Name = "labelMoney2";
            this.labelMoney2.Size = new System.Drawing.Size(35, 18);
            this.labelMoney2.TabIndex = 9;
            this.labelMoney2.Text = "0円";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(375, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "計算する";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 232);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelMoney2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelMoney1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxHuman);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxMoney);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMoney;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxHuman;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelMoney1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelMoney2;
        private System.Windows.Forms.Button button1;
    }
}

