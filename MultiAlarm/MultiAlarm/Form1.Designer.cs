
namespace MultiAlarm
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
            this.checkBoxStatus1 = new System.Windows.Forms.CheckBox();
            this.checkBoxStatus2 = new System.Windows.Forms.CheckBox();
            this.checkBoxStatus3 = new System.Windows.Forms.CheckBox();
            this.buttonSet1 = new System.Windows.Forms.Button();
            this.buttonSet2 = new System.Windows.Forms.Button();
            this.buttonSet3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("MS UI Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTime.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelTime.Location = new System.Drawing.Point(43, 15);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(192, 48);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "12:59:59";
            // 
            // checkBoxStatus1
            // 
            this.checkBoxStatus1.AutoSize = true;
            this.checkBoxStatus1.Font = new System.Drawing.Font("MS UI Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkBoxStatus1.ForeColor = System.Drawing.Color.White;
            this.checkBoxStatus1.Location = new System.Drawing.Point(25, 80);
            this.checkBoxStatus1.Name = "checkBoxStatus1";
            this.checkBoxStatus1.Size = new System.Drawing.Size(153, 52);
            this.checkBoxStatus1.TabIndex = 1;
            this.checkBoxStatus1.Text = "00:00";
            this.checkBoxStatus1.UseVisualStyleBackColor = true;
            // 
            // checkBoxStatus2
            // 
            this.checkBoxStatus2.AutoSize = true;
            this.checkBoxStatus2.Font = new System.Drawing.Font("MS UI Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkBoxStatus2.ForeColor = System.Drawing.Color.White;
            this.checkBoxStatus2.Location = new System.Drawing.Point(25, 138);
            this.checkBoxStatus2.Name = "checkBoxStatus2";
            this.checkBoxStatus2.Size = new System.Drawing.Size(153, 52);
            this.checkBoxStatus2.TabIndex = 2;
            this.checkBoxStatus2.Text = "00:00";
            this.checkBoxStatus2.UseVisualStyleBackColor = true;
            // 
            // checkBoxStatus3
            // 
            this.checkBoxStatus3.AutoSize = true;
            this.checkBoxStatus3.Font = new System.Drawing.Font("MS UI Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkBoxStatus3.ForeColor = System.Drawing.Color.White;
            this.checkBoxStatus3.Location = new System.Drawing.Point(25, 196);
            this.checkBoxStatus3.Name = "checkBoxStatus3";
            this.checkBoxStatus3.Size = new System.Drawing.Size(153, 52);
            this.checkBoxStatus3.TabIndex = 3;
            this.checkBoxStatus3.Text = "00:00";
            this.checkBoxStatus3.UseVisualStyleBackColor = true;
            // 
            // buttonSet1
            // 
            this.buttonSet1.Location = new System.Drawing.Point(184, 91);
            this.buttonSet1.Name = "buttonSet1";
            this.buttonSet1.Size = new System.Drawing.Size(75, 26);
            this.buttonSet1.TabIndex = 4;
            this.buttonSet1.Text = "設定";
            this.buttonSet1.UseVisualStyleBackColor = true;
            this.buttonSet1.Click += new System.EventHandler(this.buttonSet1_Click);
            // 
            // buttonSet2
            // 
            this.buttonSet2.Location = new System.Drawing.Point(184, 149);
            this.buttonSet2.Name = "buttonSet2";
            this.buttonSet2.Size = new System.Drawing.Size(75, 26);
            this.buttonSet2.TabIndex = 5;
            this.buttonSet2.Text = "設定";
            this.buttonSet2.UseVisualStyleBackColor = true;
            this.buttonSet2.Click += new System.EventHandler(this.buttonSet2_Click);
            // 
            // buttonSet3
            // 
            this.buttonSet3.Location = new System.Drawing.Point(184, 208);
            this.buttonSet3.Name = "buttonSet3";
            this.buttonSet3.Size = new System.Drawing.Size(75, 26);
            this.buttonSet3.TabIndex = 6;
            this.buttonSet3.Text = "設定";
            this.buttonSet3.UseVisualStyleBackColor = true;
            this.buttonSet3.Click += new System.EventHandler(this.buttonSet3_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumBlue;
            this.ClientSize = new System.Drawing.Size(286, 259);
            this.Controls.Add(this.buttonSet3);
            this.Controls.Add(this.buttonSet2);
            this.Controls.Add(this.buttonSet1);
            this.Controls.Add(this.checkBoxStatus3);
            this.Controls.Add(this.checkBoxStatus2);
            this.Controls.Add(this.checkBoxStatus1);
            this.Controls.Add(this.labelTime);
            this.Name = "FormMain";
            this.Text = "アラーム";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.CheckBox checkBoxStatus1;
        private System.Windows.Forms.CheckBox checkBoxStatus2;
        private System.Windows.Forms.CheckBox checkBoxStatus3;
        private System.Windows.Forms.Button buttonSet1;
        private System.Windows.Forms.Button buttonSet3;
        private System.Windows.Forms.Button buttonSet2;
        private System.Windows.Forms.Timer timer1;
    }
}

