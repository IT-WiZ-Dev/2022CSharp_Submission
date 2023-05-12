
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelHitori = new System.Windows.Forms.Label();
            this.labelAmari = new System.Windows.Forms.Label();
            this.buttonKeisan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "税抜き金額";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "人数";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(43, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 25);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(288, 79);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 25);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "0";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "円";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(421, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "円";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "一人あたり";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(288, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "余り";
            // 
            // labelHitori
            // 
            this.labelHitori.AutoSize = true;
            this.labelHitori.Location = new System.Drawing.Point(43, 184);
            this.labelHitori.Name = "labelHitori";
            this.labelHitori.Size = new System.Drawing.Size(0, 18);
            this.labelHitori.TabIndex = 8;
            // 
            // labelAmari
            // 
            this.labelAmari.AutoSize = true;
            this.labelAmari.Location = new System.Drawing.Point(288, 183);
            this.labelAmari.Name = "labelAmari";
            this.labelAmari.Size = new System.Drawing.Size(0, 18);
            this.labelAmari.TabIndex = 9;
            // 
            // buttonKeisan
            // 
            this.buttonKeisan.Location = new System.Drawing.Point(163, 234);
            this.buttonKeisan.Name = "buttonKeisan";
            this.buttonKeisan.Size = new System.Drawing.Size(153, 32);
            this.buttonKeisan.TabIndex = 3;
            this.buttonKeisan.Text = "計算する";
            this.buttonKeisan.UseVisualStyleBackColor = true;
            this.buttonKeisan.Click += new System.EventHandler(this.buttonKeisan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonKeisan);
            this.Controls.Add(this.labelAmari);
            this.Controls.Add(this.labelHitori);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "割り勘";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelHitori;
        private System.Windows.Forms.Label labelAmari;
        private System.Windows.Forms.Button buttonKeisan;
    }
}

