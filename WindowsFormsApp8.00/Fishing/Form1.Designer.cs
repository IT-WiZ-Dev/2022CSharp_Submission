namespace Fishing
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
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBoxAnkou = new System.Windows.Forms.PictureBox();
            this.pictureBoxUtubo = new System.Windows.Forms.PictureBox();
            this.pictureBoxIwashi = new System.Windows.Forms.PictureBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.pictureBoxEsaM = new System.Windows.Forms.PictureBox();
            this.pictureBoxEsaL = new System.Windows.Forms.PictureBox();
            this.pictureBoxEsaS = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnkou)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUtubo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIwashi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEsaM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEsaL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEsaS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAnkou
            // 
            this.pictureBoxAnkou.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAnkou.Image")));
            this.pictureBoxAnkou.Location = new System.Drawing.Point(12, 451);
            this.pictureBoxAnkou.Name = "pictureBoxAnkou";
            this.pictureBoxAnkou.Size = new System.Drawing.Size(200, 197);
            this.pictureBoxAnkou.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxAnkou.TabIndex = 10;
            this.pictureBoxAnkou.TabStop = false;
            // 
            // pictureBoxUtubo
            // 
            this.pictureBoxUtubo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUtubo.Image")));
            this.pictureBoxUtubo.Location = new System.Drawing.Point(12, 205);
            this.pictureBoxUtubo.Name = "pictureBoxUtubo";
            this.pictureBoxUtubo.Size = new System.Drawing.Size(300, 172);
            this.pictureBoxUtubo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxUtubo.TabIndex = 11;
            this.pictureBoxUtubo.TabStop = false;
            // 
            // pictureBoxIwashi
            // 
            this.pictureBoxIwashi.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIwashi.Image")));
            this.pictureBoxIwashi.Location = new System.Drawing.Point(12, 82);
            this.pictureBoxIwashi.Name = "pictureBoxIwashi";
            this.pictureBoxIwashi.Size = new System.Drawing.Size(150, 49);
            this.pictureBoxIwashi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxIwashi.TabIndex = 9;
            this.pictureBoxIwashi.TabStop = false;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(12, 12);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 17;
            this.buttonStart.Text = "スタート";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTime.ForeColor = System.Drawing.Color.White;
            this.labelTime.Location = new System.Drawing.Point(112, 15);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(114, 16);
            this.labelTime.TabIndex = 16;
            this.labelTime.Text = "残り時間：60秒";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelScore.ForeColor = System.Drawing.Color.White;
            this.labelScore.Location = new System.Drawing.Point(265, 15);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(51, 16);
            this.labelScore.TabIndex = 15;
            this.labelScore.Text = "得点：";
            // 
            // pictureBoxEsaM
            // 
            this.pictureBoxEsaM.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEsaM.Image")));
            this.pictureBoxEsaM.Location = new System.Drawing.Point(1078, 555);
            this.pictureBoxEsaM.Name = "pictureBoxEsaM";
            this.pictureBoxEsaM.Size = new System.Drawing.Size(37, 93);
            this.pictureBoxEsaM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEsaM.TabIndex = 13;
            this.pictureBoxEsaM.TabStop = false;
            // 
            // pictureBoxEsaL
            // 
            this.pictureBoxEsaL.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEsaL.Image")));
            this.pictureBoxEsaL.Location = new System.Drawing.Point(695, 241);
            this.pictureBoxEsaL.Name = "pictureBoxEsaL";
            this.pictureBoxEsaL.Size = new System.Drawing.Size(42, 100);
            this.pictureBoxEsaL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxEsaL.TabIndex = 14;
            this.pictureBoxEsaL.TabStop = false;
            // 
            // pictureBoxEsaS
            // 
            this.pictureBoxEsaS.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEsaS.Image")));
            this.pictureBoxEsaS.Location = new System.Drawing.Point(333, 81);
            this.pictureBoxEsaS.Name = "pictureBoxEsaS";
            this.pictureBoxEsaS.Size = new System.Drawing.Size(25, 50);
            this.pictureBoxEsaS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEsaS.TabIndex = 12;
            this.pictureBoxEsaS.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(882, 573);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(75, 75);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(386, 573);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 75);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(604, 548);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.pictureBoxAnkou);
            this.Controls.Add(this.pictureBoxUtubo);
            this.Controls.Add(this.pictureBoxIwashi);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.pictureBoxEsaM);
            this.Controls.Add(this.pictureBoxEsaL);
            this.Controls.Add(this.pictureBoxEsaS);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "釣りゲーム";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnkou)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUtubo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIwashi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEsaM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEsaL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEsaS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAnkou;
        private System.Windows.Forms.PictureBox pictureBoxUtubo;
        private System.Windows.Forms.PictureBox pictureBoxIwashi;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.PictureBox pictureBoxEsaM;
        private System.Windows.Forms.PictureBox pictureBoxEsaL;
        private System.Windows.Forms.PictureBox pictureBoxEsaS;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

