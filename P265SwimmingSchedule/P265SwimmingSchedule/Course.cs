using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P265SwimmingSchedule
{
    class Course
    {
        private int[] arrWeek = { 1, 2, 3, 4, 5, 6, 0 };
        private int[] arrTime = { 14, 10, 17, 19, 20, 20, 10 };
        private int[] arrMoney = { 1000, 1000, 800, 800, 1000, 1200, 1500 };
        public int[] ArrWeek
        {
            get
            {
                return this.arrWeek;
            }
        }
        public int[] ArrTime
        {
            get
            {
                return this.arrTime;
            }
        }
        public int[] ArrMoney
        {
            get
            {
                return this.arrMoney;
            }
        }
    }
}
