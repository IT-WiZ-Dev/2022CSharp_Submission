
using System;

namespace renmon7
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
            this.listBoxCourse = new System.Windows.Forms.ListBox();
            this.buttonOK = new System.Windows.Forms.Button();
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
            this.listBoxCourse.ItemHeight = 18;
            this.listBoxCourse.Location = new System.Drawing.Point(454, 117);
            this.listBoxCourse.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.listBoxCourse.Name = "listBoxCourse";
            this.listBoxCourse.Size = new System.Drawing.Size(197, 130);
            this.listBoxCourse.TabIndex = 11;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(149, 300);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(505, 34);
            this.buttonOK.TabIndex = 12;
            this.buttonOK.Text = "表示";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // labelFee
            // 
            this.labelFee.AutoSize = true;
            this.labelFee.Location = new System.Drawing.Point(146, 261);
            this.labelFee.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelFee.Name = "labelFee";
            this.labelFee.Size = new System.Drawing.Size(88, 18);
            this.labelFee.TabIndex = 4;
            this.labelFee.Text = "月謝       ：";
            // 
            // labelStartTime
            // 
            this.labelStartTime.AutoSize = true;
            this.labelStartTime.Location = new System.Drawing.Point(146, 217);
            this.labelStartTime.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelStartTime.Name = "labelStartTime";
            this.labelStartTime.Size = new System.Drawing.Size(94, 18);
            this.labelStartTime.TabIndex = 5;
            this.labelStartTime.Text = "開始時間 ：";
            // 
            // labelDays
            // 
            this.labelDays.AutoSize = true;
            this.labelDays.Location = new System.Drawing.Point(146, 173);
            this.labelDays.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelDays.Name = "labelDays";
            this.labelDays.Size = new System.Drawing.Size(91, 18);
            this.labelDays.TabIndex = 6;
            this.labelDays.Text = "授業日    ：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(411, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "月";
            // 
            // numericUpDownYear
            // 
            this.numericUpDownYear.Location = new System.Drawing.Point(146, 117);
            this.numericUpDownYear.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
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
            this.numericUpDownYear.Size = new System.Drawing.Size(100, 25);
            this.numericUpDownYear.TabIndex = 8;
            this.numericUpDownYear.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDownYear.ValueChanged += new System.EventHandler(this.numericUpDownYear_ValueChanged);
            // 
            // numericUpDownMonth
            // 
            this.numericUpDownMonth.Location = new System.Drawing.Point(297, 117);
            this.numericUpDownMonth.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
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
            this.numericUpDownMonth.Size = new System.Drawing.Size(100, 25);
            this.numericUpDownMonth.TabIndex = 10;
            this.numericUpDownMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 121);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "年";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxCourse);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelFee);
            this.Controls.Add(this.labelStartTime);
            this.Controls.Add(this.labelDays);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownYear);
            this.Controls.Add(this.numericUpDownMonth);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "CSスイミングスクール";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMonth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void numericUpDownYear_ValueChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCourse;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelFee;
        private System.Windows.Forms.Label labelStartTime;
        private System.Windows.Forms.Label labelDays;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownYear;
        private System.Windows.Forms.NumericUpDown numericUpDownMonth;
        private System.Windows.Forms.Label label1;
    }
}

