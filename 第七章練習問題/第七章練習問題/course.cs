using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第七章練習問題
{
    class course
    {
        private string courseName;
        private int dayOFWeek;
        private int startTime;
        private int price;

        //コンストラクタ
        public course(string name, int day, int time, int p)
        {
            this.courseName = name;
            this.dayOFWeek = day;
            this.startTime = time;
            this.price = p;

        }

        //プロパティ
        public string CourseName
        {
            set { this.courseName = value; }
            get { return this.courseName; }
        }
        public int DayOFWeek
        {
            set { this.dayOFWeek = value; }
            get { return this.dayOFWeek; }
        }
        public int StartTime
        {
            set { this.startTime = value;}
            get { return this.startTime; }
        }
        public int Price
        {
            set { this.price = value; }
            get { return this.price; }
        }

        


    }
}