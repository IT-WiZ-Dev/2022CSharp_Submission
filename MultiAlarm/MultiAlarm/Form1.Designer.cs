
namespace MultiAlarm
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
            this.components = new System.ComponentModel.Container();
            this.labelTime = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.buttonset1 = new System.Windows.Forms.Button();
            this.buttonset2 = new System.Windows.Forms.Button();
            this.buttonset3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("MS UI Gothic", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTime.Location = new System.Drawing.Point(118, 36);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(222, 56);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "23:59:59";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkBox1.Location = new System.Drawing.Point(60, 138);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(152, 52);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "00:00";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkBox2.Location = new System.Drawing.Point(60, 212);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(152, 52);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "00:00";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkBox3.Location = new System.Drawing.Point(60, 290);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(152, 52);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "00:00";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // buttonset1
            // 
            this.buttonset1.Location = new System.Drawing.Point(284, 161);
            this.buttonset1.Name = "buttonset1";
            this.buttonset1.Size = new System.Drawing.Size(83, 26);
            this.buttonset1.TabIndex = 4;
            this.buttonset1.Text = "設定";
            this.buttonset1.UseVisualStyleBackColor = true;
            // 
            // buttonset2
            // 
            this.buttonset2.Location = new System.Drawing.Point(284, 235);
            this.buttonset2.Name = "buttonset2";
            this.buttonset2.Size = new System.Drawing.Size(83, 26);
            this.buttonset2.TabIndex = 5;
            this.buttonset2.Text = "設定";
            this.buttonset2.UseVisualStyleBackColor = true;
            // 
            // buttonset3
            // 
            this.buttonset3.Location = new System.Drawing.Point(284, 313);
            this.buttonset3.Name = "buttonset3";
            this.buttonset3.Size = new System.Drawing.Size(83, 26);
            this.buttonset3.TabIndex = 6;
            this.buttonset3.Text = "設定";
            this.buttonset3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 450);
            this.Controls.Add(this.buttonset3);
            this.Controls.Add(this.buttonset2);
            this.Controls.Add(this.buttonset1);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.labelTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "アラーム";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Button buttonset1;
        private System.Windows.Forms.Button buttonset2;
        private System.Windows.Forms.Button buttonset3;
        private System.Windows.Forms.Timer timer1;
    }
}

