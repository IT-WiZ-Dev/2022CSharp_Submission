using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_SwimmingSchedule
{
    class Course
    {
        public string courseName;
        public int dayOfWeek { get; set; }
        public int startTime;
        public int price;

        //コンストラクタ
        public Course(string name, int day, int time, int p)
        {
            this.courseName = name;
            this.dayOfWeek = day;
            this.startTime = time;
            this.price = p;
        }
    }
}
