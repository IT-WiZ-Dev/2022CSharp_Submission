
namespace 第6章練習問題_MultiAlarm_
{
    partial class FormSet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.numericUpDownAlarmHour = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAlarmMin = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAlarmHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAlarmMin)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "時";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "分";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(43, 141);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(167, 35);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(40, 199);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(170, 28);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "キャンセル";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // numericUpDownAlarmHour
            // 
            this.numericUpDownAlarmHour.Location = new System.Drawing.Point(90, 20);
            this.numericUpDownAlarmHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDownAlarmHour.Name = "numericUpDownAlarmHour";
            this.numericUpDownAlarmHour.Size = new System.Drawing.Size(120, 25);
            this.numericUpDownAlarmHour.TabIndex = 6;
            // 
            // numericUpDownAlarmMin
            // 
            this.numericUpDownAlarmMin.Location = new System.Drawing.Point(90, 78);
            this.numericUpDownAlarmMin.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownAlarmMin.Name = "numericUpDownAlarmMin";
            this.numericUpDownAlarmMin.Size = new System.Drawing.Size(120, 25);
            this.numericUpDownAlarmMin.TabIndex = 7;
            // 
            // FormSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 295);
            this.Controls.Add(this.numericUpDownAlarmMin);
            this.Controls.Add(this.numericUpDownAlarmHour);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormSet";
            this.Text = "時刻設定";
            this.Load += new System.EventHandler(this.FormSet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAlarmHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAlarmMin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.NumericUpDown numericUpDownAlarmHour;
        private System.Windows.Forms.NumericUpDown numericUpDownAlarmMin;
    }
}