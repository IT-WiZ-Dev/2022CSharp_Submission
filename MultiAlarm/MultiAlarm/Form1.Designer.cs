
namespace MultiAlarm
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AlarmDialog = new System.Windows.Forms.NumericUpDown();
            this.AlarmDialog２ = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AlarmDialog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlarmDialog２)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "時";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "分";
            // 
            // AlarmDialog
            // 
            this.AlarmDialog.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.AlarmDialog.Location = new System.Drawing.Point(240, 64);
            this.AlarmDialog.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.AlarmDialog.Name = "AlarmDialog";
            this.AlarmDialog.Size = new System.Drawing.Size(120, 25);
            this.AlarmDialog.TabIndex = 2;
            // 
            // AlarmDialog２
            // 
            this.AlarmDialog２.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.AlarmDialog２.Location = new System.Drawing.Point(240, 129);
            this.AlarmDialog２.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.AlarmDialog２.Name = "AlarmDialog２";
            this.AlarmDialog２.Size = new System.Drawing.Size(120, 25);
            this.AlarmDialog２.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(240, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(240, 246);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 34);
            this.button2.TabIndex = 5;
            this.button2.Text = "キャンセル";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AlarmDialog２);
            this.Controls.Add(this.AlarmDialog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = resources.GetString("$this.Text");
            ((System.ComponentModel.ISupportInitialize)(this.AlarmDialog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlarmDialog２)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown AlarmDialog;
        private System.Windows.Forms.NumericUpDown AlarmDialog２;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

