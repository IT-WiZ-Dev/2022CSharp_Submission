
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
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labeltim1 = new System.Windows.Forms.Label();
            this.labeltim2 = new System.Windows.Forms.Label();
            this.labeltim3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 28F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(68, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "00：00：00";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("MS UI Gothic", 28F);
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(32, 121);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("MS UI Gothic", 28F);
            this.checkBox2.ForeColor = System.Drawing.Color.White;
            this.checkBox2.Location = new System.Drawing.Point(32, 207);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(18, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("MS UI Gothic", 28F);
            this.checkBox3.ForeColor = System.Drawing.Color.White;
            this.checkBox3.Location = new System.Drawing.Point(32, 293);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(18, 17);
            this.checkBox3.TabIndex = 1;
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(213, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "設定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(213, 198);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "設定";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(213, 284);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 35);
            this.button3.TabIndex = 2;
            this.button3.Text = "設定";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labeltim1
            // 
            this.labeltim1.AutoSize = true;
            this.labeltim1.Font = new System.Drawing.Font("MS UI Gothic", 28F);
            this.labeltim1.ForeColor = System.Drawing.Color.White;
            this.labeltim1.Location = new System.Drawing.Point(68, 105);
            this.labeltim1.Name = "labeltim1";
            this.labeltim1.Size = new System.Drawing.Size(126, 47);
            this.labeltim1.TabIndex = 3;
            this.labeltim1.Text = "00:00";
            // 
            // labeltim2
            // 
            this.labeltim2.AutoSize = true;
            this.labeltim2.Font = new System.Drawing.Font("MS UI Gothic", 28F);
            this.labeltim2.ForeColor = System.Drawing.Color.White;
            this.labeltim2.Location = new System.Drawing.Point(68, 192);
            this.labeltim2.Name = "labeltim2";
            this.labeltim2.Size = new System.Drawing.Size(126, 47);
            this.labeltim2.TabIndex = 3;
            this.labeltim2.Text = "00:00";
            // 
            // labeltim3
            // 
            this.labeltim3.AutoSize = true;
            this.labeltim3.Font = new System.Drawing.Font("MS UI Gothic", 28F);
            this.labeltim3.ForeColor = System.Drawing.Color.White;
            this.labeltim3.Location = new System.Drawing.Point(68, 278);
            this.labeltim3.Name = "labeltim3";
            this.labeltim3.Size = new System.Drawing.Size(126, 47);
            this.labeltim3.TabIndex = 3;
            this.labeltim3.Text = "00:00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumBlue;
            this.ClientSize = new System.Drawing.Size(349, 345);
            this.Controls.Add(this.labeltim3);
            this.Controls.Add(this.labeltim2);
            this.Controls.Add(this.labeltim1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "アラーム";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labeltim1;
        private System.Windows.Forms.Label labeltim2;
        private System.Windows.Forms.Label labeltim3;
    }
}

