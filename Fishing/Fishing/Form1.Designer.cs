
namespace Fishing
{
    partial class FormGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGame));
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelTimer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelScore = new System.Windows.Forms.Label();
            this.pictureBoxIwashi = new System.Windows.Forms.PictureBox();
            this.pictureBoxEsaS = new System.Windows.Forms.PictureBox();
            this.pictureBoxUtubo = new System.Windows.Forms.PictureBox();
            this.pictureBoxEsaL = new System.Windows.Forms.PictureBox();
            this.pictureBoxAnkou = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxEsaM = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIwashi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEsaS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUtubo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEsaL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnkou)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEsaM)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(12, 12);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(89, 33);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "スタート";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTimer.ForeColor = System.Drawing.Color.White;
            this.labelTimer.Location = new System.Drawing.Point(130, 19);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(153, 22);
            this.labelTimer.TabIndex = 1;
            this.labelTimer.Text = "残り時間：60秒";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelScore.ForeColor = System.Drawing.Color.White;
            this.labelScore.Location = new System.Drawing.Point(306, 19);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(68, 22);
            this.labelScore.TabIndex = 2;
            this.labelScore.Text = "得点：";
            // 
            // pictureBoxIwashi
            // 
            this.pictureBoxIwashi.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIwashi.Image")));
            this.pictureBoxIwashi.Location = new System.Drawing.Point(640, 112);
            this.pictureBoxIwashi.Name = "pictureBoxIwashi";
            this.pictureBoxIwashi.Size = new System.Drawing.Size(150, 49);
            this.pictureBoxIwashi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxIwashi.TabIndex = 34;
            this.pictureBoxIwashi.TabStop = false;
            // 
            // pictureBoxEsaS
            // 
            this.pictureBoxEsaS.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEsaS.Image")));
            this.pictureBoxEsaS.Location = new System.Drawing.Point(1241, 111);
            this.pictureBoxEsaS.Name = "pictureBoxEsaS";
            this.pictureBoxEsaS.Size = new System.Drawing.Size(25, 50);
            this.pictureBoxEsaS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEsaS.TabIndex = 37;
            this.pictureBoxEsaS.TabStop = false;
            // 
            // pictureBoxUtubo
            // 
            this.pictureBoxUtubo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUtubo.Image")));
            this.pictureBoxUtubo.Location = new System.Drawing.Point(12, 340);
            this.pictureBoxUtubo.Name = "pictureBoxUtubo";
            this.pictureBoxUtubo.Size = new System.Drawing.Size(300, 172);
            this.pictureBoxUtubo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxUtubo.TabIndex = 38;
            this.pictureBoxUtubo.TabStop = false;
            // 
            // pictureBoxEsaL
            // 
            this.pictureBoxEsaL.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEsaL.Image")));
            this.pictureBoxEsaL.Location = new System.Drawing.Point(1108, 340);
            this.pictureBoxEsaL.Name = "pictureBoxEsaL";
            this.pictureBoxEsaL.Size = new System.Drawing.Size(42, 100);
            this.pictureBoxEsaL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxEsaL.TabIndex = 39;
            this.pictureBoxEsaL.TabStop = false;
            // 
            // pictureBoxAnkou
            // 
            this.pictureBoxAnkou.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAnkou.Image")));
            this.pictureBoxAnkou.Location = new System.Drawing.Point(900, 628);
            this.pictureBoxAnkou.Name = "pictureBoxAnkou";
            this.pictureBoxAnkou.Size = new System.Drawing.Size(200, 197);
            this.pictureBoxAnkou.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxAnkou.TabIndex = 40;
            this.pictureBoxAnkou.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(362, 750);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 75);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 44;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(626, 725);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxEsaM
            // 
            this.pictureBoxEsaM.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEsaM.Image")));
            this.pictureBoxEsaM.Location = new System.Drawing.Point(1207, 732);
            this.pictureBoxEsaM.Name = "pictureBoxEsaM";
            this.pictureBoxEsaM.Size = new System.Drawing.Size(37, 93);
            this.pictureBoxEsaM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEsaM.TabIndex = 46;
            this.pictureBoxEsaM.TabStop = false;
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1414, 837);
            this.Controls.Add(this.pictureBoxEsaM);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBoxAnkou);
            this.Controls.Add(this.pictureBoxEsaL);
            this.Controls.Add(this.pictureBoxUtubo);
            this.Controls.Add(this.pictureBoxEsaS);
            this.Controls.Add(this.pictureBoxIwashi);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.buttonStart);
            this.Name = "FormGame";
            this.Text = "釣りゲーム";
            this.Load += new System.EventHandler(this.FormGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIwashi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEsaS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUtubo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEsaL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnkou)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEsaM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.PictureBox pictureBoxIwashi;
        private System.Windows.Forms.PictureBox pictureBoxEsaS;
        private System.Windows.Forms.PictureBox pictureBoxUtubo;
        private System.Windows.Forms.PictureBox pictureBoxEsaL;
        private System.Windows.Forms.PictureBox pictureBoxAnkou;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxEsaM;
    }
}

