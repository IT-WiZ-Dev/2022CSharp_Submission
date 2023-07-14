
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Utu = new System.Windows.Forms.PictureBox();
            this.pictureBoxB = new System.Windows.Forms.PictureBox();
            this.pictureBoxC = new System.Windows.Forms.PictureBox();
            this.An = new System.Windows.Forms.PictureBox();
            this.Iw = new System.Windows.Forms.PictureBox();
            this.EsaS = new System.Windows.Forms.PictureBox();
            this.EsaM = new System.Windows.Forms.PictureBox();
            this.EsaL = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Utu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.An)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Iw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EsaS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EsaM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EsaL)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
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
            this.label1.Location = new System.Drawing.Point(109, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "残り時間：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "得点：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(299, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "label4";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Utu
            // 
            this.Utu.Image = ((System.Drawing.Image)(resources.GetObject("Utu.Image")));
            this.Utu.Location = new System.Drawing.Point(-73, 222);
            this.Utu.Name = "Utu";
            this.Utu.Size = new System.Drawing.Size(300, 172);
            this.Utu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Utu.TabIndex = 5;
            this.Utu.TabStop = false;
            // 
            // pictureBoxB
            // 
            this.pictureBoxB.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxB.Image")));
            this.pictureBoxB.Location = new System.Drawing.Point(363, 523);
            this.pictureBoxB.Name = "pictureBoxB";
            this.pictureBoxB.Size = new System.Drawing.Size(75, 75);
            this.pictureBoxB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxB.TabIndex = 6;
            this.pictureBoxB.TabStop = false;
            // 
            // pictureBoxC
            // 
            this.pictureBoxC.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxC.Image")));
            this.pictureBoxC.Location = new System.Drawing.Point(547, 498);
            this.pictureBoxC.Name = "pictureBoxC";
            this.pictureBoxC.Size = new System.Drawing.Size(97, 100);
            this.pictureBoxC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxC.TabIndex = 7;
            this.pictureBoxC.TabStop = false;
            // 
            // An
            // 
            this.An.Image = ((System.Drawing.Image)(resources.GetObject("An.Image")));
            this.An.Location = new System.Drawing.Point(741, 346);
            this.An.Name = "An";
            this.An.Size = new System.Drawing.Size(200, 197);
            this.An.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.An.TabIndex = 8;
            this.An.TabStop = false;
            // 
            // Iw
            // 
            this.Iw.Image = ((System.Drawing.Image)(resources.GetObject("Iw.Image")));
            this.Iw.Location = new System.Drawing.Point(494, 103);
            this.Iw.Name = "Iw";
            this.Iw.Size = new System.Drawing.Size(150, 49);
            this.Iw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Iw.TabIndex = 9;
            this.Iw.TabStop = false;
            // 
            // EsaS
            // 
            this.EsaS.Image = ((System.Drawing.Image)(resources.GetObject("EsaS.Image")));
            this.EsaS.Location = new System.Drawing.Point(363, 102);
            this.EsaS.Name = "EsaS";
            this.EsaS.Size = new System.Drawing.Size(21, 50);
            this.EsaS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.EsaS.TabIndex = 10;
            this.EsaS.TabStop = false;
            this.EsaS.Click += new System.EventHandler(this.pictureBoxEsaS_Click);
            // 
            // EsaM
            // 
            this.EsaM.Image = ((System.Drawing.Image)(resources.GetObject("EsaM.Image")));
            this.EsaM.Location = new System.Drawing.Point(1139, 427);
            this.EsaM.Name = "EsaM";
            this.EsaM.Size = new System.Drawing.Size(31, 75);
            this.EsaM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.EsaM.TabIndex = 11;
            this.EsaM.TabStop = false;
            // 
            // EsaL
            // 
            this.EsaL.Image = ((System.Drawing.Image)(resources.GetObject("EsaL.Image")));
            this.EsaL.Location = new System.Drawing.Point(646, 255);
            this.EsaL.Name = "EsaL";
            this.EsaL.Size = new System.Drawing.Size(42, 100);
            this.EsaL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.EsaL.TabIndex = 12;
            this.EsaL.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(1182, 610);
            this.Controls.Add(this.EsaL);
            this.Controls.Add(this.EsaM);
            this.Controls.Add(this.EsaS);
            this.Controls.Add(this.Iw);
            this.Controls.Add(this.An);
            this.Controls.Add(this.pictureBoxC);
            this.Controls.Add(this.pictureBoxB);
            this.Controls.Add(this.Utu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDone);
            ((System.ComponentModel.ISupportInitialize)(this.Utu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.An)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Iw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EsaS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EsaM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EsaL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox Utu;
        private System.Windows.Forms.PictureBox pictureBoxB;
        private System.Windows.Forms.PictureBox pictureBoxC;
        private System.Windows.Forms.PictureBox An;
        private System.Windows.Forms.PictureBox Iw;
        private System.Windows.Forms.PictureBox EsaS;
        private System.Windows.Forms.PictureBox EsaM;
        private System.Windows.Forms.PictureBox EsaL;
        private System.Windows.Forms.Timer timer2;
    }
}

