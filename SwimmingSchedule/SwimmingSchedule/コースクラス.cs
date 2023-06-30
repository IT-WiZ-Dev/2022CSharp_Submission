using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimmingSchedule
{
    class コースクラス
    {
        private string course;
        private int day;
        private int time;
        private int money;

        public コースクラス(string course,int day,int time,int money)
        {
            this.course = course;
            this.day = day;
            this.time = time;
            this.money = money;
        }

        //プロパティ
        public string Course
        {
            set
            {
                this.course = value;
            }
            get
            {
                return this.course;
            }
        }
        public int DayOfWeek
        {
            get { return day; }
            set
            {
                day = value;
            }
        }
        public int StartTime
        {
            get { return time; }
            set
            {
                time = value;
            }
        }
        public int Price
        {
            get { return money; }
            set
            {
                money = value;
            }
        }
    }
}
