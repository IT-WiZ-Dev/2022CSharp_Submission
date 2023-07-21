using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimmingSchedule
{
    class Cource
    {
        //フィールド
        private int week;                       // 曜日
        private int startTime;                  // 開始時間
        private int fee;                        // 1回分の授業料
        private const int MinStartTime = 10;    // 最早開始時間
        private const int MaxStartTime = 20;    // 最遅開始時間
        

        //コンストラクタ
        public Cource(string name, int week, int starttime,int fee )
        {
            Name = name;
            Week = week;
            Starttime = startTime;
            Fee = fee;

        }
        //プロパティ
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

        public int Starttime
        {
            get { return startTime; }
            set
            {
                if (value >= MinStartTime && value <= MaxStartTime)
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
