
namespace MultiAlarm
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
            this.numericUpDownAImHour = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAImMnt = new System.Windows.Forms.NumericUpDown();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAImHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAImMnt)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "時";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "分";
            // 
            // numericUpDownAImHour
            // 
            this.numericUpDownAImHour.Location = new System.Drawing.Point(100, 23);
            this.numericUpDownAImHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDownAImHour.Name = "numericUpDownAImHour";
            this.numericUpDownAImHour.Size = new System.Drawing.Size(121, 22);
            this.numericUpDownAImHour.TabIndex = 2;
            this.numericUpDownAImHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numericUpDownAImMnt
            // 
            this.numericUpDownAImMnt.Location = new System.Drawing.Point(100, 79);
            this.numericUpDownAImMnt.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownAImMnt.Name = "numericUpDownAImMnt";
            this.numericUpDownAImMnt.Size = new System.Drawing.Size(121, 22);
            this.numericUpDownAImMnt.TabIndex = 3;
            this.numericUpDownAImMnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(116, 121);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(90, 29);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(116, 156);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(90, 29);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "キャンセル";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 197);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.numericUpDownAImMnt);
            this.Controls.Add(this.numericUpDownAImHour);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormSet";
            this.Text = "時刻設定";
            this.Load += new System.EventHandler(this.FormSet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAImHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAImMnt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownAImHour;
        private System.Windows.Forms.NumericUpDown numericUpDownAImMnt;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
    }
}