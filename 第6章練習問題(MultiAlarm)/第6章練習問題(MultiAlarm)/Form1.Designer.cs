
namespace 第6章練習問題_MultiAlarm_
{
    partial class FormMain
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
            this.checkAlarm1 = new System.Windows.Forms.CheckBox();
            this.labelAlarmTime1 = new System.Windows.Forms.Label();
            this.buttonAlarmSet1 = new System.Windows.Forms.Button();
            this.checkAlarm2 = new System.Windows.Forms.CheckBox();
            this.labelAlarmTime2 = new System.Windows.Forms.Label();
            this.buttonAlarmSet2 = new System.Windows.Forms.Button();
            this.checkAlarm3 = new System.Windows.Forms.CheckBox();
            this.labelAlarmTime3 = new System.Windows.Forms.Label();
            this.buttonAlarmSet3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("MS UI Gothic", 28F, System.Drawing.FontStyle.Bold);
            this.labelTime.Location = new System.Drawing.Point(32, 9);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(222, 56);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "12:59:59";
            // 
            // checkAlarm1
            // 
            this.checkAlarm1.AutoSize = true;
            this.checkAlarm1.Location = new System.Drawing.Point(31, 84);
            this.checkAlarm1.Name = "checkAlarm1";
            this.checkAlarm1.Size = new System.Drawing.Size(22, 21);
            this.checkAlarm1.TabIndex = 0;
            this.checkAlarm1.UseVisualStyleBackColor = true;
            // 
            // labelAlarmTime1
            // 
            this.labelAlarmTime1.AutoSize = true;
            this.labelAlarmTime1.Location = new System.Drawing.Point(95, 84);
            this.labelAlarmTime1.Name = "labelAlarmTime1";
            this.labelAlarmTime1.Size = new System.Drawing.Size(48, 18);
            this.labelAlarmTime1.TabIndex = 1;
            this.labelAlarmTime1.Text = "00:00";
            // 
            // buttonAlarmSet1
            // 
            this.buttonAlarmSet1.Location = new System.Drawing.Point(200, 75);
            this.buttonAlarmSet1.Name = "buttonAlarmSet1";
            this.buttonAlarmSet1.Size = new System.Drawing.Size(75, 36);
            this.buttonAlarmSet1.TabIndex = 2;
            this.buttonAlarmSet1.Text = "設定";
            this.buttonAlarmSet1.UseVisualStyleBackColor = true;
            this.buttonAlarmSet1.Click += new System.EventHandler(this.buttonAlarmSet1_Click);
            // 
            // checkAlarm2
            // 
            this.checkAlarm2.AutoSize = true;
            this.checkAlarm2.Location = new System.Drawing.Point(31, 129);
            this.checkAlarm2.Name = "checkAlarm2";
            this.checkAlarm2.Size = new System.Drawing.Size(22, 21);
            this.checkAlarm2.TabIndex = 3;
            this.checkAlarm2.UseVisualStyleBackColor = true;
            // 
            // labelAlarmTime2
            // 
            this.labelAlarmTime2.AutoSize = true;
            this.labelAlarmTime2.Location = new System.Drawing.Point(95, 129);
            this.labelAlarmTime2.Name = "labelAlarmTime2";
            this.labelAlarmTime2.Size = new System.Drawing.Size(48, 18);
            this.labelAlarmTime2.TabIndex = 4;
            this.labelAlarmTime2.Text = "00:00";
            // 
            // buttonAlarmSet2
            // 
            this.buttonAlarmSet2.Location = new System.Drawing.Point(200, 123);
            this.buttonAlarmSet2.Name = "buttonAlarmSet2";
            this.buttonAlarmSet2.Size = new System.Drawing.Size(75, 31);
            this.buttonAlarmSet2.TabIndex = 5;
            this.buttonAlarmSet2.Text = "設定";
            this.buttonAlarmSet2.UseVisualStyleBackColor = true;
            this.buttonAlarmSet2.Click += new System.EventHandler(this.buttonAlarmSet2_Click);
            // 
            // checkAlarm3
            // 
            this.checkAlarm3.AutoSize = true;
            this.checkAlarm3.Location = new System.Drawing.Point(31, 169);
            this.checkAlarm3.Name = "checkAlarm3";
            this.checkAlarm3.Size = new System.Drawing.Size(22, 21);
            this.checkAlarm3.TabIndex = 6;
            this.checkAlarm3.UseVisualStyleBackColor = true;
            // 
            // labelAlarmTime3
            // 
            this.labelAlarmTime3.AutoSize = true;
            this.labelAlarmTime3.Location = new System.Drawing.Point(95, 169);
            this.labelAlarmTime3.Name = "labelAlarmTime3";
            this.labelAlarmTime3.Size = new System.Drawing.Size(48, 18);
            this.labelAlarmTime3.TabIndex = 7;
            this.labelAlarmTime3.Text = "00:00";
            // 
            // buttonAlarmSet3
            // 
            this.buttonAlarmSet3.Location = new System.Drawing.Point(200, 163);
            this.buttonAlarmSet3.Name = "buttonAlarmSet3";
            this.buttonAlarmSet3.Size = new System.Drawing.Size(75, 31);
            this.buttonAlarmSet3.TabIndex = 8;
            this.buttonAlarmSet3.Text = "設定";
            this.buttonAlarmSet3.UseVisualStyleBackColor = true;
            this.buttonAlarmSet3.Click += new System.EventHandler(this.buttonAlarmSet3_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 225);
            this.Controls.Add(this.buttonAlarmSet3);
            this.Controls.Add(this.labelAlarmTime3);
            this.Controls.Add(this.checkAlarm3);
            this.Controls.Add(this.buttonAlarmSet2);
            this.Controls.Add(this.labelAlarmTime2);
            this.Controls.Add(this.checkAlarm2);
            this.Controls.Add(this.buttonAlarmSet1);
            this.Controls.Add(this.labelAlarmTime1);
            this.Controls.Add(this.checkAlarm1);
            this.Controls.Add(this.labelTime);
            this.Name = "FormMain";
            this.Text = "アラーム";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.CheckBox checkAlarm1;
        private System.Windows.Forms.Label labelAlarmTime1;
        private System.Windows.Forms.Button buttonAlarmSet1;
        private System.Windows.Forms.CheckBox checkAlarm2;
        private System.Windows.Forms.Label labelAlarmTime2;
        private System.Windows.Forms.Button buttonAlarmSet2;
        private System.Windows.Forms.CheckBox checkAlarm3;
        private System.Windows.Forms.Label labelAlarmTime3;
        private System.Windows.Forms.Button buttonAlarmSet3;
        private System.Windows.Forms.Timer timer1;
    }
}

