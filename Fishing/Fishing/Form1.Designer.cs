
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxIwashi = new System.Windows.Forms.PictureBox();
            this.pictureBoxUtsubo = new System.Windows.Forms.PictureBox();
            this.pictureBoxAnko = new System.Windows.Forms.PictureBox();
            this.pictureBoxHitode = new System.Windows.Forms.PictureBox();
            this.pictureBoxIsoginchaku = new System.Windows.Forms.PictureBox();
            this.pictureBoxFeedS = new System.Windows.Forms.PictureBox();
            this.pictureBoxFeedL = new System.Windows.Forms.PictureBox();
            this.pictureBoxFeedM = new System.Windows.Forms.PictureBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelTimeLimit = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIwashi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUtsubo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnko)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHitode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIsoginchaku)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFeedS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFeedL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFeedM)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBoxIwashi
            // 
            this.pictureBoxIwashi.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIwashi.Image")));
            this.pictureBoxIwashi.Location = new System.Drawing.Point(12, 91);
            this.pictureBoxIwashi.Name = "pictureBoxIwashi";
            this.pictureBoxIwashi.Size = new System.Drawing.Size(150, 49);
            this.pictureBoxIwashi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxIwashi.TabIndex = 0;
            this.pictureBoxIwashi.TabStop = false;
            // 
            // pictureBoxUtsubo
            // 
            this.pictureBoxUtsubo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUtsubo.Image")));
            this.pictureBoxUtsubo.Location = new System.Drawing.Point(-73, 269);
            this.pictureBoxUtsubo.Name = "pictureBoxUtsubo";
            this.pictureBoxUtsubo.Size = new System.Drawing.Size(300, 172);
            this.pictureBoxUtsubo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxUtsubo.TabIndex = 1;
            this.pictureBoxUtsubo.TabStop = false;
            // 
            // pictureBoxAnko
            // 
            this.pictureBoxAnko.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAnko.Image")));
            this.pictureBoxAnko.Location = new System.Drawing.Point(12, 544);
            this.pictureBoxAnko.Name = "pictureBoxAnko";
            this.pictureBoxAnko.Size = new System.Drawing.Size(200, 197);
            this.pictureBoxAnko.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxAnko.TabIndex = 2;
            this.pictureBoxAnko.TabStop = false;
            // 
            // pictureBoxHitode
            // 
            this.pictureBoxHitode.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxHitode.Image")));
            this.pictureBoxHitode.Location = new System.Drawing.Point(419, 666);
            this.pictureBoxHitode.Name = "pictureBoxHitode";
            this.pictureBoxHitode.Size = new System.Drawing.Size(75, 75);
            this.pictureBoxHitode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxHitode.TabIndex = 3;
            this.pictureBoxHitode.TabStop = false;
            // 
            // pictureBoxIsoginchaku
            // 
            this.pictureBoxIsoginchaku.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIsoginchaku.Image")));
            this.pictureBoxIsoginchaku.Location = new System.Drawing.Point(673, 641);
            this.pictureBoxIsoginchaku.Name = "pictureBoxIsoginchaku";
            this.pictureBoxIsoginchaku.Size = new System.Drawing.Size(97, 100);
            this.pictureBoxIsoginchaku.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxIsoginchaku.TabIndex = 4;
            this.pictureBoxIsoginchaku.TabStop = false;
            // 
            // pictureBoxFeedS
            // 
            this.pictureBoxFeedS.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFeedS.Image")));
            this.pictureBoxFeedS.Location = new System.Drawing.Point(292, 90);
            this.pictureBoxFeedS.Name = "pictureBoxFeedS";
            this.pictureBoxFeedS.Size = new System.Drawing.Size(21, 50);
            this.pictureBoxFeedS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxFeedS.TabIndex = 5;
            this.pictureBoxFeedS.TabStop = false;
            // 
            // pictureBoxFeedL
            // 
            this.pictureBoxFeedL.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFeedL.Image")));
            this.pictureBoxFeedL.Location = new System.Drawing.Point(673, 282);
            this.pictureBoxFeedL.Name = "pictureBoxFeedL";
            this.pictureBoxFeedL.Size = new System.Drawing.Size(42, 100);
            this.pictureBoxFeedL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxFeedL.TabIndex = 6;
            this.pictureBoxFeedL.TabStop = false;
            // 
            // pictureBoxFeedM
            // 
            this.pictureBoxFeedM.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFeedM.Image")));
            this.pictureBoxFeedM.Location = new System.Drawing.Point(1041, 666);
            this.pictureBoxFeedM.Name = "pictureBoxFeedM";
            this.pictureBoxFeedM.Size = new System.Drawing.Size(31, 75);
            this.pictureBoxFeedM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxFeedM.TabIndex = 7;
            this.pictureBoxFeedM.TabStop = false;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(12, 12);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 26);
            this.buttonStart.TabIndex = 8;
            this.buttonStart.Text = "スタート";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click_1);
            // 
            // labelTimeLimit
            // 
            this.labelTimeLimit.AutoSize = true;
            this.labelTimeLimit.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTimeLimit.Location = new System.Drawing.Point(105, 16);
            this.labelTimeLimit.Name = "labelTimeLimit";
            this.labelTimeLimit.Size = new System.Drawing.Size(122, 17);
            this.labelTimeLimit.TabIndex = 9;
            this.labelTimeLimit.Text = "残り時間：60秒";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelScore.Location = new System.Drawing.Point(253, 16);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(64, 17);
            this.labelScore.TabIndex = 10;
            this.labelScore.Text = "得点：0";
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelTimeLimit);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.pictureBoxFeedM);
            this.Controls.Add(this.pictureBoxFeedL);
            this.Controls.Add(this.pictureBoxFeedS);
            this.Controls.Add(this.pictureBoxIsoginchaku);
            this.Controls.Add(this.pictureBoxHitode);
            this.Controls.Add(this.pictureBoxAnko);
            this.Controls.Add(this.pictureBoxUtsubo);
            this.Controls.Add(this.pictureBoxIwashi);
            this.KeyPreview = true;
            this.Name = "FormGame";
            this.Text = "釣りゲーム";
            this.Load += new System.EventHandler(this.FormGame_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormGame_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIwashi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUtsubo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnko)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHitode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIsoginchaku)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFeedS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFeedL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFeedM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBoxIwashi;
        private System.Windows.Forms.PictureBox pictureBoxUtsubo;
        private System.Windows.Forms.PictureBox pictureBoxAnko;
        private System.Windows.Forms.PictureBox pictureBoxHitode;
        private System.Windows.Forms.PictureBox pictureBoxIsoginchaku;
        private System.Windows.Forms.PictureBox pictureBoxFeedS;
        private System.Windows.Forms.PictureBox pictureBoxFeedL;
        private System.Windows.Forms.PictureBox pictureBoxFeedM;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelTimeLimit;
        private System.Windows.Forms.Label labelScore;
    }
}

