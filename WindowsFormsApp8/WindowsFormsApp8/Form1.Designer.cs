
namespace WindowsFormsApp8
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
            this.labelTimer1 = new System.Windows.Forms.Label();
            this.labelTimer2 = new System.Windows.Forms.Label();
            this.labelTimer3 = new System.Windows.Forms.Label();
            this.buttonSet1 = new System.Windows.Forms.Button();
            this.buttonSet2 = new System.Windows.Forms.Button();
            this.buttonSet3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("MS UI Gothic", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTime.Location = new System.Drawing.Point(206, 50);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(178, 44);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "12:59:59";
            this.labelTime.Click += new System.EventHandler(this.labelTime_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(115, 120);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(22, 21);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(115, 195);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(22, 21);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(115, 272);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(22, 21);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // labelTimer1
            // 
            this.labelTimer1.AutoSize = true;
            this.labelTimer1.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTimer1.Location = new System.Drawing.Point(206, 120);
            this.labelTimer1.Name = "labelTimer1";
            this.labelTimer1.Size = new System.Drawing.Size(86, 33);
            this.labelTimer1.TabIndex = 4;
            this.labelTimer1.Text = "00:00";
            // 
            // labelTimer2
            // 
            this.labelTimer2.AutoSize = true;
            this.labelTimer2.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTimer2.Location = new System.Drawing.Point(206, 195);
            this.labelTimer2.Name = "labelTimer2";
            this.labelTimer2.Size = new System.Drawing.Size(86, 33);
            this.labelTimer2.TabIndex = 5;
            this.labelTimer2.Text = "00:00";
            this.labelTimer2.Click += new System.EventHandler(this.labelTimer2_Click);
            // 
            // labelTimer3
            // 
            this.labelTimer3.AutoSize = true;
            this.labelTimer3.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTimer3.Location = new System.Drawing.Point(206, 275);
            this.labelTimer3.Name = "labelTimer3";
            this.labelTimer3.Size = new System.Drawing.Size(86, 33);
            this.labelTimer3.TabIndex = 6;
            this.labelTimer3.Text = "00:00";
            // 
            // buttonSet1
            // 
            this.buttonSet1.Location = new System.Drawing.Point(417, 120);
            this.buttonSet1.Name = "buttonSet1";
            this.buttonSet1.Size = new System.Drawing.Size(75, 23);
            this.buttonSet1.TabIndex = 7;
            this.buttonSet1.Text = "設定";
            this.buttonSet1.UseVisualStyleBackColor = true;
            this.buttonSet1.Click += new System.EventHandler(this.buttonSet1_Click);
            // 
            // buttonSet2
            // 
            this.buttonSet2.Location = new System.Drawing.Point(417, 190);
            this.buttonSet2.Name = "buttonSet2";
            this.buttonSet2.Size = new System.Drawing.Size(75, 23);
            this.buttonSet2.TabIndex = 8;
            this.buttonSet2.Text = "設定";
            this.buttonSet2.UseVisualStyleBackColor = true;
            this.buttonSet2.Click += new System.EventHandler(this.buttonSet2_Click);
            // 
            // buttonSet3
            // 
            this.buttonSet3.Location = new System.Drawing.Point(417, 270);
            this.buttonSet3.Name = "buttonSet3";
            this.buttonSet3.Size = new System.Drawing.Size(75, 23);
            this.buttonSet3.TabIndex = 9;
            this.buttonSet3.Text = "設定";
            this.buttonSet3.UseVisualStyleBackColor = true;
            this.buttonSet3.Click += new System.EventHandler(this.buttonSet3_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSet3);
            this.Controls.Add(this.buttonSet2);
            this.Controls.Add(this.buttonSet1);
            this.Controls.Add(this.labelTimer3);
            this.Controls.Add(this.labelTimer2);
            this.Controls.Add(this.labelTimer1);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.labelTime);
            this.Name = "Form1";
            this.Text = "アラーム";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label labelTimer1;
        private System.Windows.Forms.Label labelTimer2;
        private System.Windows.Forms.Label labelTimer3;
        private System.Windows.Forms.Button buttonSet1;
        private System.Windows.Forms.Button buttonSet2;
        private System.Windows.Forms.Button buttonSet3;
        private System.Windows.Forms.Timer timer1;
    }
}

