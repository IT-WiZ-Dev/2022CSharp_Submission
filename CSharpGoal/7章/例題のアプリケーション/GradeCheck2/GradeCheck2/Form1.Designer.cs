namespace GradeCheck2
{
    partial class FormGrade
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
            this.labelTotalE = new System.Windows.Forms.Label();
            this.labelTotalP = new System.Windows.Forms.Label();
            this.labelTotalM = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonJudge = new System.Windows.Forms.Button();
            this.textBoxScoreE = new System.Windows.Forms.TextBox();
            this.textBoxAttendanceE = new System.Windows.Forms.TextBox();
            this.textBoxScoreP = new System.Windows.Forms.TextBox();
            this.textBoxScoreM = new System.Windows.Forms.TextBox();
            this.textBoxAttendanceP = new System.Windows.Forms.TextBox();
            this.textBoxAttendanceM = new System.Windows.Forms.TextBox();
            this.labelCompAvgE = new System.Windows.Forms.Label();
            this.labelCompAvgP = new System.Windows.Forms.Label();
            this.labelCompAvgM = new System.Windows.Forms.Label();
            this.labelResultE = new System.Windows.Forms.Label();
            this.labelResultP = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelResultM = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelPassScoreE = new System.Windows.Forms.Label();
            this.labelPassScoreP = new System.Windows.Forms.Label();
            this.labelAverageE = new System.Windows.Forms.Label();
            this.labelAverageP = new System.Windows.Forms.Label();
            this.labelAverageM = new System.Windows.Forms.Label();
            this.labelPassScoreM = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTotalE
            // 
            this.labelTotalE.AutoSize = true;
            this.labelTotalE.Location = new System.Drawing.Point(223, 179);
            this.labelTotalE.Name = "labelTotalE";
            this.labelTotalE.Size = new System.Drawing.Size(33, 12);
            this.labelTotalE.TabIndex = 23;
            this.labelTotalE.Text = "/ 100";
            // 
            // labelTotalP
            // 
            this.labelTotalP.AutoSize = true;
            this.labelTotalP.Location = new System.Drawing.Point(223, 133);
            this.labelTotalP.Name = "labelTotalP";
            this.labelTotalP.Size = new System.Drawing.Size(33, 12);
            this.labelTotalP.TabIndex = 22;
            this.labelTotalP.Text = "/ 100";
            // 
            // labelTotalM
            // 
            this.labelTotalM.AutoSize = true;
            this.labelTotalM.Location = new System.Drawing.Point(223, 87);
            this.labelTotalM.Name = "labelTotalM";
            this.labelTotalM.Size = new System.Drawing.Size(33, 12);
            this.labelTotalM.TabIndex = 21;
            this.labelTotalM.Text = "/ 100";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(79, 16);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 19);
            this.textBoxName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "氏名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "出席時数";
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(232, 233);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 8;
            this.buttonReset.Text = "リセット";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // buttonJudge
            // 
            this.buttonJudge.Location = new System.Drawing.Point(142, 233);
            this.buttonJudge.Name = "buttonJudge";
            this.buttonJudge.Size = new System.Drawing.Size(75, 23);
            this.buttonJudge.TabIndex = 7;
            this.buttonJudge.Text = "判定";
            this.buttonJudge.UseVisualStyleBackColor = true;
            this.buttonJudge.Click += new System.EventHandler(this.ButtonJudge_Click);
            // 
            // textBoxScoreE
            // 
            this.textBoxScoreE.Location = new System.Drawing.Point(79, 176);
            this.textBoxScoreE.Name = "textBoxScoreE";
            this.textBoxScoreE.Size = new System.Drawing.Size(67, 19);
            this.textBoxScoreE.TabIndex = 5;
            this.textBoxScoreE.Text = "0";
            this.textBoxScoreE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxAttendanceE
            // 
            this.textBoxAttendanceE.Location = new System.Drawing.Point(166, 176);
            this.textBoxAttendanceE.Name = "textBoxAttendanceE";
            this.textBoxAttendanceE.Size = new System.Drawing.Size(51, 19);
            this.textBoxAttendanceE.TabIndex = 6;
            this.textBoxAttendanceE.Text = "0";
            this.textBoxAttendanceE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxScoreP
            // 
            this.textBoxScoreP.Location = new System.Drawing.Point(79, 130);
            this.textBoxScoreP.Name = "textBoxScoreP";
            this.textBoxScoreP.Size = new System.Drawing.Size(67, 19);
            this.textBoxScoreP.TabIndex = 3;
            this.textBoxScoreP.Text = "0";
            this.textBoxScoreP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxScoreM
            // 
            this.textBoxScoreM.Location = new System.Drawing.Point(79, 84);
            this.textBoxScoreM.Name = "textBoxScoreM";
            this.textBoxScoreM.Size = new System.Drawing.Size(67, 19);
            this.textBoxScoreM.TabIndex = 1;
            this.textBoxScoreM.Text = "0";
            this.textBoxScoreM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxAttendanceP
            // 
            this.textBoxAttendanceP.Location = new System.Drawing.Point(166, 130);
            this.textBoxAttendanceP.Name = "textBoxAttendanceP";
            this.textBoxAttendanceP.Size = new System.Drawing.Size(51, 19);
            this.textBoxAttendanceP.TabIndex = 4;
            this.textBoxAttendanceP.Text = "0";
            this.textBoxAttendanceP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxAttendanceM
            // 
            this.textBoxAttendanceM.Location = new System.Drawing.Point(166, 84);
            this.textBoxAttendanceM.Name = "textBoxAttendanceM";
            this.textBoxAttendanceM.Size = new System.Drawing.Size(51, 19);
            this.textBoxAttendanceM.TabIndex = 2;
            this.textBoxAttendanceM.Text = "0";
            this.textBoxAttendanceM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelCompAvgE
            // 
            this.labelCompAvgE.AutoSize = true;
            this.labelCompAvgE.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelCompAvgE.Location = new System.Drawing.Point(451, 179);
            this.labelCompAvgE.Name = "labelCompAvgE";
            this.labelCompAvgE.Size = new System.Drawing.Size(93, 16);
            this.labelCompAvgE.TabIndex = 35;
            this.labelCompAvgE.Text = "平均点以上";
            // 
            // labelCompAvgP
            // 
            this.labelCompAvgP.AutoSize = true;
            this.labelCompAvgP.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelCompAvgP.Location = new System.Drawing.Point(451, 133);
            this.labelCompAvgP.Name = "labelCompAvgP";
            this.labelCompAvgP.Size = new System.Drawing.Size(93, 16);
            this.labelCompAvgP.TabIndex = 31;
            this.labelCompAvgP.Text = "平均点以上";
            // 
            // labelCompAvgM
            // 
            this.labelCompAvgM.AutoSize = true;
            this.labelCompAvgM.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelCompAvgM.Location = new System.Drawing.Point(451, 87);
            this.labelCompAvgM.Name = "labelCompAvgM";
            this.labelCompAvgM.Size = new System.Drawing.Size(93, 16);
            this.labelCompAvgM.TabIndex = 27;
            this.labelCompAvgM.Text = "平均点以上";
            // 
            // labelResultE
            // 
            this.labelResultE.AutoSize = true;
            this.labelResultE.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelResultE.Location = new System.Drawing.Point(387, 179);
            this.labelResultE.Name = "labelResultE";
            this.labelResultE.Size = new System.Drawing.Size(42, 16);
            this.labelResultE.TabIndex = 34;
            this.labelResultE.Text = "合格";
            // 
            // labelResultP
            // 
            this.labelResultP.AutoSize = true;
            this.labelResultP.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelResultP.Location = new System.Drawing.Point(387, 133);
            this.labelResultP.Name = "labelResultP";
            this.labelResultP.Size = new System.Drawing.Size(42, 16);
            this.labelResultP.TabIndex = 30;
            this.labelResultP.Text = "合格";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelName.Location = new System.Drawing.Point(387, 15);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(116, 16);
            this.labelName.TabIndex = 10;
            this.labelName.Text = "○○さんの成績";
            // 
            // labelResultM
            // 
            this.labelResultM.AutoSize = true;
            this.labelResultM.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelResultM.Location = new System.Drawing.Point(387, 87);
            this.labelResultM.Name = "labelResultM";
            this.labelResultM.Size = new System.Drawing.Size(42, 16);
            this.labelResultM.TabIndex = 26;
            this.labelResultM.Text = "合格";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 179);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 20;
            this.label11.Text = "英語";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 19;
            this.label10.Text = "物理";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 18;
            this.label9.Text = "数学";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(451, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 12);
            this.label8.TabIndex = 17;
            this.label8.Text = "平均点と比較";
            // 
            // labelPassScoreE
            // 
            this.labelPassScoreE.AutoSize = true;
            this.labelPassScoreE.Location = new System.Drawing.Point(284, 179);
            this.labelPassScoreE.Name = "labelPassScoreE";
            this.labelPassScoreE.Size = new System.Drawing.Size(23, 12);
            this.labelPassScoreE.TabIndex = 32;
            this.labelPassScoreE.Text = "100";
            // 
            // labelPassScoreP
            // 
            this.labelPassScoreP.AutoSize = true;
            this.labelPassScoreP.Location = new System.Drawing.Point(284, 133);
            this.labelPassScoreP.Name = "labelPassScoreP";
            this.labelPassScoreP.Size = new System.Drawing.Size(23, 12);
            this.labelPassScoreP.TabIndex = 28;
            this.labelPassScoreP.Text = "100";
            // 
            // labelAverageE
            // 
            this.labelAverageE.AutoSize = true;
            this.labelAverageE.Location = new System.Drawing.Point(331, 179);
            this.labelAverageE.Name = "labelAverageE";
            this.labelAverageE.Size = new System.Drawing.Size(23, 12);
            this.labelAverageE.TabIndex = 33;
            this.labelAverageE.Text = "100";
            // 
            // labelAverageP
            // 
            this.labelAverageP.AutoSize = true;
            this.labelAverageP.Location = new System.Drawing.Point(331, 133);
            this.labelAverageP.Name = "labelAverageP";
            this.labelAverageP.Size = new System.Drawing.Size(23, 12);
            this.labelAverageP.TabIndex = 29;
            this.labelAverageP.Text = "100";
            // 
            // labelAverageM
            // 
            this.labelAverageM.AutoSize = true;
            this.labelAverageM.Location = new System.Drawing.Point(331, 87);
            this.labelAverageM.Name = "labelAverageM";
            this.labelAverageM.Size = new System.Drawing.Size(23, 12);
            this.labelAverageM.TabIndex = 25;
            this.labelAverageM.Text = "100";
            // 
            // labelPassScoreM
            // 
            this.labelPassScoreM.AutoSize = true;
            this.labelPassScoreM.Location = new System.Drawing.Point(284, 87);
            this.labelPassScoreM.Name = "labelPassScoreM";
            this.labelPassScoreM.Size = new System.Drawing.Size(23, 12);
            this.labelPassScoreM.TabIndex = 24;
            this.labelPassScoreM.Text = "100";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(325, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 15;
            this.label6.Text = "平均点";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(278, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "合格点";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(387, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 16;
            this.label7.Text = "合否判定";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "得点";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "科目";
            // 
            // FormGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 273);
            this.Controls.Add(this.labelTotalE);
            this.Controls.Add(this.labelTotalP);
            this.Controls.Add(this.labelTotalM);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonJudge);
            this.Controls.Add(this.textBoxScoreE);
            this.Controls.Add(this.textBoxAttendanceE);
            this.Controls.Add(this.textBoxScoreP);
            this.Controls.Add(this.textBoxScoreM);
            this.Controls.Add(this.textBoxAttendanceP);
            this.Controls.Add(this.textBoxAttendanceM);
            this.Controls.Add(this.labelCompAvgE);
            this.Controls.Add(this.labelCompAvgP);
            this.Controls.Add(this.labelCompAvgM);
            this.Controls.Add(this.labelResultE);
            this.Controls.Add(this.labelResultP);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelResultM);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelPassScoreE);
            this.Controls.Add(this.labelPassScoreP);
            this.Controls.Add(this.labelAverageE);
            this.Controls.Add(this.labelAverageP);
            this.Controls.Add(this.labelAverageM);
            this.Controls.Add(this.labelPassScoreM);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Name = "FormGrade";
            this.Text = "成績判定";
            this.Load += new System.EventHandler(this.FormGrade_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTotalE;
        private System.Windows.Forms.Label labelTotalP;
        private System.Windows.Forms.Label labelTotalM;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonJudge;
        private System.Windows.Forms.TextBox textBoxScoreE;
        private System.Windows.Forms.TextBox textBoxAttendanceE;
        private System.Windows.Forms.TextBox textBoxScoreP;
        private System.Windows.Forms.TextBox textBoxScoreM;
        private System.Windows.Forms.TextBox textBoxAttendanceP;
        private System.Windows.Forms.TextBox textBoxAttendanceM;
        private System.Windows.Forms.Label labelCompAvgE;
        private System.Windows.Forms.Label labelCompAvgP;
        private System.Windows.Forms.Label labelCompAvgM;
        private System.Windows.Forms.Label labelResultE;
        private System.Windows.Forms.Label labelResultP;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelResultM;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelPassScoreE;
        private System.Windows.Forms.Label labelPassScoreP;
        private System.Windows.Forms.Label labelAverageE;
        private System.Windows.Forms.Label labelAverageP;
        private System.Windows.Forms.Label labelAverageM;
        private System.Windows.Forms.Label labelPassScoreM;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}

