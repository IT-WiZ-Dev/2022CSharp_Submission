using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimmingSchedule
{
    class Schedule
    {
        private int week;           
        private int startTime;     
        private int ryoukin;            

        // コンストラクター
        public Schedule(string courseName, int week, int startTime, int ryoukin)
        {
            CourseName = courseName;
            Week = week;
            StartTime = startTime;
            Ryoukin = ryoukin;
        }
        public int Week
        {
            get { return week; }
            set
            {
                if (value >= 0 && value <= 6)
                    week = value;
            }
        }
        // プロパティ
        public string CourseName { get; private set; }

       
        public int StartTime
        {
            get { return startTime; }
            set
            {
                if (value >= 10 && value <= 20)
                    startTime = value;
            }
        }

        public int Ryoukin
        {
            get { return ryoukin; }
            set
            {
                if (value >= 0)
                    ryoukin = value;
            }
        }

        public string SchoolDays(int year, int month)
        {
            int daysInMonth = DateTime.DaysInMonth(year, month);
            string schoolDay = "";

            for (int day = 1; day <= daysInMonth - 3; day++)
            {
                DateTime dt = new DateTime(year, month, day);
                if ((int)dt.DayOfWeek == week)
                    schoolDay += day + "日  ";
            }

            return schoolDay;
        }

        public int SchoolFee(int year, int month)
        {
            int dayCount = 0;
            int daysInMonth = DateTime.DaysInMonth(year, month);

            for (int day = 1; day <= daysInMonth - 3; day++)
            {
                DateTime dt = new DateTime(year, month, day);
                if ((int)dt.DayOfWeek == week)
                    dayCount++;
            }
            return ryoukin * dayCount;
        }
    }
}
