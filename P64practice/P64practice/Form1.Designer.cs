﻿
namespace P64practice
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.labelCheckBox = new System.Windows.Forms.Label();
            this.labelRadioButton1 = new System.Windows.Forms.Label();
            this.labelRadioButton2 = new System.Windows.Forms.Label();
            this.labelNumeicUpDown = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(48, 50);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(132, 22);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "チェックボックス";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(48, 120);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(126, 22);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "ラジオボタン１";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(48, 186);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(126, 22);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "ラジオボタン２";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "ニューメリックアップダウン";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(48, 281);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 25);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // labelCheckBox
            // 
            this.labelCheckBox.AutoSize = true;
            this.labelCheckBox.Location = new System.Drawing.Point(428, 54);
            this.labelCheckBox.Name = "labelCheckBox";
            this.labelCheckBox.Size = new System.Drawing.Size(52, 18);
            this.labelCheckBox.TabIndex = 6;
            this.labelCheckBox.Text = "label1";
            // 
            // labelRadioButton1
            // 
            this.labelRadioButton1.AutoSize = true;
            this.labelRadioButton1.Location = new System.Drawing.Point(428, 120);
            this.labelRadioButton1.Name = "labelRadioButton1";
            this.labelRadioButton1.Size = new System.Drawing.Size(52, 18);
            this.labelRadioButton1.TabIndex = 7;
            this.labelRadioButton1.Text = "label2";
            // 
            // labelRadioButton2
            // 
            this.labelRadioButton2.AutoSize = true;
            this.labelRadioButton2.Location = new System.Drawing.Point(428, 190);
            this.labelRadioButton2.Name = "labelRadioButton2";
            this.labelRadioButton2.Size = new System.Drawing.Size(52, 18);
            this.labelRadioButton2.TabIndex = 8;
            this.labelRadioButton2.Text = "label3";
            // 
            // labelNumeicUpDown
            // 
            this.labelNumeicUpDown.AutoSize = true;
            this.labelNumeicUpDown.Location = new System.Drawing.Point(428, 260);
            this.labelNumeicUpDown.Name = "labelNumeicUpDown";
            this.labelNumeicUpDown.Size = new System.Drawing.Size(52, 18);
            this.labelNumeicUpDown.TabIndex = 9;
            this.labelNumeicUpDown.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelNumeicUpDown);
            this.Controls.Add(this.labelRadioButton2);
            this.Controls.Add(this.labelRadioButton1);
            this.Controls.Add(this.labelCheckBox);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
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
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label labelCheckBox;
        private System.Windows.Forms.Label labelRadioButton1;
        private System.Windows.Forms.Label labelRadioButton2;
        private System.Windows.Forms.Label labelNumeicUpDown;
    }
}
