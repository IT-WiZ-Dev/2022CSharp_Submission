
namespace Rescue
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
            this.labelNotice = new System.Windows.Forms.Label();
            this.pictureBoxMotorcycle = new System.Windows.Forms.PictureBox();
            this.pictureBoxAmbulance = new System.Windows.Forms.PictureBox();
            this.pictureBoxHelicopter = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMotorcycle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAmbulance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHelicopter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(34, 23);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(100, 35);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "スタート";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelNotice
            // 
            this.labelNotice.AutoSize = true;
            this.labelNotice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelNotice.ForeColor = System.Drawing.Color.Red;
            this.labelNotice.Location = new System.Drawing.Point(156, 31);
            this.labelNotice.Name = "labelNotice";
            this.labelNotice.Size = new System.Drawing.Size(59, 20);
            this.labelNotice.TabIndex = 1;
            this.labelNotice.Text = "label1";
            // 
            // pictureBoxMotorcycle
            // 
            this.pictureBoxMotorcycle.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMotorcycle.Image")));
            this.pictureBoxMotorcycle.Location = new System.Drawing.Point(9, 341);
            this.pictureBoxMotorcycle.Name = "pictureBoxMotorcycle";
            this.pictureBoxMotorcycle.Size = new System.Drawing.Size(100, 91);
            this.pictureBoxMotorcycle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxMotorcycle.TabIndex = 2;
            this.pictureBoxMotorcycle.TabStop = false;
            // 
            // pictureBoxAmbulance
            // 
            this.pictureBoxAmbulance.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAmbulance.Image")));
            this.pictureBoxAmbulance.Location = new System.Drawing.Point(9, 352);
            this.pictureBoxAmbulance.Name = "pictureBoxAmbulance";
            this.pictureBoxAmbulance.Size = new System.Drawing.Size(100, 79);
            this.pictureBoxAmbulance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxAmbulance.TabIndex = 3;
            this.pictureBoxAmbulance.TabStop = false;
            // 
            // pictureBoxHelicopter
            // 
            this.pictureBoxHelicopter.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxHelicopter.Image")));
            this.pictureBoxHelicopter.Location = new System.Drawing.Point(9, 352);
            this.pictureBoxHelicopter.Name = "pictureBoxHelicopter";
            this.pictureBoxHelicopter.Size = new System.Drawing.Size(100, 79);
            this.pictureBoxHelicopter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxHelicopter.TabIndex = 4;
            this.pictureBoxHelicopter.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(913, 281);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormGame
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1078, 444);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBoxHelicopter);
            this.Controls.Add(this.pictureBoxAmbulance);
            this.Controls.Add(this.pictureBoxMotorcycle);
            this.Controls.Add(this.labelNotice);
            this.Controls.Add(this.buttonStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormGame";
            this.Text = "レスキュー";
            this.Load += new System.EventHandler(this.FormGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMotorcycle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAmbulance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHelicopter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelNotice;
        private System.Windows.Forms.PictureBox pictureBoxMotorcycle;
        private System.Windows.Forms.PictureBox pictureBoxAmbulance;
        private System.Windows.Forms.PictureBox pictureBoxHelicopter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}

