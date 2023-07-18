using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeCheck2
{
    public partial class FormGrade : Form
    {
        //フィールド
        Subject subjectM;     //数学のインスタンス
        Subject subjectP;     //物理のインスタンス
        Subject subjectE;     //英語のインスタンス

        public FormGrade()
        {
            InitializeComponent();
        }

        private void formGrade_Load(object sender,EventArgs e)
        {
            //科目クラスから数学、物理、英語のインスタンスを生成
            subjectM = new Subject("数学",73,80,60,80.0);
            subjectP = new Subject("物理",65,50,50,80.0);
            subjectE = new Subject("英語", 77, 100, 70, 80.0);

            //各科目の出席総時数の表示
            labelTotalM.Text = "/" + subjectM.TotalHours.ToString();
            labelTotalP.Text = "/" + subjectP.TotalHours.ToString();
            labelTotalE.Text = "/" + subjectE.TotalHours.ToString();

            //各科目の合格点の表示
            labelPassScoreM.Text = subjectM.PassScore.ToString();
            labelPassScoreP.Text = subjectP.PassScore.ToString();
            labelPassScoreE.Text = subjectE.PassScore.ToString();

            //各科目の平均点の表示
            labelAverageM.Text = subjectM.Average.ToString();
            labelAverageP.Text = subjectP.Average.ToString();
            labelAverageE.Text = subjectE.Average.ToString();

            //ラベルのクリア
            LabelClear();
        }


        //結果を表示するラベルのクリア
        private void LabelClear()
        {
            labelName.Text = "";
            labelResultM.Text = "";
            labelResultP.Text = "";
            labelResultE.Text = "";
            labelCompAvgM.Text = "";
            labelCompAvgP.Text = "";
            labelCompAvgE.Text = "";
        }

        private void buttonJudge_Click(object sender, EventArgs e)
        {
            //得点を整数値に変換
            int scoreM, scoreP, scoreE;
            TextToValue(textBoxScoreM.Text, out scoreM);
            TextToValue(textBoxScoreP.Text, out scoreP);
            TextToValue(textBoxScoreE.Text, out scoreE);

            //点数の範囲チェック
            if(scoreM < 0 || scoreM > 100 || scoreP < 0 || scoreP > 100 ||scoreE < 0 || scoreE > 100)
            {
                MessageBox.Show("得点の入力が正しくありません。", "確認");
                return;
            }

            //出席時数を整数値に変換
            int attendanceM, attendanceP, attendanceE;
            TextToValue(textBoxAttendanceM.Text, out attendanceM);
            TextToValue(textBoxAttendanceP.Text, out attendanceP);
            TextToValue(textBoxAttendanceE.Text, out attendanceE);

            //主席時数の範囲チェック
            if(attendanceM < 0 || attendanceM > subjectM.TotalHours ||
               attendanceP < 0 || attendanceP > subjectP.TotalHours ||
               attendanceE < 0 || attendanceE > subjectE.TotalHours)
            {
                MessageBox.Show("出席時数の入力が正しくありません。", "確認");
                return;
            }

            //学生クラスから学生のインスタンスを生成
            Student student = new Student(textBoxName.Text, scoreM, scoreP, scoreE, attendanceM, attendanceP, attendanceE);

            //名前の表示
            labelName.Text = student.Name + "さんの成績";

            //合否判定
            labelResultM.Text = subjectM.OverPass(student.ScoreM, student.AttendanceM);
            labelResultP.Text = subjectP.OverPass(student.ScoreP, student.AttendanceP);
            labelResultE.Text = subjectE.OverPass(student.ScoreE, student.AttendanceE);

            //平均点以上か未満か判定する
            labelCompAvgM.Text = subjectM.OverAverage(student.ScoreM);
            labelCompAvgP.Text = subjectP.OverAverage(student.ScoreP);
            labelCompAvgE.Text = subjectE.OverAverage(student.ScoreE);
        }

        //テキストを整数値に変換
        //(仮引数)text:変換する文字列 val:変換した整数値
        private void TextToValue(string text,out int val)
        {
            if (int.TryParse(text, out val) == false)
                val = -1;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            LabelClear();

            textBoxName.Text = "";
            textBoxAttendanceM.Text = "0";
            textBoxAttendanceP.Text = "0";
            textBoxAttendanceE.Text = "0";
            textBoxScoreM.Text = "0";
            textBoxScoreP.Text = "0";
            textBoxScoreE.Text = "0";

        }

       
    }
}
