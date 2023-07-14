
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.esaL = new System.Windows.Forms.PictureBox();
            this.esaM = new System.Windows.Forms.PictureBox();
            this.esaS = new System.Windows.Forms.PictureBox();
            this.pictureBoxiwashi = new System.Windows.Forms.PictureBox();
            this.pictureBoxankou = new System.Windows.Forms.PictureBox();
            this.pictureBoxisoginchaku = new System.Windows.Forms.PictureBox();
            this.pictureBoxhitode = new System.Windows.Forms.PictureBox();
            this.pictureBoxutubo = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.esaL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.esaM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.esaS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxiwashi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxankou)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxisoginchaku)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxhitode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxutubo)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "スタート";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "残り時間：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(246, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "得点：";
            // 
            // esaL
            // 
            this.esaL.Image = global::Fishing.Properties.Resources.esa_L;
            this.esaL.Location = new System.Drawing.Point(648, 213);
            this.esaL.Name = "esaL";
            this.esaL.Size = new System.Drawing.Size(42, 100);
            this.esaL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.esaL.TabIndex = 12;
            this.esaL.TabStop = false;
            // 
            // esaM
            // 
            this.esaM.Cursor = System.Windows.Forms.Cursors.Default;
            this.esaM.Image = global::Fishing.Properties.Resources.esa_M;
            this.esaM.Location = new System.Drawing.Point(993, 576);
            this.esaM.Name = "esaM";
            this.esaM.Size = new System.Drawing.Size(31, 75);
            this.esaM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.esaM.TabIndex = 11;
            this.esaM.TabStop = false;
            // 
            // esaS
            // 
            this.esaS.Image = global::Fishing.Properties.Resources.esa_S;
            this.esaS.Location = new System.Drawing.Point(319, 90);
            this.esaS.Name = "esaS";
            this.esaS.Size = new System.Drawing.Size(21, 50);
            this.esaS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.esaS.TabIndex = 10;
            this.esaS.TabStop = false;
            // 
            // pictureBoxiwashi
            // 
            this.pictureBoxiwashi.Image = global::Fishing.Properties.Resources.iwashi;
            this.pictureBoxiwashi.Location = new System.Drawing.Point(468, 90);
            this.pictureBoxiwashi.Name = "pictureBoxiwashi";
            this.pictureBoxiwashi.Size = new System.Drawing.Size(150, 49);
            this.pictureBoxiwashi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxiwashi.TabIndex = 9;
            this.pictureBoxiwashi.TabStop = false;
            // 
            // pictureBoxankou
            // 
            this.pictureBoxankou.Image = global::Fishing.Properties.Resources.ankou;
            this.pictureBoxankou.Location = new System.Drawing.Point(744, 454);
            this.pictureBoxankou.Name = "pictureBoxankou";
            this.pictureBoxankou.Size = new System.Drawing.Size(200, 197);
            this.pictureBoxankou.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxankou.TabIndex = 8;
            this.pictureBoxankou.TabStop = false;
            // 
            // pictureBoxisoginchaku
            // 
            this.pictureBoxisoginchaku.Image = global::Fishing.Properties.Resources.isoginchaku;
            this.pictureBoxisoginchaku.Location = new System.Drawing.Point(507, 551);
            this.pictureBoxisoginchaku.Name = "pictureBoxisoginchaku";
            this.pictureBoxisoginchaku.Size = new System.Drawing.Size(97, 100);
            this.pictureBoxisoginchaku.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxisoginchaku.TabIndex = 7;
            this.pictureBoxisoginchaku.TabStop = false;
            // 
            // pictureBoxhitode
            // 
            this.pictureBoxhitode.Image = global::Fishing.Properties.Resources.hitode;
            this.pictureBoxhitode.Location = new System.Drawing.Point(300, 576);
            this.pictureBoxhitode.Name = "pictureBoxhitode";
            this.pictureBoxhitode.Size = new System.Drawing.Size(75, 75);
            this.pictureBoxhitode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxhitode.TabIndex = 6;
            this.pictureBoxhitode.TabStop = false;
            // 
            // pictureBoxutubo
            // 
            this.pictureBoxutubo.Image = global::Fishing.Properties.Resources.utubo;
            this.pictureBoxutubo.Location = new System.Drawing.Point(12, 200);
            this.pictureBoxutubo.Name = "pictureBoxutubo";
            this.pictureBoxutubo.Size = new System.Drawing.Size(300, 172);
            this.pictureBoxutubo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxutubo.TabIndex = 5;
            this.pictureBoxutubo.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1078, 663);
            this.Controls.Add(this.esaL);
            this.Controls.Add(this.esaM);
            this.Controls.Add(this.esaS);
            this.Controls.Add(this.pictureBoxiwashi);
            this.Controls.Add(this.pictureBoxankou);
            this.Controls.Add(this.pictureBoxisoginchaku);
            this.Controls.Add(this.pictureBoxhitode);
            this.Controls.Add(this.pictureBoxutubo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.esaL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.esaM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.esaS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxiwashi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxankou)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxisoginchaku)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxhitode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxutubo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBoxutubo;
        private System.Windows.Forms.PictureBox pictureBoxhitode;
        private System.Windows.Forms.PictureBox pictureBoxisoginchaku;
        private System.Windows.Forms.PictureBox pictureBoxankou;
        private System.Windows.Forms.PictureBox pictureBoxiwashi;
        private System.Windows.Forms.PictureBox esaS;
        private System.Windows.Forms.PictureBox esaM;
        private System.Windows.Forms.PictureBox esaL;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

