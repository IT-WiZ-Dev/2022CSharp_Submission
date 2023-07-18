
using System;

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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxScoreM = new System.Windows.Forms.TextBox();
            this.textBoxScoreP = new System.Windows.Forms.TextBox();
            this.textBoxScoreE = new System.Windows.Forms.TextBox();
            this.textBoxAttendanceM = new System.Windows.Forms.TextBox();
            this.textBoxAttendanceP = new System.Windows.Forms.TextBox();
            this.textBoxAttendanceE = new System.Windows.Forms.TextBox();
            this.labelTotalM = new System.Windows.Forms.Label();
            this.labelTotalP = new System.Windows.Forms.Label();
            this.labelTotalE = new System.Windows.Forms.Label();
            this.labelPassScoreM = new System.Windows.Forms.Label();
            this.labelPassScoreP = new System.Windows.Forms.Label();
            this.labelPassScoreE = new System.Windows.Forms.Label();
            this.labelAverageM = new System.Windows.Forms.Label();
            this.labelAverageP = new System.Windows.Forms.Label();
            this.labelAverageE = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelResultM = new System.Windows.Forms.Label();
            this.labelResultP = new System.Windows.Forms.Label();
            this.labelResultE = new System.Windows.Forms.Label();
            this.labelCompAvgM = new System.Windows.Forms.Label();
            this.labelCompAvgP = new System.Windows.Forms.Label();
            this.labelCompAvgE = new System.Windows.Forms.Label();
            this.buttonJudge = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(61, 34);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(167, 25);
            this.textBoxName.TabIndex = 0;
            // 
            // textBoxScoreM
            // 
            this.textBoxScoreM.Location = new System.Drawing.Point(93, 111);
            this.textBoxScoreM.Name = "textBoxScoreM";
            this.textBoxScoreM.Size = new System.Drawing.Size(100, 25);
            this.textBoxScoreM.TabIndex = 1;
            this.textBoxScoreM.Text = "0";
            this.textBoxScoreM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxScoreP
            // 
            this.textBoxScoreP.Location = new System.Drawing.Point(93, 165);
            this.textBoxScoreP.Name = "textBoxScoreP";
            this.textBoxScoreP.Size = new System.Drawing.Size(100, 25);
            this.textBoxScoreP.TabIndex = 2;
            this.textBoxScoreP.Text = "0";
            this.textBoxScoreP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxScoreE
            // 
            this.textBoxScoreE.Location = new System.Drawing.Point(93, 238);
            this.textBoxScoreE.Name = "textBoxScoreE";
            this.textBoxScoreE.Size = new System.Drawing.Size(100, 25);
            this.textBoxScoreE.TabIndex = 3;
            this.textBoxScoreE.Text = "0";
            this.textBoxScoreE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxAttendanceM
            // 
            this.textBoxAttendanceM.Location = new System.Drawing.Point(234, 108);
            this.textBoxAttendanceM.Name = "textBoxAttendanceM";
            this.textBoxAttendanceM.Size = new System.Drawing.Size(100, 25);
            this.textBoxAttendanceM.TabIndex = 4;
            this.textBoxAttendanceM.Text = "0";
            this.textBoxAttendanceM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxAttendanceP
            // 
            this.textBoxAttendanceP.Location = new System.Drawing.Point(234, 165);
            this.textBoxAttendanceP.Name = "textBoxAttendanceP";
            this.textBoxAttendanceP.Size = new System.Drawing.Size(100, 25);
            this.textBoxAttendanceP.TabIndex = 5;
            this.textBoxAttendanceP.Text = "0";
            this.textBoxAttendanceP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxAttendanceE
            // 
            this.textBoxAttendanceE.Location = new System.Drawing.Point(234, 238);
            this.textBoxAttendanceE.Name = "textBoxAttendanceE";
            this.textBoxAttendanceE.Size = new System.Drawing.Size(100, 25);
            this.textBoxAttendanceE.TabIndex = 6;
            this.textBoxAttendanceE.Text = "0";
            this.textBoxAttendanceE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelTotalM
            // 
            this.labelTotalM.AutoSize = true;
            this.labelTotalM.Location = new System.Drawing.Point(358, 114);
            this.labelTotalM.Name = "labelTotalM";
            this.labelTotalM.Size = new System.Drawing.Size(44, 18);
            this.labelTotalM.TabIndex = 7;
            this.labelTotalM.Text = "/100";
            // 
            // labelTotalP
            // 
            this.labelTotalP.AutoSize = true;
            this.labelTotalP.Location = new System.Drawing.Point(358, 179);
            this.labelTotalP.Name = "labelTotalP";
            this.labelTotalP.Size = new System.Drawing.Size(44, 18);
            this.labelTotalP.TabIndex = 8;
            this.labelTotalP.Text = "/100";
            // 
            // labelTotalE
            // 
            this.labelTotalE.AutoSize = true;
            this.labelTotalE.Location = new System.Drawing.Point(358, 248);
            this.labelTotalE.Name = "labelTotalE";
            this.labelTotalE.Size = new System.Drawing.Size(44, 18);
            this.labelTotalE.TabIndex = 9;
            this.labelTotalE.Text = "/100";
            // 
            // labelPassScoreM
            // 
            this.labelPassScoreM.AutoSize = true;
            this.labelPassScoreM.Location = new System.Drawing.Point(456, 111);
            this.labelPassScoreM.Name = "labelPassScoreM";
            this.labelPassScoreM.Size = new System.Drawing.Size(35, 18);
            this.labelPassScoreM.TabIndex = 10;
            this.labelPassScoreM.Text = "100";
            // 
            // labelPassScoreP
            // 
            this.labelPassScoreP.AutoSize = true;
            this.labelPassScoreP.Location = new System.Drawing.Point(456, 172);
            this.labelPassScoreP.Name = "labelPassScoreP";
            this.labelPassScoreP.Size = new System.Drawing.Size(35, 18);
            this.labelPassScoreP.TabIndex = 11;
            this.labelPassScoreP.Text = "100";
            // 
            // labelPassScoreE
            // 
            this.labelPassScoreE.AutoSize = true;
            this.labelPassScoreE.Location = new System.Drawing.Point(456, 248);
            this.labelPassScoreE.Name = "labelPassScoreE";
            this.labelPassScoreE.Size = new System.Drawing.Size(35, 18);
            this.labelPassScoreE.TabIndex = 12;
            this.labelPassScoreE.Text = "100";
            // 
            // labelAverageM
            // 
            this.labelAverageM.AutoSize = true;
            this.labelAverageM.Location = new System.Drawing.Point(553, 111);
            this.labelAverageM.Name = "labelAverageM";
            this.labelAverageM.Size = new System.Drawing.Size(35, 18);
            this.labelAverageM.TabIndex = 13;
            this.labelAverageM.Text = "100";
            // 
            // labelAverageP
            // 
            this.labelAverageP.AutoSize = true;
            this.labelAverageP.Location = new System.Drawing.Point(553, 172);
            this.labelAverageP.Name = "labelAverageP";
            this.labelAverageP.Size = new System.Drawing.Size(35, 18);
            this.labelAverageP.TabIndex = 14;
            this.labelAverageP.Text = "100";
            // 
            // labelAverageE
            // 
            this.labelAverageE.AutoSize = true;
            this.labelAverageE.Location = new System.Drawing.Point(553, 245);
            this.labelAverageE.Name = "labelAverageE";
            this.labelAverageE.Size = new System.Drawing.Size(35, 18);
            this.labelAverageE.TabIndex = 15;
            this.labelAverageE.Text = "100";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelName.Location = new System.Drawing.Point(665, 23);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(124, 20);
            this.labelName.TabIndex = 16;
            this.labelName.Text = "〇〇さんの成績";
            // 
            // labelResultM
            // 
            this.labelResultM.AutoSize = true;
            this.labelResultM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelResultM.Location = new System.Drawing.Point(665, 114);
            this.labelResultM.Name = "labelResultM";
            this.labelResultM.Size = new System.Drawing.Size(45, 20);
            this.labelResultM.TabIndex = 17;
            this.labelResultM.Text = "合格";
            // 
            // labelResultP
            // 
            this.labelResultP.AutoSize = true;
            this.labelResultP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelResultP.Location = new System.Drawing.Point(665, 169);
            this.labelResultP.Name = "labelResultP";
            this.labelResultP.Size = new System.Drawing.Size(45, 20);
            this.labelResultP.TabIndex = 18;
            this.labelResultP.Text = "合格";
            // 
            // labelResultE
            // 
            this.labelResultE.AutoSize = true;
            this.labelResultE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelResultE.Location = new System.Drawing.Point(665, 245);
            this.labelResultE.Name = "labelResultE";
            this.labelResultE.Size = new System.Drawing.Size(45, 20);
            this.labelResultE.TabIndex = 19;
            this.labelResultE.Text = "合格";
            // 
            // labelCompAvgM
            // 
            this.labelCompAvgM.AutoSize = true;
            this.labelCompAvgM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelCompAvgM.Location = new System.Drawing.Point(773, 111);
            this.labelCompAvgM.Name = "labelCompAvgM";
            this.labelCompAvgM.Size = new System.Drawing.Size(99, 20);
            this.labelCompAvgM.TabIndex = 20;
            this.labelCompAvgM.Text = "平均点以上";
            // 
            // labelCompAvgP
            // 
            this.labelCompAvgP.AutoSize = true;
            this.labelCompAvgP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelCompAvgP.Location = new System.Drawing.Point(773, 176);
            this.labelCompAvgP.Name = "labelCompAvgP";
            this.labelCompAvgP.Size = new System.Drawing.Size(99, 20);
            this.labelCompAvgP.TabIndex = 21;
            this.labelCompAvgP.Text = "平均点以上";
            // 
            // labelCompAvgE
            // 
            this.labelCompAvgE.AutoSize = true;
            this.labelCompAvgE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelCompAvgE.Location = new System.Drawing.Point(773, 248);
            this.labelCompAvgE.Name = "labelCompAvgE";
            this.labelCompAvgE.Size = new System.Drawing.Size(99, 20);
            this.labelCompAvgE.TabIndex = 22;
            this.labelCompAvgE.Text = "平均点以上";
            // 
            // buttonJudge
            // 
            this.buttonJudge.Location = new System.Drawing.Point(234, 317);
            this.buttonJudge.Name = "buttonJudge";
            this.buttonJudge.Size = new System.Drawing.Size(100, 33);
            this.buttonJudge.TabIndex = 23;
            this.buttonJudge.Text = "判定";
            this.buttonJudge.UseVisualStyleBackColor = true;
            this.buttonJudge.Click += new System.EventHandler(this.buttonJudge_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(361, 317);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(101, 33);
            this.buttonReset.TabIndex = 24;
            this.buttonReset.Text = "リセット";
            this.buttonReset.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(11, 34);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 18);
            this.label17.TabIndex = 25;
            this.label17.Text = "氏名";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 238);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(44, 18);
            this.label18.TabIndex = 26;
            this.label18.Text = "英語";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(12, 172);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(44, 18);
            this.label19.TabIndex = 27;
            this.label19.Text = "物理";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(12, 114);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(44, 18);
            this.label20.TabIndex = 28;
            this.label20.Text = "数学";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(773, 80);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(109, 18);
            this.label21.TabIndex = 29;
            this.label21.Text = "平均点と比較";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(665, 80);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(80, 18);
            this.label22.TabIndex = 30;
            this.label22.Text = "合否判定";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(553, 74);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(62, 18);
            this.label23.TabIndex = 31;
            this.label23.Text = "平均点";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(471, 74);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(62, 18);
            this.label24.TabIndex = 32;
            this.label24.Text = "合格点";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(254, 74);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(80, 18);
            this.label25.TabIndex = 33;
            this.label25.Text = "出席時数";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(90, 74);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(44, 18);
            this.label26.TabIndex = 34;
            this.label26.Text = "得点";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(12, 74);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(44, 18);
            this.label27.TabIndex = 35;
            this.label27.Text = "科目";
            // 
            // FormGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 379);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonJudge);
            this.Controls.Add(this.labelCompAvgE);
            this.Controls.Add(this.labelCompAvgP);
            this.Controls.Add(this.labelCompAvgM);
            this.Controls.Add(this.labelResultE);
            this.Controls.Add(this.labelResultP);
            this.Controls.Add(this.labelResultM);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelAverageE);
            this.Controls.Add(this.labelAverageP);
            this.Controls.Add(this.labelAverageM);
            this.Controls.Add(this.labelPassScoreE);
            this.Controls.Add(this.labelPassScoreP);
            this.Controls.Add(this.labelPassScoreM);
            this.Controls.Add(this.labelTotalE);
            this.Controls.Add(this.labelTotalP);
            this.Controls.Add(this.labelTotalM);
            this.Controls.Add(this.textBoxAttendanceE);
            this.Controls.Add(this.textBoxAttendanceP);
            this.Controls.Add(this.textBoxAttendanceM);
            this.Controls.Add(this.textBoxScoreE);
            this.Controls.Add(this.textBoxScoreP);
            this.Controls.Add(this.textBoxScoreM);
            this.Controls.Add(this.textBoxName);
            this.Name = "FormGrade";
            this.Text = "成績判定";
            this.Load += new System.EventHandler(this.FormGrade_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void FormGrade_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxScoreM;
        private System.Windows.Forms.TextBox textBoxScoreP;
        private System.Windows.Forms.TextBox textBoxScoreE;
        private System.Windows.Forms.TextBox textBoxAttendanceM;
        private System.Windows.Forms.TextBox textBoxAttendanceP;
        private System.Windows.Forms.TextBox textBoxAttendanceE;
        private System.Windows.Forms.Label labelTotalM;
        private System.Windows.Forms.Label labelTotalP;
        private System.Windows.Forms.Label labelTotalE;
        private System.Windows.Forms.Label labelPassScoreM;
        private System.Windows.Forms.Label labelPassScoreP;
        private System.Windows.Forms.Label labelPassScoreE;
        private System.Windows.Forms.Label labelAverageM;
        private System.Windows.Forms.Label labelAverageP;
        private System.Windows.Forms.Label labelAverageE;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelResultM;
        private System.Windows.Forms.Label labelResultP;
        private System.Windows.Forms.Label labelResultE;
        private System.Windows.Forms.Label labelCompAvgM;
        private System.Windows.Forms.Label labelCompAvgP;
        private System.Windows.Forms.Label labelCompAvgE;
        private System.Windows.Forms.Button buttonJudge;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
    }
}

