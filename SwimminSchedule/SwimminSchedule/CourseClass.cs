using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimminSchedule
{
    class Course
    {
        private string coursename;      //コースの名前
        private int dayofweek;      //コースの曜日
        private int time;           //コースの開始時間
        private int price;          //コースの授業料

        public Course(string coursename, int dayofweek, int time, int price)
        {
            this.CouseName = coursename;
            this.DayOfWeek = dayofweek;
            this.Time = time;
            this.Price = price;
        }

        
        public string CouseName 
        {
            set
            {
                coursename = value;
            }
            get
            {
                return this.coursename;
            }
        }

        public int DayOfWeek
        {
            set
            {
                dayofweek = value;
            }
            get
            {
                return this.dayofweek;
            }
        }

        public int Time
        {
            set
            {
                time = value;
            }
            get
            {
                return this.time;
            }
        }

        public int Price
        {
            set
            {
                price = value;
            }
            get
            {
                return this.price;
            }
        }
        
    }
}
