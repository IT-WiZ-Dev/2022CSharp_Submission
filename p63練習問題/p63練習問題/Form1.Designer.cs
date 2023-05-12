
namespace p63練習問題
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.RadioButton1 = new System.Windows.Forms.RadioButton();
            this.RadioButton2 = new System.Windows.Forms.RadioButton();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.labe1 = new System.Windows.Forms.Label();
            this.labelCheckBox = new System.Windows.Forms.Label();
            this.labelRadioButton1 = new System.Windows.Forms.Label();
            this.labelRadioButton2 = new System.Windows.Forms.Label();
            this.labelNumericUpDown = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(41, 45);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(89, 16);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "チェックボックス";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // RadioButton1
            // 
            this.RadioButton1.AutoSize = true;
            this.RadioButton1.Location = new System.Drawing.Point(41, 105);
            this.RadioButton1.Name = "RadioButton1";
            this.RadioButton1.Size = new System.Drawing.Size(85, 16);
            this.RadioButton1.TabIndex = 2;
            this.RadioButton1.TabStop = true;
            this.RadioButton1.Text = "ラジオボタン１";
            this.RadioButton1.UseVisualStyleBackColor = true;
            this.RadioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // RadioButton2
            // 
            this.RadioButton2.AutoSize = true;
            this.RadioButton2.Location = new System.Drawing.Point(41, 169);
            this.RadioButton2.Name = "RadioButton2";
            this.RadioButton2.Size = new System.Drawing.Size(85, 16);
            this.RadioButton2.TabIndex = 3;
            this.RadioButton2.TabStop = true;
            this.RadioButton2.Text = "ラジオボタン２";
            this.RadioButton2.UseVisualStyleBackColor = true;
            this.RadioButton2.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(41, 237);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 19);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "ニューメリックアップダウン";
            // 
            // labe1
            // 
            this.labe1.AutoSize = true;
            this.labe1.Location = new System.Drawing.Point(321, 45);
            this.labe1.Name = "labe1";
            this.labe1.Size = new System.Drawing.Size(0, 12);
            this.labe1.TabIndex = 0;
            // 
            // labelCheckBox
            // 
            this.labelCheckBox.AutoSize = true;
            this.labelCheckBox.Location = new System.Drawing.Point(258, 48);
            this.labelCheckBox.Name = "labelCheckBox";
            this.labelCheckBox.Size = new System.Drawing.Size(35, 12);
            this.labelCheckBox.TabIndex = 6;
            this.labelCheckBox.Text = "label1";
            // 
            // labelRadioButton1
            // 
            this.labelRadioButton1.AutoSize = true;
            this.labelRadioButton1.Location = new System.Drawing.Point(258, 107);
            this.labelRadioButton1.Name = "labelRadioButton1";
            this.labelRadioButton1.Size = new System.Drawing.Size(35, 12);
            this.labelRadioButton1.TabIndex = 7;
            this.labelRadioButton1.Text = "label2";
            this.labelRadioButton1.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelRadioButton2
            // 
            this.labelRadioButton2.AutoSize = true;
            this.labelRadioButton2.Location = new System.Drawing.Point(258, 173);
            this.labelRadioButton2.Name = "labelRadioButton2";
            this.labelRadioButton2.Size = new System.Drawing.Size(35, 12);
            this.labelRadioButton2.TabIndex = 8;
            this.labelRadioButton2.Text = "label3";
            // 
            // labelNumericUpDown
            // 
            this.labelNumericUpDown.AutoSize = true;
            this.labelNumericUpDown.Location = new System.Drawing.Point(258, 244);
            this.labelNumericUpDown.Name = "labelNumericUpDown";
            this.labelNumericUpDown.Size = new System.Drawing.Size(35, 12);
            this.labelNumericUpDown.TabIndex = 9;
            this.labelNumericUpDown.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelNumericUpDown);
            this.Controls.Add(this.labelRadioButton2);
            this.Controls.Add(this.labelRadioButton1);
            this.Controls.Add(this.labelCheckBox);
            this.Controls.Add(this.labe1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.RadioButton2);
            this.Controls.Add(this.RadioButton1);
            this.Controls.Add(this.checkBox1);
            this.Name = "Form1";
            this.Text = "コントロールの状態";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RadioButton RadioButton1;
        private System.Windows.Forms.RadioButton RadioButton2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labe1;
        private System.Windows.Forms.Label labelCheckBox;
        private System.Windows.Forms.Label labelRadioButton1;
        private System.Windows.Forms.Label labelRadioButton2;
        private System.Windows.Forms.Label labelNumericUpDown;
    }
}

