using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimmingSchedule
{
   
    class Course
    {
        // フィールド
        private int week;                       
        private int start;                  
        private int fee;                        
        private const int MinStart = 10;   
        private const int MaxStart = 20;   

        // コンストラクター
        public Course(string name, int week, int startTime, int fee)
        {
            Name = name;
            Week = week;
            StartTime = startTime;
            Fee = fee;
        }

        // プロパティ
        // コース名
        public string Name { get; private set; }

        
        public int Week
        {
            get { return week; }
            set
            {
                if (value >= 0 && value <= 6)
                    week = value;
            }
        }

        // 開始時間
        public int StartTime
        {
            get { return start; }
            set
            {
                if (value >= MinStart && value <= MaxStart)
                    start = value;
            }
        }

        // 1回分の授業料
        public int Fee
        {
            get { return fee; }
            set
            {
                if (value >= 0)
                    fee = value;
            }
        }

     
        public string SchoolDays(int year, int month)
        {
            int daysInMonth = DateTime.DaysInMonth(year, month);
            string schoolDays = "";

            // 月の最後の3日間は除く
            for (int day = 1; day <= daysInMonth - 3; day++)
            {
                DateTime dt = new DateTime(year, month, day);
                if ((int)dt.DayOfWeek == Week)
                    schoolDays += day + "日  ";
            }

            return schoolDays;
        }

        
        public int SchoolFee(int year, int month)
        {
            int dayCount = 0;
            int daysInMonth = DateTime.DaysInMonth(year, month);

            
            for (int day = 1; day <= daysInMonth - 3; day++)
            {
                DateTime dt = new DateTime(year, month, day);
                if ((int)dt.DayOfWeek == Week)
                    dayCount++;
            }
            return Fee * dayCount;
        }
    }
}
