
namespace WindowsFormsApp6
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
            this.textBoxokane = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxhito = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelKingaku = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelAmari = new System.Windows.Forms.Label();
            this.buttonKeisan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "税抜き金額";
            // 
            // textBoxokane
            // 
            this.textBoxokane.Location = new System.Drawing.Point(69, 90);
            this.textBoxokane.Name = "textBoxokane";
            this.textBoxokane.Size = new System.Drawing.Size(100, 22);
            this.textBoxokane.TabIndex = 1;
            this.textBoxokane.Text = "0";
            this.textBoxokane.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(348, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "人数";
            // 
            // textBoxhito
            // 
            this.textBoxhito.Location = new System.Drawing.Point(285, 89);
            this.textBoxhito.Name = "textBoxhito";
            this.textBoxhito.Size = new System.Drawing.Size(100, 22);
            this.textBoxhito.TabIndex = 3;
            this.textBoxhito.Text = "0";
            this.textBoxhito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "円";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(391, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "人";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "一人当たり";
            // 
            // labelKingaku
            // 
            this.labelKingaku.AutoSize = true;
            this.labelKingaku.Location = new System.Drawing.Point(137, 172);
            this.labelKingaku.Name = "labelKingaku";
            this.labelKingaku.Size = new System.Drawing.Size(32, 15);
            this.labelKingaku.TabIndex = 7;
            this.labelKingaku.Text = "０円";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(346, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "あまり";
            // 
            // labelAmari
            // 
            this.labelAmari.AutoSize = true;
            this.labelAmari.Location = new System.Drawing.Point(353, 172);
            this.labelAmari.Name = "labelAmari";
            this.labelAmari.Size = new System.Drawing.Size(32, 15);
            this.labelAmari.TabIndex = 9;
            this.labelAmari.Text = "０円";
            // 
            // buttonKeisan
            // 
            this.buttonKeisan.Location = new System.Drawing.Point(211, 221);
            this.buttonKeisan.Name = "buttonKeisan";
            this.buttonKeisan.Size = new System.Drawing.Size(75, 23);
            this.buttonKeisan.TabIndex = 10;
            this.buttonKeisan.Text = "計算する";
            this.buttonKeisan.UseVisualStyleBackColor = true;
            this.buttonKeisan.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonKeisan);
            this.Controls.Add(this.labelAmari);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelKingaku);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxhito);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxokane);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxokane;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxhito;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelKingaku;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelAmari;
        private System.Windows.Forms.Button buttonKeisan;
    }
}

