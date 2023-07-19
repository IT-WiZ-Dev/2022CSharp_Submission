
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
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.pictureBoxesa_S = new System.Windows.Forms.PictureBox();
            this.pictureBoxiutubo = new System.Windows.Forms.PictureBox();
            this.pictureBoxesa_M = new System.Windows.Forms.PictureBox();
            this.hitode = new System.Windows.Forms.PictureBox();
            this.isoginchaku = new System.Windows.Forms.PictureBox();
            this.pictureBoxankou = new System.Windows.Forms.PictureBox();
            this.pictureBoxesa_L = new System.Windows.Forms.PictureBox();
            this.pictureBoxiwashi = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxesa_S)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxiutubo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxesa_M)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hitode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isoginchaku)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxankou)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxesa_L)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxiwashi)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(12, 18);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(84, 23);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "スタート";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(145, 23);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(52, 18);
            this.labelTime.TabIndex = 1;
            this.labelTime.Text = "label1";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(303, 23);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(52, 18);
            this.labelScore.TabIndex = 2;
            this.labelScore.Text = "label2";
            // 
            // pictureBoxesa_S
            // 
            this.pictureBoxesa_S.Image = global::Fishing.Properties.Resources.esa_S;
            this.pictureBoxesa_S.Location = new System.Drawing.Point(260, 94);
            this.pictureBoxesa_S.Name = "pictureBoxesa_S";
            this.pictureBoxesa_S.Size = new System.Drawing.Size(21, 50);
            this.pictureBoxesa_S.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxesa_S.TabIndex = 3;
            this.pictureBoxesa_S.TabStop = false;
            // 
            // pictureBoxiutubo
            // 
            this.pictureBoxiutubo.Image = global::Fishing.Properties.Resources.utubo;
            this.pictureBoxiutubo.Location = new System.Drawing.Point(12, 227);
            this.pictureBoxiutubo.Name = "pictureBoxiutubo";
            this.pictureBoxiutubo.Size = new System.Drawing.Size(300, 172);
            this.pictureBoxiutubo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxiutubo.TabIndex = 5;
            this.pictureBoxiutubo.TabStop = false;
            // 
            // pictureBoxesa_M
            // 
            this.pictureBoxesa_M.Image = global::Fishing.Properties.Resources.esa_M;
            this.pictureBoxesa_M.Location = new System.Drawing.Point(747, 266);
            this.pictureBoxesa_M.Name = "pictureBoxesa_M";
            this.pictureBoxesa_M.Size = new System.Drawing.Size(31, 75);
            this.pictureBoxesa_M.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxesa_M.TabIndex = 6;
            this.pictureBoxesa_M.TabStop = false;
            // 
            // hitode
            // 
            this.hitode.Image = global::Fishing.Properties.Resources.hitode;
            this.hitode.Location = new System.Drawing.Point(260, 553);
            this.hitode.Name = "hitode";
            this.hitode.Size = new System.Drawing.Size(75, 75);
            this.hitode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.hitode.TabIndex = 7;
            this.hitode.TabStop = false;
            // 
            // isoginchaku
            // 
            this.isoginchaku.Image = global::Fishing.Properties.Resources.isoginchaku;
            this.isoginchaku.Location = new System.Drawing.Point(469, 528);
            this.isoginchaku.Name = "isoginchaku";
            this.isoginchaku.Size = new System.Drawing.Size(97, 100);
            this.isoginchaku.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.isoginchaku.TabIndex = 8;
            this.isoginchaku.TabStop = false;
            // 
            // pictureBoxankou
            // 
            this.pictureBoxankou.Image = global::Fishing.Properties.Resources.ankou;
            this.pictureBoxankou.Location = new System.Drawing.Point(710, 452);
            this.pictureBoxankou.Name = "pictureBoxankou";
            this.pictureBoxankou.Size = new System.Drawing.Size(200, 197);
            this.pictureBoxankou.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxankou.TabIndex = 9;
            this.pictureBoxankou.TabStop = false;
            // 
            // pictureBoxesa_L
            // 
            this.pictureBoxesa_L.Image = global::Fishing.Properties.Resources.esa_L;
            this.pictureBoxesa_L.Location = new System.Drawing.Point(1083, 528);
            this.pictureBoxesa_L.Name = "pictureBoxesa_L";
            this.pictureBoxesa_L.Size = new System.Drawing.Size(42, 100);
            this.pictureBoxesa_L.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxesa_L.TabIndex = 10;
            this.pictureBoxesa_L.TabStop = false;
            // 
            // pictureBoxiwashi
            // 
            this.pictureBoxiwashi.Image = global::Fishing.Properties.Resources.iwashi;
            this.pictureBoxiwashi.Location = new System.Drawing.Point(550, 95);
            this.pictureBoxiwashi.Name = "pictureBoxiwashi";
            this.pictureBoxiwashi.Size = new System.Drawing.Size(150, 49);
            this.pictureBoxiwashi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxiwashi.TabIndex = 11;
            this.pictureBoxiwashi.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.pictureBoxiwashi);
            this.Controls.Add(this.pictureBoxesa_L);
            this.Controls.Add(this.pictureBoxankou);
            this.Controls.Add(this.isoginchaku);
            this.Controls.Add(this.hitode);
            this.Controls.Add(this.pictureBoxesa_M);
            this.Controls.Add(this.pictureBoxiutubo);
            this.Controls.Add(this.pictureBoxesa_S);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.buttonStart);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxesa_S)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxiutubo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxesa_M)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hitode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isoginchaku)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxankou)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxesa_L)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxiwashi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.PictureBox pictureBoxesa_S;
        private System.Windows.Forms.PictureBox pictureBoxiutubo;
        private System.Windows.Forms.PictureBox pictureBoxesa_M;
        private System.Windows.Forms.PictureBox hitode;
        private System.Windows.Forms.PictureBox isoginchaku;
        private System.Windows.Forms.PictureBox pictureBoxankou;
        private System.Windows.Forms.PictureBox pictureBoxesa_L;
        private System.Windows.Forms.PictureBox pictureBoxiwashi;
        private System.Windows.Forms.Timer timer1;
    }
}

