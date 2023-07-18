
namespace WindowsFormsApp3_AddTax
{
    partial class FormAddTax
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
            this.textBoxMoney = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelAddTax = new System.Windows.Forms.Label();
            this.buttonAddTax = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "金額";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "税込金額";
            // 
            // textBoxMoney
            // 
            this.textBoxMoney.Location = new System.Drawing.Point(32, 57);
            this.textBoxMoney.Name = "textBoxMoney";
            this.textBoxMoney.Size = new System.Drawing.Size(100, 25);
            this.textBoxMoney.TabIndex = 0;
            this.textBoxMoney.Text = "0";
            this.textBoxMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "円";
            // 
            // labelAddTax
            // 
            this.labelAddTax.AutoSize = true;
            this.labelAddTax.Location = new System.Drawing.Point(262, 64);
            this.labelAddTax.Name = "labelAddTax";
            this.labelAddTax.Size = new System.Drawing.Size(35, 18);
            this.labelAddTax.TabIndex = 4;
            this.labelAddTax.Text = "0円";
            // 
            // buttonAddTax
            // 
            this.buttonAddTax.Location = new System.Drawing.Point(151, 125);
            this.buttonAddTax.Name = "buttonAddTax";
            this.buttonAddTax.Size = new System.Drawing.Size(136, 31);
            this.buttonAddTax.TabIndex = 1;
            this.buttonAddTax.Text = "消費税追加";
            this.buttonAddTax.UseVisualStyleBackColor = true;
            this.buttonAddTax.Click += new System.EventHandler(this.buttonAddTax_Click);
            // 
            // FormAddTax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 217);
            this.Controls.Add(this.buttonAddTax);
            this.Controls.Add(this.labelAddTax);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxMoney);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAddTax";
            this.Text = "消費税追加";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMoney;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelAddTax;
        private System.Windows.Forms.Button buttonAddTax;
    }
}

