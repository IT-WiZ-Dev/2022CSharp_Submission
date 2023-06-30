
namespace SwimmingSchedule
{
    partial class FormSwimmming
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
            this.numericUpDownYear = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMonth = new System.Windows.Forms.NumericUpDown();
            this.listBoxCourse = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelLessonDay = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelStartTime = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelLessonPrice = new System.Windows.Forms.Label();
            this.buttonDisplay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMonth)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownYear
            // 
            this.numericUpDownYear.Location = new System.Drawing.Point(24, 33);
            this.numericUpDownYear.Maximum = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            this.numericUpDownYear.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownYear.Name = "numericUpDownYear";
            this.numericUpDownYear.Size = new System.Drawing.Size(66, 22);
            this.numericUpDownYear.TabIndex = 0;
            this.numericUpDownYear.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownMonth
            // 
            this.numericUpDownMonth.Location = new System.Drawing.Point(138, 33);
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
            this.numericUpDownMonth.Size = new System.Drawing.Size(66, 22);
            this.numericUpDownMonth.TabIndex = 1;
            this.numericUpDownMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // listBoxCourse
            // 
            this.listBoxCourse.FormattingEnabled = true;
            this.listBoxCourse.ItemHeight = 15;
            this.listBoxCourse.Items.AddRange(new object[] {
            "ベビーコース",
            "幼児コース",
            "小学生コース",
            "中学生コース",
            "レディースコース",
            "一般コース",
            "家族コース"});
            this.listBoxCourse.Location = new System.Drawing.Point(302, 33);
            this.listBoxCourse.Name = "listBoxCourse";
            this.listBoxCourse.Size = new System.Drawing.Size(134, 109);
            this.listBoxCourse.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "年";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "月";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "授業日     ：";
            // 
            // labelLessonDay
            // 
            this.labelLessonDay.AutoSize = true;
            this.labelLessonDay.Location = new System.Drawing.Point(112, 94);
            this.labelLessonDay.Name = "labelLessonDay";
            this.labelLessonDay.Size = new System.Drawing.Size(43, 15);
            this.labelLessonDay.TabIndex = 6;
            this.labelLessonDay.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "開始時間  ：";
            // 
            // labelStartTime
            // 
            this.labelStartTime.AutoSize = true;
            this.labelStartTime.Location = new System.Drawing.Point(112, 134);
            this.labelStartTime.Name = "labelStartTime";
            this.labelStartTime.Size = new System.Drawing.Size(43, 15);
            this.labelStartTime.TabIndex = 8;
            this.labelStartTime.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "授業料     ：";
            // 
            // labelLessonPrice
            // 
            this.labelLessonPrice.AutoSize = true;
            this.labelLessonPrice.Location = new System.Drawing.Point(112, 176);
            this.labelLessonPrice.Name = "labelLessonPrice";
            this.labelLessonPrice.Size = new System.Drawing.Size(43, 15);
            this.labelLessonPrice.TabIndex = 10;
            this.labelLessonPrice.Text = "label8";
            // 
            // buttonDisplay
            // 
            this.buttonDisplay.Location = new System.Drawing.Point(24, 214);
            this.buttonDisplay.Name = "buttonDisplay";
            this.buttonDisplay.Size = new System.Drawing.Size(412, 29);
            this.buttonDisplay.TabIndex = 11;
            this.buttonDisplay.Text = "表示";
            this.buttonDisplay.UseVisualStyleBackColor = true;
            this.buttonDisplay.Click += new System.EventHandler(this.buttonDisplay_Click);
            // 
            // FormSwimmming
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 264);
            this.Controls.Add(this.buttonDisplay);
            this.Controls.Add(this.labelLessonPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelStartTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelLessonDay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxCourse);
            this.Controls.Add(this.numericUpDownMonth);
            this.Controls.Add(this.numericUpDownYear);
            this.Name = "FormSwimmming";
            this.Text = "CSスイミングスクール";
            this.Load += new System.EventHandler(this.FormSwimmming_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMonth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownYear;
        private System.Windows.Forms.NumericUpDown numericUpDownMonth;
        private System.Windows.Forms.ListBox listBoxCourse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelLessonDay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelStartTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelLessonPrice;
        private System.Windows.Forms.Button buttonDisplay;
    }
}

