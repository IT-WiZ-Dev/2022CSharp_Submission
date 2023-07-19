namespace CardsWar
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
            this.buttonRestart = new System.Windows.Forms.Button();
            this.labelGuidance = new System.Windows.Forms.Label();
            this.labelUserScore = new System.Windows.Forms.Label();
            this.labelComScore = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonRestart
            // 
            this.buttonRestart.Location = new System.Drawing.Point(375, 373);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(75, 23);
            this.buttonRestart.TabIndex = 17;
            this.buttonRestart.Text = "再挑戦";
            this.buttonRestart.UseVisualStyleBackColor = true;
            this.buttonRestart.Click += new System.EventHandler(this.ButtonRestart_Click);
            // 
            // labelGuidance
            // 
            this.labelGuidance.AutoSize = true;
            this.labelGuidance.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelGuidance.ForeColor = System.Drawing.Color.Red;
            this.labelGuidance.Location = new System.Drawing.Point(129, 171);
            this.labelGuidance.Name = "labelGuidance";
            this.labelGuidance.Size = new System.Drawing.Size(52, 16);
            this.labelGuidance.TabIndex = 16;
            this.labelGuidance.Text = "label3";
            // 
            // labelUserScore
            // 
            this.labelUserScore.AutoSize = true;
            this.labelUserScore.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelUserScore.Location = new System.Drawing.Point(14, 270);
            this.labelUserScore.Name = "labelUserScore";
            this.labelUserScore.Size = new System.Drawing.Size(85, 19);
            this.labelUserScore.TabIndex = 15;
            this.labelUserScore.Text = "得点 ： 0";
            // 
            // labelComScore
            // 
            this.labelComScore.AutoSize = true;
            this.labelComScore.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelComScore.Location = new System.Drawing.Point(14, 60);
            this.labelComScore.Name = "labelComScore";
            this.labelComScore.Size = new System.Drawing.Size(85, 19);
            this.labelComScore.TabIndex = 13;
            this.labelComScore.Text = "得点 ： 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(12, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "あなた";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "コンピュータ";
            // 
            // FormGame
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(824, 411);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.labelGuidance);
            this.Controls.Add(this.labelUserScore);
            this.Controls.Add(this.labelComScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormGame";
            this.Text = "戦争ゲーム";
            this.Load += new System.EventHandler(this.FormGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.Label labelGuidance;
        private System.Windows.Forms.Label labelUserScore;
        private System.Windows.Forms.Label labelComScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

