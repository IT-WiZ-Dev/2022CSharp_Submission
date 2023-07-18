using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeCheck2
{   
    //科目クラス
    class Subject
    {
        //フィールド
        private double average;         //平均点
        private int totalHours;         //出席総時数
        private int passScore;          //合格点
        private double passAttendance;  //合格出席率

        //コンストラクター
        public Subject(string name, double average, int totalHours, int passScore, double passAttendance)
        {
            Name = name;
            Average = average;
            TotalHours = totalHours;
            PassScore = passScore;
            PassAttendance = passAttendance;
        }

        //プロパティ
        public string Name { get; set; }  //科目名
        public double Average             //平均点
        {
            get { return average; }
            set
            {
                if (value >= 0.0 && value <= 100.0)
                    average = value;
                else
                {
                    System.Windows.Forms.MessageBox.Show("平均点の入力が正しくありません。", "確認");
                    average = 0.0;
                }
            }
        }

        public int TotalHours        //出席総時数
        {
            get { return totalHours; }
            set
            {
                if (value >= 0)
                    totalHours = value;
                else
                {
                    System.Windows.Forms.MessageBox.Show("総合時数の入力が正しくありません。", "確認");
                    totalHours = 0;
                }
            }
        }

        public int PassScore　　　//合格点
        {
            get { return passScore; }
            set
            {
                if (value >= 0 && value <= 100)
                    passScore = value;
                else
                {
                    System.Windows.Forms.MessageBox.Show("合格点の入力が正しくありません。", "確認");
                    passScore = 0;
                }
            }
        }
        public double PassAttendance     //合格出席率
        {
            get { return passAttendance; }
            set
            {
                if (value >= 0.0 && value <= 100.0)
                    passAttendance = value;
                else
                {
                    System.Windows.Forms.MessageBox.Show("合格出席率の入力が正しくありません。", "確認");
                    passAttendance = 0.0;
                }
            }
        }

        //合否判定
        //(仮引数)score:得点　attendance:出席時数
        //(返却値)判定結果
        public string OverPass(int score, int attendance)
        {
            double percent = (double)attendance / TotalHours * 100;
            if(percent >= PassAttendance)
            {
                if (score >= PassScore)
                    return "合格";
                else
                    return "不合格";
            }
            else
            {
                return "不合格";
            }
        }

        //平均点以上か判定
        //(仮引数)score:得点
        //(返却値)判定結果
        public string OverAverage(int score)
        {
            if (score >= Average)
                return "平均点以上";
            else
                return "平均点未満";
        }
    }
}
