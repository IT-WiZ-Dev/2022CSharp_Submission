namespace SwimmingSchedule
{
    partial class FormSwimming
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
            this.listBoxCourse = new System.Windows.Forms.ListBox();
            this.buttonDisplay = new System.Windows.Forms.Button();
            this.labelFee = new System.Windows.Forms.Label();
            this.labelStartTime = new System.Windows.Forms.Label();
            this.labelDays = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownYear = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMonth = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMonth)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxCourse
            // 
            this.listBoxCourse.FormattingEnabled = true;
            this.listBoxCourse.ItemHeight = 15;
            this.listBoxCourse.Location = new System.Drawing.Point(269, 35);
            this.listBoxCourse.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxCourse.Name = "listBoxCourse";
            this.listBoxCourse.Size = new System.Drawing.Size(159, 109);
            this.listBoxCourse.TabIndex = 20;
            this.listBoxCourse.SelectedIndexChanged += new System.EventHandler(this.listBoxCourse_SelectedIndexChanged);
            // 
            // buttonDisplay
            // 
            this.buttonDisplay.Location = new System.Drawing.Point(24, 172);
            this.buttonDisplay.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDisplay.Name = "buttonDisplay";
            this.buttonDisplay.Size = new System.Drawing.Size(404, 29);
            this.buttonDisplay.TabIndex = 21;
            this.buttonDisplay.Text = "表示";
            this.buttonDisplay.UseVisualStyleBackColor = true;
            this.buttonDisplay.Click += new System.EventHandler(this.ButtonDisplay_Click);
            // 
            // labelFee
            // 
            this.labelFee.AutoSize = true;
            this.labelFee.Location = new System.Drawing.Point(21, 140);
            this.labelFee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFee.Name = "labelFee";
            this.labelFee.Size = new System.Drawing.Size(80, 15);
            this.labelFee.TabIndex = 13;
            this.labelFee.Text = "月謝       ：";
            // 
            // labelStartTime
            // 
            this.labelStartTime.AutoSize = true;
            this.labelStartTime.Location = new System.Drawing.Point(21, 104);
            this.labelStartTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStartTime.Name = "labelStartTime";
            this.labelStartTime.Size = new System.Drawing.Size(80, 15);
            this.labelStartTime.TabIndex = 14;
            this.labelStartTime.Text = "開始時間 ：";
            // 
            // labelDays
            // 
            this.labelDays.AutoSize = true;
            this.labelDays.Location = new System.Drawing.Point(21, 66);
            this.labelDays.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDays.Name = "labelDays";
            this.labelDays.Size = new System.Drawing.Size(80, 15);
            this.labelDays.TabIndex = 15;
            this.labelDays.Text = "授業日    ：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "月";
            // 
            // numericUpDownYear
            // 
            this.numericUpDownYear.Location = new System.Drawing.Point(21, 20);
            this.numericUpDownYear.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownYear.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.numericUpDownYear.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDownYear.Name = "numericUpDownYear";
            this.numericUpDownYear.Size = new System.Drawing.Size(80, 22);
            this.numericUpDownYear.TabIndex = 17;
            this.numericUpDownYear.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // numericUpDownMonth
            // 
            this.numericUpDownMonth.Location = new System.Drawing.Point(143, 20);
            this.numericUpDownMonth.Margin = new System.Windows.Forms.Padding(4);
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
            this.numericUpDownMonth.Size = new System.Drawing.Size(80, 22);
            this.numericUpDownMonth.TabIndex = 19;
            this.numericUpDownMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMonth.ValueChanged += new System.EventHandler(this.numericUpDownMonth_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "年";
            // 
            // FormSwimming
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 266);
            this.Controls.Add(this.listBoxCourse);
            this.Controls.Add(this.buttonDisplay);
            this.Controls.Add(this.labelFee);
            this.Controls.Add(this.labelStartTime);
            this.Controls.Add(this.labelDays);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownYear);
            this.Controls.Add(this.numericUpDownMonth);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormSwimming";
            this.Text = "CSスイミングスクール";
            this.Load += new System.EventHandler(this.FormSwimming_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMonth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCourse;
        private System.Windows.Forms.Button buttonDisplay;
        private System.Windows.Forms.Label labelFee;
        private System.Windows.Forms.Label labelStartTime;
        private System.Windows.Forms.Label labelDays;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownYear;
        private System.Windows.Forms.NumericUpDown numericUpDownMonth;
        private System.Windows.Forms.Label label1;
    }
}

