using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimmingSchedule
{
    class course
    {
        //フィールド
        private string courseName;
        private int dayOfWeek;
        private int startTime;
        private int price;

        //コンストラクタ
        public course(string name, int day, int time, int p)
        {
            this.courseName = name;
            this.dayOfWeek = day;
            this.startTime = time;
            this.price = p;
        }

        //プロパティ
        public string CourseName
        {
            get { return this.courseName; }
            set { this.courseName = value; }
        }
        public int DayOfWeek
        {
            get { return this.dayOfWeek; }
            set { this.dayOfWeek = value; }
        }
        public int StartTime
        {
            get { return this.startTime; }
            set { this.startTime = value; }
        }
        public int Price
        {
            get { return this.price; }
            set { this.price = value; }
        }
    }
}
