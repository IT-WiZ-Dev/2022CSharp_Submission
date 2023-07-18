using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwimmingSchedule
{
    internal class Course
    {
        /*
        private string[] coursename = {"ベビーコース","幼児コース","小学生コース","中学生コース","レディースコース","一般コース","家族コース" };
        private string[] day = {"月","火","水","木","金","土","日" };
        private int[] starttime = { 14, 10, 17, 19, 20, 20, 10 };
        private int[] oneprice = { 1000, 1000, 800, 800, 1000, 1200, 1500 };
        */
        private string coursename;
        private string day;
        private int starttime ;
        private int oneprice;


        public Course(string coursename, string day, int starttime, int oneprice)
        {
            Coursename = coursename;
            Day = day;
            Starttime = starttime;
            Oneprice = oneprice;
        }
        /*
        public int Price(int price)
        {
            price = int.Parse(oneprice);
            return price;
        }
         */

        public string Coursename
        {

            get { return coursename; }
            set { coursename = value; }
            
        }

        public string Day
        {
            get { return day; }
            set { day = value; }

        }

        public int Starttime 
        { 
            get { return starttime; } 
            set {  starttime = value; } 
        
        }

        public int Oneprice

        {
            get { return oneprice; }
            set { oneprice = value; }

        }


    }





}
