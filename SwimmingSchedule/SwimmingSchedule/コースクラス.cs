using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimmingSchedule
{
    class コースクラス
    {
        private string coce;
        private int dayOfWeek;
        private int startTime;
        private int price;
        public コースクラス(string n, int day,int start,int p)
        {
            this.coce = n;
            this.dayOfWeek = day;
            this.startTime = start;
            this.price = p;
        }　
        public string Coce
        {
            get { return coce; }
            set
            {
                coce = value;
            }
        }
        public int DayOfWeek
        {
            get { return dayOfWeek; }
            set
            {
                dayOfWeek = value;
            }
        }
        public int StartTime
        {
            get { return startTime; }
            set
            {
                startTime = value;
            }
        }
        public int Price
        {
            get { return price; }
            set
            {
                price = value;
            }
        }
    }
}
