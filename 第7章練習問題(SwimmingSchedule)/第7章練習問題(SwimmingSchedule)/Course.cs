using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第7章練習問題_SwimmingSchedule_
{
    class Course
    {
        private string couseName;  //コース名
        private int dayOfWeek;  //曜日
        private int startTime;  //開始時刻
        private int price;  //料金



        //コンストラクタ
        public Course(string name, int day, int time, int p)
        {
            this.couseName = name;
            this.dayOfWeek = day;
            this.startTime = time;
            this.price = p;
        }

        //プロパティ
        public string CourseName //コースの名前
        {
            get { return this.couseName; }
            set { this.couseName = value; }
        }

        public int DayOfWeek //曜日
        {
            get { return this.dayOfWeek; }
            set { if (value >= 0 && value <= 6)
                    dayOfWeek = value;
            }
        }

        public int StartTime //開始時刻
        {
            get { return this.startTime; }
            set { if (value >= 10 && value <= 20)
                    startTime = value;
            }
        }

        public int Price //価格
        {
            get { return this.price; }
            set { if (value >= 0)
                    price = value;
            }
        }

        // 該当月の授業日算出
        //（仮引数）year：西暦年　month：月
        //（返却値）該当月の授業日
        public string SDays(int year, int month)
        {
            int endDay = DateTime.DaysInMonth(year, month);
            string sdays = "";

            for (int i = 1; i <= endDay - 3; i++)  //endDay -3なのは、月の最後の3日間はプールの入れ替えと清掃で休講になるため
            {
                DateTime h2 = new DateTime(year, month, i);
                if ((int)h2.DayOfWeek == DayOfWeek)
                    sdays += i + "日  ";
            }

            return sdays;
        }

        // 該当月の授業料
        //（仮引数）year：西暦年　month：月
        //（返却値）該当月の授業料
        public int SPrice(int year, int month)
        {
            int daycount = 0;
            int daysInMonth = DateTime.DaysInMonth(year, month);

            for (int i = 1; i <= daysInMonth - 3; i++)  //endDay -3なのは、月の最後の3日間はプールの入れ替えと清掃で休講になるため
            {
                DateTime h2 = new DateTime(year, month, i);
                if ((int)h2.DayOfWeek == DayOfWeek)
                    daycount = daycount + 1;
            }
            return Price * daycount;
        }
    }
}

