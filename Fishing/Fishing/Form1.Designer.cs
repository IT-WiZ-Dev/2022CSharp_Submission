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
            this.startButton = new System.Windows.Forms.Button();
            this.remaHourLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.ankouPictureBox = new System.Windows.Forms.PictureBox();
            this.esaLPictureBox = new System.Windows.Forms.PictureBox();
            this.esaMPictureBox = new System.Windows.Forms.PictureBox();
            this.esaSPictureBox = new System.Windows.Forms.PictureBox();
            this.hitodePictureBox = new System.Windows.Forms.PictureBox();
            this.isoginchakuPictureBox = new System.Windows.Forms.PictureBox();
            this.iwashiPictureBox = new System.Windows.Forms.PictureBox();
            this.utuboPictureBox = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ankouPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.esaLPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.esaMPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.esaSPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hitodePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isoginchakuPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iwashiPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utuboPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.startButton.Location = new System.Drawing.Point(24, 27);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(96, 29);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "スタート";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // remaHourLabel
            // 
            this.remaHourLabel.AutoSize = true;
            this.remaHourLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.remaHourLabel.Location = new System.Drawing.Point(143, 36);
            this.remaHourLabel.Name = "remaHourLabel";
            this.remaHourLabel.Size = new System.Drawing.Size(140, 20);
            this.remaHourLabel.TabIndex = 1;
            this.remaHourLabel.Text = "残り時間：60秒";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.scoreLabel.Location = new System.Drawing.Point(317, 36);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(56, 20);
            this.scoreLabel.TabIndex = 2;
            this.scoreLabel.Text = "得点:";
            // 
            // ankouPictureBox
            // 
            this.ankouPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("ankouPictureBox.Image")));
            this.ankouPictureBox.Location = new System.Drawing.Point(637, 300);
            this.ankouPictureBox.Name = "ankouPictureBox";
            this.ankouPictureBox.Size = new System.Drawing.Size(200, 197);
            this.ankouPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ankouPictureBox.TabIndex = 3;
            this.ankouPictureBox.TabStop = false;
            // 
            // esaLPictureBox
            // 
            this.esaLPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("esaLPictureBox.Image")));
            this.esaLPictureBox.InitialImage = null;
            this.esaLPictureBox.Location = new System.Drawing.Point(519, 174);
            this.esaLPictureBox.Name = "esaLPictureBox";
            this.esaLPictureBox.Size = new System.Drawing.Size(42, 100);
            this.esaLPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.esaLPictureBox.TabIndex = 4;
            this.esaLPictureBox.TabStop = false;
            // 
            // esaMPictureBox
            // 
            this.esaMPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("esaMPictureBox.Image")));
            this.esaMPictureBox.InitialImage = null;
            this.esaMPictureBox.Location = new System.Drawing.Point(896, 408);
            this.esaMPictureBox.Name = "esaMPictureBox";
            this.esaMPictureBox.Size = new System.Drawing.Size(31, 75);
            this.esaMPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.esaMPictureBox.TabIndex = 5;
            this.esaMPictureBox.TabStop = false;
            // 
            // esaSPictureBox
            // 
            this.esaSPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("esaSPictureBox.Image")));
            this.esaSPictureBox.InitialImage = null;
            this.esaSPictureBox.Location = new System.Drawing.Point(262, 82);
            this.esaSPictureBox.Name = "esaSPictureBox";
            this.esaSPictureBox.Size = new System.Drawing.Size(21, 50);
            this.esaSPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.esaSPictureBox.TabIndex = 6;
            this.esaSPictureBox.TabStop = false;
            // 
            // hitodePictureBox
            // 
            this.hitodePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("hitodePictureBox.Image")));
            this.hitodePictureBox.InitialImage = null;
            this.hitodePictureBox.Location = new System.Drawing.Point(229, 408);
            this.hitodePictureBox.Name = "hitodePictureBox";
            this.hitodePictureBox.Size = new System.Drawing.Size(75, 75);
            this.hitodePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.hitodePictureBox.TabIndex = 7;
            this.hitodePictureBox.TabStop = false;
            // 
            // isoginchakuPictureBox
            // 
            this.isoginchakuPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("isoginchakuPictureBox.Image")));
            this.isoginchakuPictureBox.InitialImage = null;
            this.isoginchakuPictureBox.Location = new System.Drawing.Point(391, 383);
            this.isoginchakuPictureBox.Name = "isoginchakuPictureBox";
            this.isoginchakuPictureBox.Size = new System.Drawing.Size(97, 100);
            this.isoginchakuPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.isoginchakuPictureBox.TabIndex = 8;
            this.isoginchakuPictureBox.TabStop = false;
            // 
            // iwashiPictureBox
            // 
            this.iwashiPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("iwashiPictureBox.Image")));
            this.iwashiPictureBox.InitialImage = null;
            this.iwashiPictureBox.Location = new System.Drawing.Point(338, 83);
            this.iwashiPictureBox.Name = "iwashiPictureBox";
            this.iwashiPictureBox.Size = new System.Drawing.Size(150, 49);
            this.iwashiPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.iwashiPictureBox.TabIndex = 9;
            this.iwashiPictureBox.TabStop = false;
            // 
            // utuboPictureBox
            // 
            this.utuboPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("utuboPictureBox.Image")));
            this.utuboPictureBox.InitialImage = null;
            this.utuboPictureBox.Location = new System.Drawing.Point(-65, 138);
            this.utuboPictureBox.Name = "utuboPictureBox";
            this.utuboPictureBox.Size = new System.Drawing.Size(300, 172);
            this.utuboPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.utuboPictureBox.TabIndex = 10;
            this.utuboPictureBox.TabStop = false;
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 543);
            this.Controls.Add(this.utuboPictureBox);
            this.Controls.Add(this.iwashiPictureBox);
            this.Controls.Add(this.isoginchakuPictureBox);
            this.Controls.Add(this.hitodePictureBox);
            this.Controls.Add(this.esaSPictureBox);
            this.Controls.Add(this.esaMPictureBox);
            this.Controls.Add(this.esaLPictureBox);
            this.Controls.Add(this.ankouPictureBox);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.remaHourLabel);
            this.Controls.Add(this.startButton);
            this.Name = "FormGame";
            this.Text = "釣りゲーム";
            this.Load += new System.EventHandler(this.FormGame_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormGame_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.ankouPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.esaLPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.esaMPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.esaSPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hitodePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isoginchakuPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iwashiPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utuboPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label remaHourLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.PictureBox ankouPictureBox;
        private System.Windows.Forms.PictureBox esaLPictureBox;
        private System.Windows.Forms.PictureBox esaMPictureBox;
        private System.Windows.Forms.PictureBox esaSPictureBox;
        private System.Windows.Forms.PictureBox hitodePictureBox;
        private System.Windows.Forms.PictureBox isoginchakuPictureBox;
        private System.Windows.Forms.PictureBox iwashiPictureBox;
        private System.Windows.Forms.PictureBox utuboPictureBox;
        private System.Windows.Forms.Timer timer1;
    }
}

