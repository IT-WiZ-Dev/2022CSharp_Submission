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
            this.buttonSet3 = new System.Windows.Forms.Button();
            this.buttonSet2 = new System.Windows.Forms.Button();
            this.buttonSet1 = new System.Windows.Forms.Button();
            this.label_time3 = new System.Windows.Forms.Label();
            this.label_time2 = new System.Windows.Forms.Label();
            this.label_time1 = new System.Windows.Forms.Label();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Nowtime = new System.Windows.Forms.Label();
            this.timerAlarm = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // buttonSet3
            // 
            this.buttonSet3.BackColor = System.Drawing.Color.White;
            this.buttonSet3.Location = new System.Drawing.Point(294, 179);
            this.buttonSet3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSet3.Name = "buttonSet3";
            this.buttonSet3.Size = new System.Drawing.Size(84, 29);
            this.buttonSet3.TabIndex = 25;
            this.buttonSet3.Text = "設定";
            this.buttonSet3.UseVisualStyleBackColor = false;
            this.buttonSet3.Click += new System.EventHandler(this.ButtonSet3_Click);
            // 
            // buttonSet2
            // 
            this.buttonSet2.BackColor = System.Drawing.Color.White;
            this.buttonSet2.Location = new System.Drawing.Point(294, 121);
            this.buttonSet2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSet2.Name = "buttonSet2";
            this.buttonSet2.Size = new System.Drawing.Size(83, 29);
            this.buttonSet2.TabIndex = 23;
            this.buttonSet2.Text = "設定";
            this.buttonSet2.UseVisualStyleBackColor = false;
            this.buttonSet2.Click += new System.EventHandler(this.ButtonSet2_Click);
            // 
            // buttonSet1
            // 
            this.buttonSet1.BackColor = System.Drawing.Color.White;
            this.buttonSet1.Location = new System.Drawing.Point(294, 66);
            this.buttonSet1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSet1.Name = "buttonSet1";
            this.buttonSet1.Size = new System.Drawing.Size(83, 29);
            this.buttonSet1.TabIndex = 21;
            this.buttonSet1.Text = "設定";
            this.buttonSet1.UseVisualStyleBackColor = false;
            this.buttonSet1.Click += new System.EventHandler(this.ButtonSet1_Click);
            // 
            // label_time3
            // 
            this.label_time3.AutoSize = true;
            this.label_time3.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_time3.ForeColor = System.Drawing.Color.Black;
            this.label_time3.Location = new System.Drawing.Point(112, 179);
            this.label_time3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_time3.Name = "label_time3";
            this.label_time3.Size = new System.Drawing.Size(74, 28);
            this.label_time3.TabIndex = 16;
            this.label_time3.Text = "00:00";
            // 
            // label_time2
            // 
            this.label_time2.AutoSize = true;
            this.label_time2.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_time2.ForeColor = System.Drawing.Color.Black;
            this.label_time2.Location = new System.Drawing.Point(112, 125);
            this.label_time2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_time2.Name = "label_time2";
            this.label_time2.Size = new System.Drawing.Size(74, 28);
            this.label_time2.TabIndex = 17;
            this.label_time2.Text = "00:00";
            // 
            // label_time1
            // 
            this.label_time1.AutoSize = true;
            this.label_time1.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_time1.ForeColor = System.Drawing.Color.Black;
            this.label_time1.Location = new System.Drawing.Point(112, 66);
            this.label_time1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_time1.Name = "label_time1";
            this.label_time1.Size = new System.Drawing.Size(74, 28);
            this.label_time1.TabIndex = 18;
            this.label_time1.Text = "00:00";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(86, 186);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(18, 17);
            this.checkBox3.TabIndex = 24;
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(86, 133);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(18, 17);
            this.checkBox2.TabIndex = 22;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(86, 73);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Nowtime
            // 
            this.Nowtime.AutoSize = true;
            this.Nowtime.Font = new System.Drawing.Font("MS UI Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Nowtime.ForeColor = System.Drawing.Color.Black;
            this.Nowtime.Location = new System.Drawing.Point(168, 19);
            this.Nowtime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Nowtime.Name = "Nowtime";
            this.Nowtime.Size = new System.Drawing.Size(147, 38);
            this.Nowtime.TabIndex = 20;
            this.Nowtime.Text = "00:00:00";
            // 
            // timerAlarm
            // 
            this.timerAlarm.Tick += new System.EventHandler(this.TimerAlarm_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(487, 288);
            this.Controls.Add(this.buttonSet3);
            this.Controls.Add(this.buttonSet2);
            this.Controls.Add(this.buttonSet1);
            this.Controls.Add(this.label_time3);
            this.Controls.Add(this.label_time2);
            this.Controls.Add(this.label_time1);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Nowtime);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "アラーム";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSet3;
        private System.Windows.Forms.Button buttonSet2;
        private System.Windows.Forms.Button buttonSet1;
        private System.Windows.Forms.Label label_time3;
        private System.Windows.Forms.Label label_time2;
        private System.Windows.Forms.Label label_time1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label Nowtime;
        private System.Windows.Forms.Timer timerAlarm;
    }
}

