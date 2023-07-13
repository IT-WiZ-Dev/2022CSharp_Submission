using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimmingSchedule
{
    class Course
    {
        private string courseName;  //コース
        private int dayOfWeek;      //曜日
        private int startTime;　　　//開始日付
        private int price;　　　　　//価格

        //コンストラクタ
        public Course(string name, int day, int time, int p)
        {
            this.courseName = name;
            this.dayOfWeek = day;
            this.startTime = time;
            this.price = p;
        }

        //プロパティ

        //コース名
        public string CourseName
        {
            set
            {
                this.courseName = value;
            }
            get
            {
                return this.courseName;
            }
        }

        // 曜日
        public int DayOfWeek
        {
            set
            {
                // 曜日が値内にあるか判定
                if (value >= 0 && value <= 7)
                {
                    dayOfWeek = value;
                }
            }
            get
            {
                return dayOfWeek;
            }
        }

        // 開始時間
        public int StartTime
        {
            set
            {
                // 営業時間内か判定
                if (value >= 10 && value <= 20)
                {
                    startTime = value;
                }
            }
            get
            {
                return startTime;
            }
        }


        //一回分の授業料
        public int Price
        {
            set
            {
                //マイナスになってないか判定
                if(value > 0)
                {
                    price = value;
                }
            }
            get
            {
                return price;
            }
        }

        //授業日を求める
        public string SchoolDays(int year, int month)
        {
            int endDay = DateTime.DaysInMonth(year, month);
            string schoolDays = "";

            //月の最後3日間を除いた範囲
            for (int i = 1; i <= endDay - 3; i++)
            {
                DateTime dt = new DateTime(year, month, i);
                //日付と対象曜日が合えば
                if ((int)dt.DayOfWeek == dayOfWeek)
                    schoolDays += i + "日";
            }

            return schoolDays;
        }

        //授業料を求める
        public int SchoolFees(int year, int month)
        {
            int count = 0;
            int endDay = DateTime.DaysInMonth(year, month);

            //月の最後3日間を除いた範囲
            for (int i = 1; i <= endDay - 3; i++)
            {
                DateTime dt = new DateTime(year, month, i);
                //日付と対象曜日が合えば
                if ((int)dt.DayOfWeek == dayOfWeek)
                    count++;
            }

            return price * count;
        }


    }
}
