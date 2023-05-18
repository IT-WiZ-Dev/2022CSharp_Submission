
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelSplitCost = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelSurplus = new System.Windows.Forms.Label();
            this.Money = new System.Windows.Forms.TextBox();
            this.People = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "税抜き金額";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "人数";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "円";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(428, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "人";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "一人あたり";
            // 
            // labelSplitCost
            // 
            this.labelSplitCost.AutoSize = true;
            this.labelSplitCost.Location = new System.Drawing.Point(70, 173);
            this.labelSplitCost.Name = "labelSplitCost";
            this.labelSplitCost.Size = new System.Drawing.Size(43, 15);
            this.labelSplitCost.TabIndex = 5;
            this.labelSplitCost.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(297, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "余り";
            // 
            // labelSurplus
            // 
            this.labelSurplus.AutoSize = true;
            this.labelSurplus.Location = new System.Drawing.Point(297, 173);
            this.labelSurplus.Name = "labelSurplus";
            this.labelSurplus.Size = new System.Drawing.Size(43, 15);
            this.labelSurplus.TabIndex = 7;
            this.labelSurplus.Text = "label8";
            // 
            // Money
            // 
            this.Money.Location = new System.Drawing.Point(64, 68);
            this.Money.Name = "Money";
            this.Money.Size = new System.Drawing.Size(131, 22);
            this.Money.TabIndex = 8;
            this.Money.Text = "0";
            this.Money.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // People
            // 
            this.People.Location = new System.Drawing.Point(300, 68);
            this.People.Name = "People";
            this.People.Size = new System.Drawing.Size(122, 22);
            this.People.TabIndex = 9;
            this.People.Text = "0";
            this.People.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(73, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(377, 29);
            this.button1.TabIndex = 10;
            this.button1.Text = "計算する";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 307);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.People);
            this.Controls.Add(this.Money);
            this.Controls.Add(this.labelSurplus);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelSplitCost);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelSplitCost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelSurplus;
        private System.Windows.Forms.TextBox Money;
        private System.Windows.Forms.TextBox People;
        private System.Windows.Forms.Button button1;
    }
}

