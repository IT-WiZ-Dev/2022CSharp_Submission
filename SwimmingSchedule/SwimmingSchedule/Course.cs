using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimmingSchedule
{
    class Course

    {

        private String courseName;
        private int dayOfWeek;
        private int startTime;
        private int price;
        public int total = 0;
        //コンストラクタ
        public Course(String name,int day,int time,int p)
        {
            this.courseName = name;
            this.dayOfWeek = day;
            this.startTime = time;
            this.price = p;
        }

        //プロパティ
        public string Coursename
        {
            set { this.courseName = value; }
            get { return this.courseName; }
        }
        public int DayOfWeek
        {
            set { this.dayOfWeek = value; }
            get { return this.dayOfWeek; }
        }
        public int Strattime
        {
            set { this.startTime = value; }
            get { return this.startTime; }
        }
        public int Price
        {
            set { this.price = value; }
            get { return this.price; }
        }

    }
}
