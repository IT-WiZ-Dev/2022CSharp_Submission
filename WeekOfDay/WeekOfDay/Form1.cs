using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeekOfDay
{
    public partial class Form1 : Form
    {





        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int year = int.Parse(textBox1.Text);
            int month = (int)numericUpDown1.Value;
            int day = (int)numericUpDown2.Value;

            int week = WeekDay(year, month, day);  
            
            if(week == 0)
            {

            }
            
            Judge(year);
            Check(year,month,day);

            if(Check(year,month,day) == false)
            {
                label4.Text = "ありえない日付";
            }



            DateTime date = new DateTime(year, month, day);
            // 曜日を取得して表示
            DayOfWeek dayOfWeek = date.DayOfWeek;
            string Day1 = dayOfWeek.ToString();
            if (Day1 == "Sunday")
            {
                label4.Text = "日曜日";
            }
            if (Day1 == "Saturday")
            {
                label4.Text = "土曜日";
            }
            if (Day1 == "Friday")
            {
                label4.Text = "金曜日";
            }
            if (Day1 == "Thursday")
            {
                label4.Text = "木曜日";
            }
            if (Day1 == "Wednesday")
            {
                label4.Text = "水曜日";
            }
            if (Day1 == "Tuesday")
            {
                label4.Text = "火曜日";
            }
            if (Day1 == "Monday")
            {
                label4.Text = "月曜日";
            }


        }

        public int WeekDay(int year,int month,int day)
        {
            if(month ==1 || month == 2)
            {
                year--;
                month += 12;
            }

            return (5 * year / 4 - year / 100 + year / 400 + (26 * month + 16) / 10 + day) % 7;
        }



        private bool Judge(int year)
        {

            bool rc = false;


            if (4 % year == 0 && 100 % year != 0 || year % 400 == 0)
            {
                //うるう年
                rc = true;
            }
            return rc;
        }

            public bool Check(int year,int month,int day)
            {
            bool check = false;


            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
                {
                    if (day > 31) {
                        check = false;
                    }

                }

                if (month == 4 || month == 6 || month == 9 || month == 11)
                {
                    if (day > 30)
                    {
                        check = false;
                    }
                }

                if(Judge(year)== true)
                {
                    if(day > 29)
                    {
                        check = false;
                    }
                    else if(day > 28)
                    {
                        check = false;
                    }
                }
                return check;

            }
            /*
            if (listBox1.Text=="2") { 

            }
            if(listBox2.Text == "4" || listBox2.Text == "6" || listBox2.Text == "9" || listBox2.Text == "11")
            {
                if (listBox2.Text=="31")
                {
                    
                }
            }
            */
        

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
