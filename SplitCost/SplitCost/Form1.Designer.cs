
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
            this.textBoxTaxLess = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPeople = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelPerperson = new System.Windows.Forms.Label();
            this.labelRemainder = new System.Windows.Forms.Label();
            this.buttonCalculation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "税抜き金額";
            // 
            // textBoxTaxLess
            // 
            this.textBoxTaxLess.Location = new System.Drawing.Point(33, 55);
            this.textBoxTaxLess.Name = "textBoxTaxLess";
            this.textBoxTaxLess.Size = new System.Drawing.Size(125, 25);
            this.textBoxTaxLess.TabIndex = 1;
            this.textBoxTaxLess.Text = "0";
            this.textBoxTaxLess.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "円";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "人数";
            // 
            // textBoxPeople
            // 
            this.textBoxPeople.Location = new System.Drawing.Point(251, 55);
            this.textBoxPeople.Name = "textBoxPeople";
            this.textBoxPeople.Size = new System.Drawing.Size(97, 25);
            this.textBoxPeople.TabIndex = 2;
            this.textBoxPeople.Text = "0";
            this.textBoxPeople.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(358, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "人";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "一人当たり";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(251, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "余り";
            // 
            // labelPerperson
            // 
            this.labelPerperson.AutoSize = true;
            this.labelPerperson.Location = new System.Drawing.Point(33, 177);
            this.labelPerperson.Name = "labelPerperson";
            this.labelPerperson.Size = new System.Drawing.Size(35, 18);
            this.labelPerperson.TabIndex = 0;
            this.labelPerperson.Text = "0円";
            // 
            // labelRemainder
            // 
            this.labelRemainder.AutoSize = true;
            this.labelRemainder.Location = new System.Drawing.Point(251, 177);
            this.labelRemainder.Name = "labelRemainder";
            this.labelRemainder.Size = new System.Drawing.Size(35, 18);
            this.labelRemainder.TabIndex = 0;
            this.labelRemainder.Text = "0円";
            // 
            // buttonCalculation
            // 
            this.buttonCalculation.Location = new System.Drawing.Point(24, 213);
            this.buttonCalculation.Name = "buttonCalculation";
            this.buttonCalculation.Size = new System.Drawing.Size(360, 37);
            this.buttonCalculation.TabIndex = 3;
            this.buttonCalculation.Text = "計算する";
            this.buttonCalculation.UseVisualStyleBackColor = true;
            this.buttonCalculation.Click += new System.EventHandler(this.buttonCalculation_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 255);
            this.Controls.Add(this.buttonCalculation);
            this.Controls.Add(this.labelRemainder);
            this.Controls.Add(this.labelPerperson);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPeople);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTaxLess);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "割り勘";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTaxLess;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPeople;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelPerperson;
        private System.Windows.Forms.Label labelRemainder;
        private System.Windows.Forms.Button buttonCalculation;
    }
}

