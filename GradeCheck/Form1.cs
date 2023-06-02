using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeCheck
{
    public partial class FormGrade : Form
    {
        public FormGrade()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelResultM.Text = "";
            labelResultP.Text = "";
            labelResultE.Text = "";
            labelCompAvgM.Text = "";
            labelCompAvgP.Text = "";
            labelCompAvgE.Text = "";
        }
        private void TextToValue(string text, out double val)
        {
            if (double.TryParse(text, out val) == false)
                val = -1.0;
        }
        private void TextToValue(string text, out int val)
        {
            if (int.TryParse(text, out val) == false)
                val = -1;
        }
        private string ScoreJudge(double attendance, int score)
        {
            string result;

            if (attendance < 0.0 || attendance > 100.0 ||
                score < 0 || score > 100)
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
        private string AverageJudge(int score,string subject)
        {
            string result;
            int average;

            const int MathAverage = 73;
            const int PhysicalAverage = 65;
            const int EnglishAverage = 77;

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

       private void ButtonJudge_Click(object sender, EventArgs e)
       {
            double attendanceM, attendanceP, attendanceE;
            TextToValue(textBoxAttendanceM.Text, out attendanceM);
            TextToValue(textBoxAttendanceP.Text, out attendanceP);
            TextToValue(textBoxAttendanceE.Text, out attendanceE);

            int scoreM, scoreP, scoreE;
            TextToValue(textBoxScoreM.Text, out scoreM);
            TextToValue(textBoxScoreP.Text, out scoreP);
            TextToValue(textBoxScoreE.Text, out scoreE);

            labelResultM.Text = ScoreJudge(attendanceM, scoreM);
            labelResultP.Text = ScoreJudge(attendanceP, scoreP);
            labelResultE.Text = ScoreJudge(attendanceE, scoreE);

            labelCompAvgM.Text = AverageJudge(scoreM, "数学");
            labelCompAvgP.Text = AverageJudge(scoreP, "物理");
            labelCompAvgE.Text = AverageJudge(scoreE, "英語");
        }

        private void ButtonReset_Click(object sender, EventArgs e)
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
