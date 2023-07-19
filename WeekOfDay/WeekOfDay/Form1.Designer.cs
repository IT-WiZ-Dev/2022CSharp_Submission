
namespace WeekOfDay
{
    partial class FormWeek
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
            this.seireki = new System.Windows.Forms.Label();
            this.tuki = new System.Windows.Forms.Label();
            this.niti = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sansyutu = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // seireki
            // 
            this.seireki.AutoSize = true;
            this.seireki.Location = new System.Drawing.Point(80, 80);
            this.seireki.Name = "seireki";
            this.seireki.Size = new System.Drawing.Size(52, 15);
            this.seireki.TabIndex = 0;
            this.seireki.Text = "西暦年";
            // 
            // tuki
            // 
            this.tuki.AutoSize = true;
            this.tuki.Location = new System.Drawing.Point(238, 80);
            this.tuki.Name = "tuki";
            this.tuki.Size = new System.Drawing.Size(22, 15);
            this.tuki.TabIndex = 1;
            this.tuki.Text = "月";
            // 
            // niti
            // 
            this.niti.AutoSize = true;
            this.niti.Location = new System.Drawing.Point(419, 80);
            this.niti.Name = "niti";
            this.niti.Size = new System.Drawing.Size(22, 15);
            this.niti.TabIndex = 2;
            this.niti.Text = "日";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(609, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "あああ";
            // 
            // sansyutu
            // 
            this.sansyutu.Location = new System.Drawing.Point(166, 215);
            this.sansyutu.Name = "sansyutu";
            this.sansyutu.Size = new System.Drawing.Size(289, 23);
            this.sansyutu.TabIndex = 4;
            this.sansyutu.Text = "曜日算出";
            this.sansyutu.UseVisualStyleBackColor = true;
            this.sansyutu.Click += new System.EventHandler(this.sansyutu_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(83, 107);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 5;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(241, 107);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(422, 107);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown2.TabIndex = 7;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FormWeek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.sansyutu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.niti);
            this.Controls.Add(this.tuki);
            this.Controls.Add(this.seireki);
            this.Name = "FormWeek";
            this.Text = "曜日算出";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label seireki;
        private System.Windows.Forms.Label tuki;
        private System.Windows.Forms.Label niti;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button sansyutu;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
    }
}

