using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_演習問題_22310121
{

    class Course
    {
        private string couseName;
        private int day0fWeek;
        private int startTime;
        private int price;

        //コンストラクタ
        public Course(string name, int day, int time, int p)
        {
            this.couseName = name;
            this.day0fWeek = day;
            this.startTime = time;
            this.price = p;

        }

        //プロパティ
        public string CourseName//アクセサを作ったのでプライベートでも持ってこれる
        {

            set
            {this.CourseName = value;}
            get
            {return this.couseName;}
        }
        public int DayOfWeek
        {
            set
            { this.day0fWeek = value; }
            get
            { return this.day0fWeek; }

        }
        public int Starttime
        {

            set
            { this.startTime = value; }
            get
            { return this.startTime; }
        }
        public int Price
        {

            set
            { this.price = value; }
            get
            { return this.price; }
        }
    }
}
