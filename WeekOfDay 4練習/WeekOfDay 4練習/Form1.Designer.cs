
using System;

namespace WeekOfDay_4練習
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTosi = new System.Windows.Forms.TextBox();
            this.numericUpDowntuki = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownhi = new System.Windows.Forms.NumericUpDown();
            this.buttonGo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDowntuki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownhi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "西暦年";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "月";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(323, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "日";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(437, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // textBoxTosi
            // 
            this.textBoxTosi.Location = new System.Drawing.Point(41, 68);
            this.textBoxTosi.Name = "textBoxTosi";
            this.textBoxTosi.Size = new System.Drawing.Size(100, 25);
            this.textBoxTosi.TabIndex = 4;
            this.textBoxTosi.Text = "2020";
            // 
            // numericUpDowntuki
            // 
            this.numericUpDowntuki.Location = new System.Drawing.Point(199, 69);
            this.numericUpDowntuki.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDowntuki.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDowntuki.Name = "numericUpDowntuki";
            this.numericUpDowntuki.Size = new System.Drawing.Size(64, 25);
            this.numericUpDowntuki.TabIndex = 17;
            this.numericUpDowntuki.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDowntuki.ValueChanged += new System.EventHandler(this.numericUpDowntuki_ValueChanged);
            // 
            // numericUpDownhi
            // 
            this.numericUpDownhi.Location = new System.Drawing.Point(326, 69);
            this.numericUpDownhi.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numericUpDownhi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownhi.Name = "numericUpDownhi";
            this.numericUpDownhi.Size = new System.Drawing.Size(60, 25);
            this.numericUpDownhi.TabIndex = 6;
            this.numericUpDownhi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonGo
            // 
            this.buttonGo.Location = new System.Drawing.Point(41, 133);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(505, 32);
            this.buttonGo.TabIndex = 7;
            this.buttonGo.Text = "曜日算出";
            this.buttonGo.UseVisualStyleBackColor = true;
            // 
            // FormWeek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 207);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.numericUpDownhi);
            this.Controls.Add(this.numericUpDowntuki);
            this.Controls.Add(this.textBoxTosi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormWeek";
            this.Text = "曜日算出";
            this.Load += new System.EventHandler(this.FormWeek_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDowntuki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownhi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void numericUpDowntuki_ValueChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTosi;
        private System.Windows.Forms.NumericUpDown numericUpDowntuki;
        private System.Windows.Forms.NumericUpDown numericUpDownhi;
        private System.Windows.Forms.Button buttonGo;
    }
}

