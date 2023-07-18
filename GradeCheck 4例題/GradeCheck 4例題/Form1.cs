using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeCheck_4例題
{
    public partial class FormGrade : Form
    {
        public FormGrade()
        {
            InitializeComponent();
        }

        private void FormGrade_Load(object sender, EventArgs e)
        {
            labelResultM.Text = "";
            labelResultP.Text = "";
            labelResultE.Text = "";
            labelCompAvgM.Text = "";
            labelCompAvgP.Text = "";
            labelCompAvgE.Text = "";
        }

        //文字列を浮動小数点値に変換
        //(仮引数)text:変換する文字列 val:変換した浮動小数点値
        //(返却値)なし
        private void TextToValue(string text, out double val)
        {
            if (double.TryParse(text, out val) == false)
                val = -1.0;
        }

        //文字列を整数値に変換
        //(仮引数)text:変換する文字列 val:変換した整数値
        //(返却値)なし
        private void TextToValue(string text, out int val)
        {
            if (int.TryParse(text, out val) == false)
                val = -1;
        }

        //成績判定
        //(仮引数)attendance:出席率 score:得点
        //(返却値)判定結果
        private string ScoreJudge(double attendance, int score)
        {
            string result;

            if (attendance < 0.0 || attendance > 100.0 || score < 0 || score > 100)
                result = "エラー";
            else if (attendance >= 80.0)
            {
                if (score >= 80)
                    result = "A判定";
                else if (score >= 70)
                    result = "B判定";
                else if (score >= 60)
                    result = "C判定";
                else 
                    result = "不合格";
            }
            else
                result = "不合格";

            return result;
        }

        //平均点判定
        //(仮引数)score:得点 subject:科目
        //(返却値)判定結果
        private string AverageJudge(int score, string subject)
        {
            string result;
            int average;

            const int MathAverage = 73;       //数学の平均点
            const int PhysicalAverage = 65;　//物理の平均点
            const int EnglishAverage = 77;　//英語の平均点

            if (score < 0 || score > 100)
                return "エラー";

            switch (subject)
            {
                case "数学":
                    average = MathAverage;
                    break;
                case "物理":
                    average = PhysicalAverage;
                    break;
                case "英語":
                    average = EnglishAverage;
                    break;
                default:
                    return "エラー";
            }

            if (score >= average)
                result = "平均点以上";
            else
                result = "平均点未満";
            return result;
        }

        private void buttonJudge_Click(object sender, EventArgs e)
        {
            //出席率を浮動小数点値に変換
            double attendanceM, attendanceP, attendanceE;
            TextToValue(textBoxAttendanceM.Text, out attendanceM);
            TextToValue(textBoxAttendanceP.Text, out attendanceP);
            TextToValue(textBoxAttendanceE.Text, out attendanceE);

            //得点を整数値に変換
            int scoreM, scoreP, scoreE;
            TextToValue(textBoxScoreM.Text, out scoreM);
            TextToValue(textBoxScoreP.Text, out scoreP);
            TextToValue(textBoxScoreE.Text, out scoreE);

            //成績を判定する
            labelResultM.Text = ScoreJudge(attendanceM, scoreM);
            labelResultP.Text = ScoreJudge(attendanceP, scoreP);
            labelResultE.Text = ScoreJudge(attendanceE, scoreE);

            //平均点以上か未満か判定する
            labelCompAvgM.Text = AverageJudge(scoreM, "数学");
            labelCompAvgP.Text = AverageJudge(scoreP, "物理");
            labelCompAvgE.Text = AverageJudge(scoreE, "英語");
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxAttendanceM.Text = "0.0";
            textBoxAttendanceP.Text = "0.0";
            textBoxAttendanceE.Text = "0.0";
            textBoxScoreM.Text = "0";
            textBoxScoreP.Text = "0";
            textBoxScoreE.Text = "0";
            labelResultM.Text = "";
            labelResultP.Text = "";
            labelResultE.Text = "";
            labelCompAvgM.Text = "";
            labelCompAvgP.Text = "";
            labelCompAvgE.Text = "";
        }
    }
}
