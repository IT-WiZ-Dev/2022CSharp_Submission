
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1total = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelAmari = new System.Windows.Forms.Label();
            this.buttonKeisan = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxMoney = new System.Windows.Forms.TextBox();
            this.textBoxNum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "税金抜き金額";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "人数";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "一人あたり";
            // 
            // label1total
            // 
            this.label1total.AutoSize = true;
            this.label1total.Location = new System.Drawing.Point(54, 147);
            this.label1total.Name = "label1total";
            this.label1total.Size = new System.Drawing.Size(0, 18);
            this.label1total.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(324, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "余り";
            // 
            // labelAmari
            // 
            this.labelAmari.AutoSize = true;
            this.labelAmari.Location = new System.Drawing.Point(324, 147);
            this.labelAmari.Name = "labelAmari";
            this.labelAmari.Size = new System.Drawing.Size(0, 18);
            this.labelAmari.TabIndex = 5;
            // 
            // buttonKeisan
            // 
            this.buttonKeisan.Location = new System.Drawing.Point(57, 194);
            this.buttonKeisan.Name = "buttonKeisan";
            this.buttonKeisan.Size = new System.Drawing.Size(370, 53);
            this.buttonKeisan.TabIndex = 6;
            this.buttonKeisan.Text = "計算する";
            this.buttonKeisan.UseVisualStyleBackColor = true;
            this.buttonKeisan.Click += new System.EventHandler(this.buttonKeisan_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(163, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "円";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(437, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 18);
            this.label8.TabIndex = 8;
            this.label8.Text = "人";
            // 
            // textBoxMoney
            // 
            this.textBoxMoney.Location = new System.Drawing.Point(57, 57);
            this.textBoxMoney.Name = "textBoxMoney";
            this.textBoxMoney.Size = new System.Drawing.Size(100, 25);
            this.textBoxMoney.TabIndex = 9;
            // 
            // textBoxNum
            // 
            this.textBoxNum.Location = new System.Drawing.Point(327, 57);
            this.textBoxNum.Name = "textBoxNum";
            this.textBoxNum.Size = new System.Drawing.Size(100, 25);
            this.textBoxNum.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 453);
            this.Controls.Add(this.textBoxNum);
            this.Controls.Add(this.textBoxMoney);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonKeisan);
            this.Controls.Add(this.labelAmari);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1total);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1total;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelAmari;
        private System.Windows.Forms.Button buttonKeisan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxMoney;
        private System.Windows.Forms.TextBox textBoxNum;
    }
}

