using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp11
{
    class Schedule
    {
        private int week;
        private int startTime;
        private int fee;

        public Schedule(string courseName,int week, int startTime, int fee)
        {
            CourseName = courseName;
            Week = week;
            StartTime = startTime;
            Fee = fee;
        }

        public string CourseName { get;private set; }

        public int Week
        {
            get { return week; }
            set
            {
                if (value >= 0 && value <= 6)
                    week = value;
            }
        }

        public int StartTime
        {
            get { return startTime; }
            set
            {
                if(value >= 10 && value <= 20)
                    startTime = value;
            }
        }

        public int Fee
        {
            get { return fee; }
            set
            {
                if (value >= 0)
                    fee = value;
            }
        }

        //授業日
        public string SchoolDays(int year, int month)
        {
            int daysInMonth = DateTime.DaysInMonth(year, month);
            string schoolDays = "";

            for (int day = 1; day <= daysInMonth - 3; day++)
            {
                DateTime dt = new DateTime(year, month, day);
                if ((int)dt.DayOfWeek == week)
                    schoolDays += day + "日";
            }
            return schoolDays;
            
        }

        //授業料
        public int SchoolFee(int year,int month)
        {
            int dayCount = 0;
            int daysInMonth = DateTime.DaysInMonth(year, month);

            //最後の三日はなし
            for(int day = 1; day <= daysInMonth - 3; day++)
            {
                DateTime dt = new DateTime(year, month,day);
                if ((int)dt.DayOfWeek == week)
                    dayCount++;
            }
            return fee * dayCount;
        }
    }
}
