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
            this.buttonSet3 = new System.Windows.Forms.Button();
            this.buttonSet2 = new System.Windows.Forms.Button();
            this.buttonSet1 = new System.Windows.Forms.Button();
            this.labelAlarm3 = new System.Windows.Forms.Label();
            this.labelAlarm2 = new System.Windows.Forms.Label();
            this.labelAlarm1 = new System.Windows.Forms.Label();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.labelNow = new System.Windows.Forms.Label();
            this.timerAlarm = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // buttonSet3
            // 
            this.buttonSet3.BackColor = System.Drawing.Color.White;
            this.buttonSet3.Location = new System.Drawing.Point(202, 207);
            this.buttonSet3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.buttonSet3.Name = "buttonSet3";
            this.buttonSet3.Size = new System.Drawing.Size(105, 34);
            this.buttonSet3.TabIndex = 25;
            this.buttonSet3.Text = "設定";
            this.buttonSet3.UseVisualStyleBackColor = false;
            this.buttonSet3.Click += new System.EventHandler(this.ButtonSet3_Click);
            // 
            // buttonSet2
            // 
            this.buttonSet2.BackColor = System.Drawing.Color.White;
            this.buttonSet2.Location = new System.Drawing.Point(202, 147);
            this.buttonSet2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.buttonSet2.Name = "buttonSet2";
            this.buttonSet2.Size = new System.Drawing.Size(103, 34);
            this.buttonSet2.TabIndex = 23;
            this.buttonSet2.Text = "設定";
            this.buttonSet2.UseVisualStyleBackColor = false;
            this.buttonSet2.Click += new System.EventHandler(this.ButtonSet2_Click);
            // 
            // buttonSet1
            // 
            this.buttonSet1.BackColor = System.Drawing.Color.White;
            this.buttonSet1.Location = new System.Drawing.Point(202, 87);
            this.buttonSet1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.buttonSet1.Name = "buttonSet1";
            this.buttonSet1.Size = new System.Drawing.Size(103, 34);
            this.buttonSet1.TabIndex = 21;
            this.buttonSet1.Text = "設定";
            this.buttonSet1.UseVisualStyleBackColor = false;
            this.buttonSet1.Click += new System.EventHandler(this.ButtonSet1_Click);
            // 
            // labelAlarm3
            // 
            this.labelAlarm3.AutoSize = true;
            this.labelAlarm3.Font = new System.Drawing.Font("ＭＳ ゴシック", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelAlarm3.ForeColor = System.Drawing.Color.Yellow;
            this.labelAlarm3.Location = new System.Drawing.Point(55, 204);
            this.labelAlarm3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelAlarm3.Name = "labelAlarm3";
            this.labelAlarm3.Size = new System.Drawing.Size(123, 41);
            this.labelAlarm3.TabIndex = 16;
            this.labelAlarm3.Text = "00:00";
            // 
            // labelAlarm2
            // 
            this.labelAlarm2.AutoSize = true;
            this.labelAlarm2.Font = new System.Drawing.Font("ＭＳ ゴシック", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelAlarm2.ForeColor = System.Drawing.Color.Yellow;
            this.labelAlarm2.Location = new System.Drawing.Point(55, 144);
            this.labelAlarm2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelAlarm2.Name = "labelAlarm2";
            this.labelAlarm2.Size = new System.Drawing.Size(123, 41);
            this.labelAlarm2.TabIndex = 17;
            this.labelAlarm2.Text = "00:00";
            // 
            // labelAlarm1
            // 
            this.labelAlarm1.AutoSize = true;
            this.labelAlarm1.Font = new System.Drawing.Font("ＭＳ ゴシック", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelAlarm1.ForeColor = System.Drawing.Color.Yellow;
            this.labelAlarm1.Location = new System.Drawing.Point(55, 84);
            this.labelAlarm1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelAlarm1.Name = "labelAlarm1";
            this.labelAlarm1.Size = new System.Drawing.Size(123, 41);
            this.labelAlarm1.TabIndex = 18;
            this.labelAlarm1.Text = "00:00";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(28, 213);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(22, 21);
            this.checkBox3.TabIndex = 24;
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(28, 153);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(22, 21);
            this.checkBox2.TabIndex = 22;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(28, 93);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(22, 21);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // labelNow
            // 
            this.labelNow.AutoSize = true;
            this.labelNow.Font = new System.Drawing.Font("ＭＳ ゴシック", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelNow.ForeColor = System.Drawing.Color.Cyan;
            this.labelNow.Location = new System.Drawing.Point(55, 14);
            this.labelNow.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelNow.Name = "labelNow";
            this.labelNow.Size = new System.Drawing.Size(186, 41);
            this.labelNow.TabIndex = 20;
            this.labelNow.Text = "00:00:00";
            // 
            // timerAlarm
            // 
            this.timerAlarm.Tick += new System.EventHandler(this.TimerAlarm_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(332, 274);
            this.Controls.Add(this.buttonSet3);
            this.Controls.Add(this.buttonSet2);
            this.Controls.Add(this.buttonSet1);
            this.Controls.Add(this.labelAlarm3);
            this.Controls.Add(this.labelAlarm2);
            this.Controls.Add(this.labelAlarm1);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.labelNow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FormMain";
            this.Text = "アラーム";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSet3;
        private System.Windows.Forms.Button buttonSet2;
        private System.Windows.Forms.Button buttonSet1;
        private System.Windows.Forms.Label labelAlarm3;
        private System.Windows.Forms.Label labelAlarm2;
        private System.Windows.Forms.Label labelAlarm1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label labelNow;
        private System.Windows.Forms.Timer timerAlarm;
    }
}

