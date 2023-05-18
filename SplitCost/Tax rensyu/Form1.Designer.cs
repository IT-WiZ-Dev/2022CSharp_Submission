
namespace Tax_rensyu
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
            this.labelmoney = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelamari = new System.Windows.Forms.Label();
            this.textBoxmoney = new System.Windows.Forms.TextBox();
            this.people = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "税抜き金額";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "人数";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "一人あたり";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "円";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(269, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "人";
            this.label5.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelmoney
            // 
            this.labelmoney.AutoSize = true;
            this.labelmoney.Location = new System.Drawing.Point(12, 116);
            this.labelmoney.Name = "labelmoney";
            this.labelmoney.Size = new System.Drawing.Size(43, 15);
            this.labelmoney.TabIndex = 0;
            this.labelmoney.Text = "label1";
            this.labelmoney.Click += new System.EventHandler(this.label4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(160, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "余り";
            this.label7.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelamari
            // 
            this.labelamari.AutoSize = true;
            this.labelamari.Location = new System.Drawing.Point(160, 116);
            this.labelamari.Name = "labelamari";
            this.labelamari.Size = new System.Drawing.Size(43, 15);
            this.labelamari.TabIndex = 0;
            this.labelamari.Text = "label1";
            this.labelamari.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBoxmoney
            // 
            this.textBoxmoney.Location = new System.Drawing.Point(12, 37);
            this.textBoxmoney.Name = "textBoxmoney";
            this.textBoxmoney.Size = new System.Drawing.Size(100, 22);
            this.textBoxmoney.TabIndex = 1;
            // 
            // people
            // 
            this.people.Location = new System.Drawing.Point(163, 37);
            this.people.Name = "people";
            this.people.Size = new System.Drawing.Size(100, 22);
            this.people.TabIndex = 2;
            this.people.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "計算する";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 197);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.people);
            this.Controls.Add(this.textBoxmoney);
            this.Controls.Add(this.labelamari);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelmoney);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.Label labelmoney;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelamari;
        private System.Windows.Forms.TextBox textBoxmoney;
        private System.Windows.Forms.TextBox people;
        private System.Windows.Forms.Button button1;
    }
}

