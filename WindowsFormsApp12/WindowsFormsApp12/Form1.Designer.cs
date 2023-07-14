
namespace WindowsFormsApp12
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
            this.picture_Iwasi = new System.Windows.Forms.PictureBox();
            this.picture_Utubo = new System.Windows.Forms.PictureBox();
            this.picture_Anko = new System.Windows.Forms.PictureBox();
            this.button_Start = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.picture_esaM = new System.Windows.Forms.PictureBox();
            this.picture_esaL = new System.Windows.Forms.PictureBox();
            this.picture_esaS = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Iwasi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Utubo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Anko)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_esaM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_esaL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_esaS)).BeginInit();
            this.SuspendLayout();
            // 
            // picture_Iwasi
            // 
            this.picture_Iwasi.Image = ((System.Drawing.Image)(resources.GetObject("picture_Iwasi.Image")));
            this.picture_Iwasi.Location = new System.Drawing.Point(1, 97);
            this.picture_Iwasi.Name = "picture_Iwasi";
            this.picture_Iwasi.Size = new System.Drawing.Size(95, 33);
            this.picture_Iwasi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_Iwasi.TabIndex = 0;
            this.picture_Iwasi.TabStop = false;
            // 
            // picture_Utubo
            // 
            this.picture_Utubo.Image = ((System.Drawing.Image)(resources.GetObject("picture_Utubo.Image")));
            this.picture_Utubo.Location = new System.Drawing.Point(1, 187);
            this.picture_Utubo.Name = "picture_Utubo";
            this.picture_Utubo.Size = new System.Drawing.Size(214, 107);
            this.picture_Utubo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_Utubo.TabIndex = 1;
            this.picture_Utubo.TabStop = false;
            // 
            // picture_Anko
            // 
            this.picture_Anko.Image = ((System.Drawing.Image)(resources.GetObject("picture_Anko.Image")));
            this.picture_Anko.Location = new System.Drawing.Point(1, 397);
            this.picture_Anko.Name = "picture_Anko";
            this.picture_Anko.Size = new System.Drawing.Size(152, 141);
            this.picture_Anko.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_Anko.TabIndex = 2;
            this.picture_Anko.TabStop = false;
            // 
            // button_Start
            // 
            this.button_Start.Location = new System.Drawing.Point(28, 21);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(109, 23);
            this.button_Start.TabIndex = 3;
            this.button_Start.Text = "スタート";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // picture_esaM
            // 
            this.picture_esaM.Image = ((System.Drawing.Image)(resources.GetObject("picture_esaM.Image")));
            this.picture_esaM.Location = new System.Drawing.Point(626, 187);
            this.picture_esaM.Name = "picture_esaM";
            this.picture_esaM.Size = new System.Drawing.Size(39, 96);
            this.picture_esaM.TabIndex = 5;
            this.picture_esaM.TabStop = false;
            this.picture_esaM.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // picture_esaL
            // 
            this.picture_esaL.Image = ((System.Drawing.Image)(resources.GetObject("picture_esaL.Image")));
            this.picture_esaL.Location = new System.Drawing.Point(876, 410);
            this.picture_esaL.Name = "picture_esaL";
            this.picture_esaL.Size = new System.Drawing.Size(49, 109);
            this.picture_esaL.TabIndex = 6;
            this.picture_esaL.TabStop = false;
            // 
            // picture_esaS
            // 
            this.picture_esaS.Image = ((System.Drawing.Image)(resources.GetObject("picture_esaS.Image")));
            this.picture_esaS.Location = new System.Drawing.Point(397, 97);
            this.picture_esaS.Name = "picture_esaS";
            this.picture_esaS.Size = new System.Drawing.Size(26, 50);
            this.picture_esaS.TabIndex = 7;
            this.picture_esaS.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1054, 669);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picture_esaS);
            this.Controls.Add(this.picture_esaL);
            this.Controls.Add(this.picture_esaM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.picture_Anko);
            this.Controls.Add(this.picture_Utubo);
            this.Controls.Add(this.picture_Iwasi);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.picture_Iwasi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Utubo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Anko)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_esaM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_esaL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_esaS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture_Iwasi;
        private System.Windows.Forms.PictureBox picture_Utubo;
        private System.Windows.Forms.PictureBox picture_Anko;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picture_esaM;
        private System.Windows.Forms.PictureBox picture_esaL;
        private System.Windows.Forms.PictureBox picture_esaS;
        private System.Windows.Forms.Label label2;
    }
}

