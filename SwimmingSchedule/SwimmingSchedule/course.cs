using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimmingSchedule 
{
    class course
    {
        private string courseName;
        private int dayOfWeek;
        private int startTime;
        private int price;

        public course(string name, int day, int time,int p)
        {
            this.courseName = name;
            this.dayOfWeek = day;
            this.startTime = time;
            this.price = p;
        }

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
        public int DayOfWeek
        {
            set
            {
                this.dayOfWeek = value;
            }
            get
            {
                return this.dayOfWeek;
            }
        }

        public int StartTime
        {
            set
            {
                this.startTime = value;
            }
            get
            {
                return this.startTime;
            }
        }

        public int Price
        {
            set
            {
                this.price = value;
            }
            get
            {
                return this.price;
            }
        }
    }
}
