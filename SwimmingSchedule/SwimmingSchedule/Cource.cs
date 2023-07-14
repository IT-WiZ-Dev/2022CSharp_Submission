using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimmingSchedule
{
    class Cource
    {
        private string courseName;
        private int dayofWeek;
        private int startTime;
        private int price;

        public Cource(string name, int day, int time, int p)
        {
            this.courseName = name;
            this.dayofWeek = day;
            this.startTime = time;
            this.price = p;
        }

        public string CourceName
        {
            get
            {
                return courseName;
            }
            set
            {
                courseName = value;
            }
        }

        public int DayofWeek
        {
            get
            {
                return dayofWeek;
            }
            set
            {
                dayofWeek = value;
            }
        }
        public int StartTime
        {
            get
            {
                return startTime;
            }
            set
            {
                startTime = value;
            }
        }
        public  int Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

    }
}
