using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimmingSchedule
{
    class Corse
    {
        //フィールド
        int lesson_week;
        int start_time;
        int lesson_price;

        //コンストラクタ―
        public Corse(string name,int lesson_week,int start_time,int lesson_price)
        {
            Name = name;
            Lesson_week = lesson_week;
            Start_time = start_time;
            Lesson_price = lesson_price;
        }

        //プロパティ
        public string Name { get; set; }
        public int Lesson_week
        {
            get { return lesson_week; }
            set
            {
                if (value >= 0 && value <= 6)
                    lesson_week = value;
                else
                {
                    System.Windows.Forms.MessageBox.Show("曜日の入力が正しくありません。", "確認");
                    lesson_week = -1;
                }
            }
        }
        public int Start_time
        {
            get { return start_time; }
            set
            {
                if (value >= 0 && value <= 23)
                    start_time = value;
                else
                {
                    System.Windows.Forms.MessageBox.Show("開始時間の入力が正しくありません。", "確認");
                    start_time = -1;
                }
            }
        }
        public int Lesson_price
        {
            get { return lesson_price; }
            set
            {
                if (value >= 0)
                    lesson_price = value;
                else
                {
                    System.Windows.Forms.MessageBox.Show("授業料の入力が正しくありません。", "確認");
                    lesson_price = -1;
                }
            }
        }
    }
}
