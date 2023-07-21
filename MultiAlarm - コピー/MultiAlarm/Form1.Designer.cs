
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
            this.checkTime1 = new System.Windows.Forms.CheckBox();
            this.checkTime2 = new System.Windows.Forms.CheckBox();
            this.checkTime3 = new System.Windows.Forms.CheckBox();
            this.buttonset1 = new System.Windows.Forms.Button();
            this.buttonset2 = new System.Windows.Forms.Button();
            this.buttonset3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("MS UI Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTime.Location = new System.Drawing.Point(178, 58);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(192, 48);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "12:59:59";
            // 
            // checkTime1
            // 
            this.checkTime1.AutoSize = true;
            this.checkTime1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkTime1.Location = new System.Drawing.Point(120, 120);
            this.checkTime1.Name = "checkTime1";
            this.checkTime1.Size = new System.Drawing.Size(106, 34);
            this.checkTime1.TabIndex = 1;
            this.checkTime1.Text = "00:00";
            this.checkTime1.UseVisualStyleBackColor = true;
            // 
            // checkTime2
            // 
            this.checkTime2.AutoSize = true;
            this.checkTime2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkTime2.Location = new System.Drawing.Point(120, 181);
            this.checkTime2.Name = "checkTime2";
            this.checkTime2.Size = new System.Drawing.Size(106, 34);
            this.checkTime2.TabIndex = 2;
            this.checkTime2.Text = "00:00";
            this.checkTime2.UseVisualStyleBackColor = true;
            // 
            // checkTime3
            // 
            this.checkTime3.AutoSize = true;
            this.checkTime3.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkTime3.Location = new System.Drawing.Point(120, 243);
            this.checkTime3.Name = "checkTime3";
            this.checkTime3.Size = new System.Drawing.Size(106, 34);
            this.checkTime3.TabIndex = 3;
            this.checkTime3.Text = "00:00";
            this.checkTime3.UseVisualStyleBackColor = true;
            // 
            // buttonset1
            // 
            this.buttonset1.Location = new System.Drawing.Point(263, 130);
            this.buttonset1.Name = "buttonset1";
            this.buttonset1.Size = new System.Drawing.Size(75, 23);
            this.buttonset1.TabIndex = 4;
            this.buttonset1.Text = "設定";
            this.buttonset1.UseVisualStyleBackColor = true;
            this.buttonset1.Click += new System.EventHandler(this.buttonset1_Click);
            // 
            // buttonset2
            // 
            this.buttonset2.Location = new System.Drawing.Point(263, 191);
            this.buttonset2.Name = "buttonset2";
            this.buttonset2.Size = new System.Drawing.Size(75, 23);
            this.buttonset2.TabIndex = 5;
            this.buttonset2.Text = "設定";
            this.buttonset2.UseVisualStyleBackColor = true;
            this.buttonset2.Click += new System.EventHandler(this.buttonset2_Click);
            // 
            // buttonset3
            // 
            this.buttonset3.Location = new System.Drawing.Point(263, 253);
            this.buttonset3.Name = "buttonset3";
            this.buttonset3.Size = new System.Drawing.Size(75, 23);
            this.buttonset3.TabIndex = 6;
            this.buttonset3.Text = "設定";
            this.buttonset3.UseVisualStyleBackColor = true;
            this.buttonset3.Click += new System.EventHandler(this.buttonset3_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonset3);
            this.Controls.Add(this.buttonset2);
            this.Controls.Add(this.buttonset1);
            this.Controls.Add(this.checkTime3);
            this.Controls.Add(this.checkTime2);
            this.Controls.Add(this.checkTime1);
            this.Controls.Add(this.labelTime);
            this.Name = "Form1";
            this.Text = "アラーム";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.CheckBox checkTime1;
        private System.Windows.Forms.CheckBox checkTime2;
        private System.Windows.Forms.CheckBox checkTime3;
        private System.Windows.Forms.Button buttonset1;
        private System.Windows.Forms.Button buttonset2;
        private System.Windows.Forms.Button buttonset3;
        private System.Windows.Forms.Timer timer1;
    }
}

