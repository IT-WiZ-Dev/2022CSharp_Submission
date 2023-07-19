
namespace 第7章練習問題_SwimmingSchedule_
{
    partial class FormMain
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
            this.listBoxCourseSelect = new System.Windows.Forms.ListBox();
            this.numericUpDownYear = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMonth = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelday = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelstarttime = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelprice = new System.Windows.Forms.Label();
            this.buttonjikkou = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMonth)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxCourseSelect
            // 
            this.listBoxCourseSelect.FormattingEnabled = true;
            this.listBoxCourseSelect.ItemHeight = 18;
            this.listBoxCourseSelect.Location = new System.Drawing.Point(359, 45);
            this.listBoxCourseSelect.Name = "listBoxCourseSelect";
            this.listBoxCourseSelect.Size = new System.Drawing.Size(238, 130);
            this.listBoxCourseSelect.TabIndex = 0;
            // 
            // numericUpDownYear
            // 
            this.numericUpDownYear.Location = new System.Drawing.Point(45, 45);
            this.numericUpDownYear.Maximum = new decimal(new int[] {
            2099,
            0,
            0,
            0});
            this.numericUpDownYear.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDownYear.Name = "numericUpDownYear";
            this.numericUpDownYear.Size = new System.Drawing.Size(88, 25);
            this.numericUpDownYear.TabIndex = 1;
            this.numericUpDownYear.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // numericUpDownMonth
            // 
            this.numericUpDownMonth.Location = new System.Drawing.Point(184, 45);
            this.numericUpDownMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMonth.Name = "numericUpDownMonth";
            this.numericUpDownMonth.Size = new System.Drawing.Size(76, 25);
            this.numericUpDownMonth.TabIndex = 2;
            this.numericUpDownMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "年";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "月";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "授業日 　：";
            // 
            // labelday
            // 
            this.labelday.AutoSize = true;
            this.labelday.Location = new System.Drawing.Point(140, 89);
            this.labelday.Name = "labelday";
            this.labelday.Size = new System.Drawing.Size(0, 18);
            this.labelday.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "開始時間：";
            // 
            // labelstarttime
            // 
            this.labelstarttime.AutoSize = true;
            this.labelstarttime.Location = new System.Drawing.Point(140, 129);
            this.labelstarttime.Name = "labelstarttime";
            this.labelstarttime.Size = new System.Drawing.Size(0, 18);
            this.labelstarttime.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 18);
            this.label7.TabIndex = 9;
            this.label7.Text = "授業料 　：";
            // 
            // labelprice
            // 
            this.labelprice.AutoSize = true;
            this.labelprice.Location = new System.Drawing.Point(137, 168);
            this.labelprice.Name = "labelprice";
            this.labelprice.Size = new System.Drawing.Size(0, 18);
            this.labelprice.TabIndex = 10;
            // 
            // buttonjikkou
            // 
            this.buttonjikkou.Location = new System.Drawing.Point(48, 209);
            this.buttonjikkou.Name = "buttonjikkou";
            this.buttonjikkou.Size = new System.Drawing.Size(549, 37);
            this.buttonjikkou.TabIndex = 11;
            this.buttonjikkou.Text = "実行";
            this.buttonjikkou.UseVisualStyleBackColor = true;
            this.buttonjikkou.Click += new System.EventHandler(this.buttonjikkou_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 282);
            this.Controls.Add(this.buttonjikkou);
            this.Controls.Add(this.labelprice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelstarttime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelday);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownMonth);
            this.Controls.Add(this.numericUpDownYear);
            this.Controls.Add(this.listBoxCourseSelect);
            this.Name = "FormMain";
            this.Text = "CSスイミングスクール";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMonth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCourseSelect;
        private System.Windows.Forms.NumericUpDown numericUpDownYear;
        private System.Windows.Forms.NumericUpDown numericUpDownMonth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelday;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelstarttime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelprice;
        private System.Windows.Forms.Button buttonjikkou;
    }
}

