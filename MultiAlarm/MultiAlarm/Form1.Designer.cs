
namespace MultiAlarm
{
    partial class Forｍ1
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
            this.checkBoxAlam1 = new System.Windows.Forms.CheckBox();
            this.checkBoxAlam2 = new System.Windows.Forms.CheckBox();
            this.checkBoxAlam3 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("MS UI Gothic", 30F);
            this.labelTime.ForeColor = System.Drawing.Color.White;
            this.labelTime.Location = new System.Drawing.Point(45, 18);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(229, 60);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "23:35:30";
            // 
            // checkBoxAlam1
            // 
            this.checkBoxAlam1.AutoSize = true;
            this.checkBoxAlam1.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.checkBoxAlam1.ForeColor = System.Drawing.Color.White;
            this.checkBoxAlam1.Location = new System.Drawing.Point(55, 107);
            this.checkBoxAlam1.Name = "checkBoxAlam1";
            this.checkBoxAlam1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBoxAlam1.Size = new System.Drawing.Size(105, 34);
            this.checkBoxAlam1.TabIndex = 1;
            this.checkBoxAlam1.Text = "00:00";
            this.checkBoxAlam1.UseVisualStyleBackColor = true;
            // 
            // checkBoxAlam2
            // 
            this.checkBoxAlam2.AutoSize = true;
            this.checkBoxAlam2.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.checkBoxAlam2.ForeColor = System.Drawing.Color.White;
            this.checkBoxAlam2.Location = new System.Drawing.Point(55, 163);
            this.checkBoxAlam2.Name = "checkBoxAlam2";
            this.checkBoxAlam2.Size = new System.Drawing.Size(105, 34);
            this.checkBoxAlam2.TabIndex = 2;
            this.checkBoxAlam2.Text = "00:00";
            this.checkBoxAlam2.UseVisualStyleBackColor = true;
            // 
            // checkBoxAlam3
            // 
            this.checkBoxAlam3.AutoSize = true;
            this.checkBoxAlam3.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.checkBoxAlam3.ForeColor = System.Drawing.Color.White;
            this.checkBoxAlam3.Location = new System.Drawing.Point(55, 223);
            this.checkBoxAlam3.Name = "checkBoxAlam3";
            this.checkBoxAlam3.Size = new System.Drawing.Size(105, 34);
            this.checkBoxAlam3.TabIndex = 3;
            this.checkBoxAlam3.Text = "00:00";
            this.checkBoxAlam3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OliveDrab;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(216, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "設定";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.OliveDrab;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(216, 166);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 31);
            this.button2.TabIndex = 5;
            this.button2.Text = "設定";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.OliveDrab;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(216, 226);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 31);
            this.button3.TabIndex = 6;
            this.button3.Text = "設定";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Forｍ1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(439, 294);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBoxAlam3);
            this.Controls.Add(this.checkBoxAlam2);
            this.Controls.Add(this.checkBoxAlam1);
            this.Controls.Add(this.labelTime);
            this.Name = "Forｍ1";
            this.Text = "アラーム";
            this.Load += new System.EventHandler(this.Forｍ1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.CheckBox checkBoxAlam1;
        private System.Windows.Forms.CheckBox checkBoxAlam2;
        private System.Windows.Forms.CheckBox checkBoxAlam3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer timer1;
    }
}

