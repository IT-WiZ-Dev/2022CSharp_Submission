
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
            this.checkBoxAlm1 = new System.Windows.Forms.CheckBox();
            this.checkBoxAlm2 = new System.Windows.Forms.CheckBox();
            this.checkBoxAlm3 = new System.Windows.Forms.CheckBox();
            this.buttonSet1 = new System.Windows.Forms.Button();
            this.buttonSet2 = new System.Windows.Forms.Button();
            this.buttonSet3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelAlarm1 = new System.Windows.Forms.Label();
            this.labelAlarm2 = new System.Windows.Forms.Label();
            this.labelAlarm3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("MS UI Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTime.Location = new System.Drawing.Point(71, 28);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(550, 144);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "00:00:00";
            // 
            // checkBoxAlm1
            // 
            this.checkBoxAlm1.AutoSize = true;
            this.checkBoxAlm1.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkBoxAlm1.Location = new System.Drawing.Point(68, 243);
            this.checkBoxAlm1.Name = "checkBoxAlm1";
            this.checkBoxAlm1.Size = new System.Drawing.Size(22, 21);
            this.checkBoxAlm1.TabIndex = 1;
            this.checkBoxAlm1.UseVisualStyleBackColor = true;
            // 
            // checkBoxAlm2
            // 
            this.checkBoxAlm2.AutoSize = true;
            this.checkBoxAlm2.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkBoxAlm2.Location = new System.Drawing.Point(70, 360);
            this.checkBoxAlm2.Name = "checkBoxAlm2";
            this.checkBoxAlm2.Size = new System.Drawing.Size(22, 21);
            this.checkBoxAlm2.TabIndex = 1;
            this.checkBoxAlm2.UseVisualStyleBackColor = true;
            // 
            // checkBoxAlm3
            // 
            this.checkBoxAlm3.AutoSize = true;
            this.checkBoxAlm3.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkBoxAlm3.Location = new System.Drawing.Point(70, 479);
            this.checkBoxAlm3.Name = "checkBoxAlm3";
            this.checkBoxAlm3.Size = new System.Drawing.Size(22, 21);
            this.checkBoxAlm3.TabIndex = 1;
            this.checkBoxAlm3.UseVisualStyleBackColor = true;
            // 
            // buttonSet1
            // 
            this.buttonSet1.BackColor = System.Drawing.Color.Cyan;
            this.buttonSet1.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonSet1.Location = new System.Drawing.Point(390, 216);
            this.buttonSet1.Name = "buttonSet1";
            this.buttonSet1.Size = new System.Drawing.Size(265, 75);
            this.buttonSet1.TabIndex = 2;
            this.buttonSet1.Text = "設定";
            this.buttonSet1.UseVisualStyleBackColor = false;
            this.buttonSet1.Click += new System.EventHandler(this.buttonSet1_Click);
            // 
            // buttonSet2
            // 
            this.buttonSet2.BackColor = System.Drawing.Color.Cyan;
            this.buttonSet2.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonSet2.Location = new System.Drawing.Point(390, 333);
            this.buttonSet2.Name = "buttonSet2";
            this.buttonSet2.Size = new System.Drawing.Size(265, 75);
            this.buttonSet2.TabIndex = 2;
            this.buttonSet2.Text = "設定";
            this.buttonSet2.UseVisualStyleBackColor = false;
            this.buttonSet2.Click += new System.EventHandler(this.buttonSet2_Click);
            // 
            // buttonSet3
            // 
            this.buttonSet3.BackColor = System.Drawing.Color.Cyan;
            this.buttonSet3.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonSet3.Location = new System.Drawing.Point(390, 452);
            this.buttonSet3.Name = "buttonSet3";
            this.buttonSet3.Size = new System.Drawing.Size(265, 75);
            this.buttonSet3.TabIndex = 2;
            this.buttonSet3.Text = "設定";
            this.buttonSet3.UseVisualStyleBackColor = false;
            this.buttonSet3.Click += new System.EventHandler(this.buttonSet3_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelAlarm1
            // 
            this.labelAlarm1.AutoSize = true;
            this.labelAlarm1.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelAlarm1.Location = new System.Drawing.Point(96, 204);
            this.labelAlarm1.Name = "labelAlarm1";
            this.labelAlarm1.Size = new System.Drawing.Size(254, 97);
            this.labelAlarm1.TabIndex = 3;
            this.labelAlarm1.Text = "00:00";
            // 
            // labelAlarm2
            // 
            this.labelAlarm2.AutoSize = true;
            this.labelAlarm2.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelAlarm2.Location = new System.Drawing.Point(96, 321);
            this.labelAlarm2.Name = "labelAlarm2";
            this.labelAlarm2.Size = new System.Drawing.Size(254, 97);
            this.labelAlarm2.TabIndex = 3;
            this.labelAlarm2.Text = "00:00";
            // 
            // labelAlarm3
            // 
            this.labelAlarm3.AutoSize = true;
            this.labelAlarm3.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelAlarm3.Location = new System.Drawing.Point(96, 440);
            this.labelAlarm3.Name = "labelAlarm3";
            this.labelAlarm3.Size = new System.Drawing.Size(254, 97);
            this.labelAlarm3.TabIndex = 3;
            this.labelAlarm3.Text = "00:00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GreenYellow;
            this.ClientSize = new System.Drawing.Size(706, 604);
            this.Controls.Add(this.labelAlarm3);
            this.Controls.Add(this.labelAlarm2);
            this.Controls.Add(this.labelAlarm1);
            this.Controls.Add(this.buttonSet3);
            this.Controls.Add(this.buttonSet2);
            this.Controls.Add(this.buttonSet1);
            this.Controls.Add(this.checkBoxAlm3);
            this.Controls.Add(this.checkBoxAlm2);
            this.Controls.Add(this.checkBoxAlm1);
            this.Controls.Add(this.labelTime);
            this.Name = "Form1";
            this.Text = "アラーム";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.CheckBox checkBoxAlm1;
        private System.Windows.Forms.CheckBox checkBoxAlm2;
        private System.Windows.Forms.CheckBox checkBoxAlm3;
        private System.Windows.Forms.Button buttonSet1;
        private System.Windows.Forms.Button buttonSet2;
        private System.Windows.Forms.Button buttonSet3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelAlarm1;
        private System.Windows.Forms.Label labelAlarm2;
        private System.Windows.Forms.Label labelAlarm3;
    }
}

