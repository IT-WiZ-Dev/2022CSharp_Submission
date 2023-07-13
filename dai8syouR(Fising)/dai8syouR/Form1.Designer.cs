namespace dai8syouR
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
            this.pictureBoxutubo = new System.Windows.Forms.PictureBox();
            this.pictureBoxesaS = new System.Windows.Forms.PictureBox();
            this.pictureBoxankou = new System.Windows.Forms.PictureBox();
            this.pictureBoxiwasi = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxIso = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBoxesaL = new System.Windows.Forms.PictureBox();
            this.pictureBoxesa = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxutubo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxesaS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxankou)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxiwasi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxesaL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxesa)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "スタート";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "残り時間：60秒";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "得点：0";
            // 
            // pictureBoxutubo
            // 
            this.pictureBoxutubo.Image = global::dai8syouR.Properties.Resources.utubo;
            this.pictureBoxutubo.Location = new System.Drawing.Point(-14, 166);
            this.pictureBoxutubo.Name = "pictureBoxutubo";
            this.pictureBoxutubo.Size = new System.Drawing.Size(300, 172);
            this.pictureBoxutubo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxutubo.TabIndex = 3;
            this.pictureBoxutubo.TabStop = false;
            // 
            // pictureBoxesaS
            // 
            this.pictureBoxesaS.Image = global::dai8syouR.Properties.Resources.esa_S;
            this.pictureBoxesaS.Location = new System.Drawing.Point(376, 82);
            this.pictureBoxesaS.Name = "pictureBoxesaS";
            this.pictureBoxesaS.Size = new System.Drawing.Size(21, 50);
            this.pictureBoxesaS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxesaS.TabIndex = 4;
            this.pictureBoxesaS.TabStop = false;
            // 
            // pictureBoxankou
            // 
            this.pictureBoxankou.Image = global::dai8syouR.Properties.Resources.ankou;
            this.pictureBoxankou.Location = new System.Drawing.Point(703, 435);
            this.pictureBoxankou.Name = "pictureBoxankou";
            this.pictureBoxankou.Size = new System.Drawing.Size(200, 197);
            this.pictureBoxankou.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxankou.TabIndex = 5;
            this.pictureBoxankou.TabStop = false;
            // 
            // pictureBoxiwasi
            // 
            this.pictureBoxiwasi.Image = global::dai8syouR.Properties.Resources.iwashi;
            this.pictureBoxiwasi.Location = new System.Drawing.Point(27, 83);
            this.pictureBoxiwasi.Name = "pictureBoxiwasi";
            this.pictureBoxiwasi.Size = new System.Drawing.Size(150, 49);
            this.pictureBoxiwasi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxiwasi.TabIndex = 6;
            this.pictureBoxiwasi.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBoxIso
            // 
            this.pictureBoxIso.Image = global::dai8syouR.Properties.Resources.isoginchaku;
            this.pictureBoxIso.Location = new System.Drawing.Point(581, 545);
            this.pictureBoxIso.Name = "pictureBoxIso";
            this.pictureBoxIso.Size = new System.Drawing.Size(97, 100);
            this.pictureBoxIso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxIso.TabIndex = 7;
            this.pictureBoxIso.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::dai8syouR.Properties.Resources.hitode;
            this.pictureBox4.Location = new System.Drawing.Point(434, 570);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(75, 75);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBoxesaL
            // 
            this.pictureBoxesaL.Image = global::dai8syouR.Properties.Resources.esa_L;
            this.pictureBoxesaL.Location = new System.Drawing.Point(454, 195);
            this.pictureBoxesaL.Name = "pictureBoxesaL";
            this.pictureBoxesaL.Size = new System.Drawing.Size(42, 100);
            this.pictureBoxesaL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxesaL.TabIndex = 10;
            this.pictureBoxesaL.TabStop = false;
            // 
            // pictureBoxesa
            // 
            this.pictureBoxesa.Image = global::dai8syouR.Properties.Resources.esa_M;
            this.pictureBoxesa.Location = new System.Drawing.Point(979, 545);
            this.pictureBoxesa.Name = "pictureBoxesa";
            this.pictureBoxesa.Size = new System.Drawing.Size(31, 75);
            this.pictureBoxesa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxesa.TabIndex = 11;
            this.pictureBoxesa.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1078, 644);
            this.Controls.Add(this.pictureBoxesa);
            this.Controls.Add(this.pictureBoxesaL);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBoxIso);
            this.Controls.Add(this.pictureBoxiwasi);
            this.Controls.Add(this.pictureBoxankou);
            this.Controls.Add(this.pictureBoxesaS);
            this.Controls.Add(this.pictureBoxutubo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxutubo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxesaS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxankou)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxiwasi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxesaL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxesa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxutubo;
        private System.Windows.Forms.PictureBox pictureBoxesaS;
        private System.Windows.Forms.PictureBox pictureBoxankou;
        private System.Windows.Forms.PictureBox pictureBoxiwasi;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBoxIso;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBoxesaL;
        private System.Windows.Forms.PictureBox pictureBoxesa;
    }
}

