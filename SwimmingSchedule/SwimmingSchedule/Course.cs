using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimmingSchedule
{
    class Course
    {
        private int week;                       // 曜日
        private int startTime;                  // 開始時間
        private int fee;                        // 1回分の授業料
        private const int MinStartTime = 10;    // 最早開始時間
        private const int MaxStartTime = 20;    // 最遅開始時間
        //コンストラクタ
        public Course(string name, int week, int startTime, int fee)
        {
            Name = name;
            Week = week;
            StartTime = startTime;
            Fee = fee;

        }
        public string Name { get; private set; }

        // 曜日（0:日　1:月　2:火　3:水　4:木　5:金　6:土）
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
            get { return startTime; }
            set
            {
                if (value >= MinStartTime && value <= MaxStartTime)
                    startTime = value;
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
