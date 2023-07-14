
namespace SwimmingSchedule
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.labeljugyou = new System.Windows.Forms.Label();
            this.labelt = new System.Windows.Forms.Label();
            this.labelp = new System.Windows.Forms.Label();
            this.labeltime = new System.Windows.Forms.Label();
            this.labelpay = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(83, 46);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(100, 25);
            this.numericUpDown1.TabIndex = 0;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(219, 46);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(88, 25);
            this.numericUpDown2.TabIndex = 1;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(409, 46);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(252, 130);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // labeljugyou
            // 
            this.labeljugyou.AutoSize = true;
            this.labeljugyou.Location = new System.Drawing.Point(83, 113);
            this.labeljugyou.Name = "labeljugyou";
            this.labeljugyou.Size = new System.Drawing.Size(91, 18);
            this.labeljugyou.TabIndex = 4;
            this.labeljugyou.Text = "授業日    ：";
            // 
            // labelt
            // 
            this.labelt.AutoSize = true;
            this.labelt.Location = new System.Drawing.Point(216, 179);
            this.labelt.Name = "labelt";
            this.labelt.Size = new System.Drawing.Size(0, 18);
            this.labelt.TabIndex = 5;
            // 
            // labelp
            // 
            this.labelp.AutoSize = true;
            this.labelp.Location = new System.Drawing.Point(216, 246);
            this.labelp.Name = "labelp";
            this.labelp.Size = new System.Drawing.Size(0, 18);
            this.labelp.TabIndex = 6;
            // 
            // labeltime
            // 
            this.labeltime.AutoSize = true;
            this.labeltime.Location = new System.Drawing.Point(80, 179);
            this.labeltime.Name = "labeltime";
            this.labeltime.Size = new System.Drawing.Size(89, 18);
            this.labeltime.TabIndex = 7;
            this.labeltime.Text = "開始時間：";
            // 
            // labelpay
            // 
            this.labelpay.AutoSize = true;
            this.labelpay.Location = new System.Drawing.Point(80, 246);
            this.labelpay.Name = "labelpay";
            this.labelpay.Size = new System.Drawing.Size(88, 18);
            this.labelpay.TabIndex = 8;
            this.labelpay.Text = "授業料　 ：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(313, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 18);
            this.label7.TabIndex = 9;
            this.label7.Text = "月";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(189, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 18);
            this.label8.TabIndex = 10;
            this.label8.Text = "年";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(83, 46);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDown3.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(100, 25);
            this.numericUpDown3.TabIndex = 0;
            this.numericUpDown3.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(216, 113);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 18);
            this.label.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(83, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(591, 36);
            this.button1.TabIndex = 11;
            this.button1.Text = "表示";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 353);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelpay);
            this.Controls.Add(this.labeltime);
            this.Controls.Add(this.labelp);
            this.Controls.Add(this.labelt);
            this.Controls.Add(this.labeljugyou);
            this.Controls.Add(this.label);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label labeljugyou;
        private System.Windows.Forms.Label labelt;
        private System.Windows.Forms.Label labelp;
        private System.Windows.Forms.Label labeltime;
        private System.Windows.Forms.Label labelpay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button button1;
    }
}

