
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
            this.textBoxzeinuki = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxninzu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelamari = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelwarikan = new System.Windows.Forms.Label();
            this.buttonkeisan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "税抜き金額";
            // 
            // textBoxzeinuki
            // 
            this.textBoxzeinuki.Location = new System.Drawing.Point(15, 34);
            this.textBoxzeinuki.Name = "textBoxzeinuki";
            this.textBoxzeinuki.Size = new System.Drawing.Size(130, 22);
            this.textBoxzeinuki.TabIndex = 1;
            this.textBoxzeinuki.Text = "0";
            this.textBoxzeinuki.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "円";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "人数";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(329, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "人";
            // 
            // textBoxninzu
            // 
            this.textBoxninzu.Location = new System.Drawing.Point(193, 34);
            this.textBoxninzu.Name = "textBoxninzu";
            this.textBoxninzu.Size = new System.Drawing.Size(130, 22);
            this.textBoxninzu.TabIndex = 1;
            this.textBoxninzu.Text = "0";
            this.textBoxninzu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "一人あたり";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "円";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(190, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "余り";
            // 
            // labelamari
            // 
            this.labelamari.AutoSize = true;
            this.labelamari.Location = new System.Drawing.Point(190, 124);
            this.labelamari.Name = "labelamari";
            this.labelamari.Size = new System.Drawing.Size(22, 15);
            this.labelamari.TabIndex = 2;
            this.labelamari.Text = "円";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "一人あたり";
            // 
            // labelwarikan
            // 
            this.labelwarikan.AutoSize = true;
            this.labelwarikan.Location = new System.Drawing.Point(15, 124);
            this.labelwarikan.Name = "labelwarikan";
            this.labelwarikan.Size = new System.Drawing.Size(22, 15);
            this.labelwarikan.TabIndex = 2;
            this.labelwarikan.Text = "円";
            // 
            // buttonkeisan
            // 
            this.buttonkeisan.Location = new System.Drawing.Point(18, 174);
            this.buttonkeisan.Name = "buttonkeisan";
            this.buttonkeisan.Size = new System.Drawing.Size(333, 23);
            this.buttonkeisan.TabIndex = 3;
            this.buttonkeisan.Text = "計算する";
            this.buttonkeisan.UseVisualStyleBackColor = true;
            this.buttonkeisan.Click += new System.EventHandler(this.buttonkeisan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 217);
            this.Controls.Add(this.buttonkeisan);
            this.Controls.Add(this.labelamari);
            this.Controls.Add(this.labelwarikan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxninzu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxzeinuki);
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
        private System.Windows.Forms.TextBox textBoxzeinuki;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxninzu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelamari;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelwarikan;
        private System.Windows.Forms.Button buttonkeisan;
    }
}

