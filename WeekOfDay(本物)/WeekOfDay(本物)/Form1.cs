using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeekOfDay_本物_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            bool flag = false;
            int year = int.Parse(textBox1.Text);
            bool jeap = obj.leap_year(year);
           
            int month = int.Parse(numericUpDown1.Text);
            int day = int.Parse(numericUpDown2.Text);
            if (month <= 13)
            {
                flag = true;
                label4.Text = "適切な月を入力してください。";
            }else if (month==1||month==3||month==5||month==7||month==8||month==10||month==12)
            {
                if (day <= 32)
                {
                    flag = true;
                    label4.Text = "適切な日付を入力してください。";
                }
            }
            else if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                if (day <= 31)
                {
                    flag = true;
                    label4.Text = "適切な日付を入力してください。";
                }
            }
            else 
            {
                if (jeap == true)
                {
                    if (day <= 29)
                    {
                        flag = true;
                        label4.Text = "適切な日付を入力してください。";
                    }
                }
            }

            int W;
            if (month == 1)
            {
                year = year - 1;
                month = 13;
            }else if (month == 2)
            {
                year = year - 1;
                month = 14;
            }

            if (flag == false)
            {
                W = (5 * year / 4 - year / 100 + year / 400 + (26 * month + 16) / 10 + day) % 7;
                switch (W)
                {
                    case 0:
                        label4.Text = "日曜日です。";
                        break;
                    case 1:
                        label4.Text = "月曜日です。";
                        break;
                    case 2:
                        label4.Text = "火曜日です。";
                        break;
                    case 3:
                        label4.Text = "水曜日です。";
                        break;
                    case 4:
                        label4.Text = "木曜日です。";
                        break;
                    case 5:
                        label4.Text = "金曜日です。";
                        break;
                    case 6:
                        label4.Text = "土曜日です。";
                        break;

                }
            }



        }



        Boolean leap_year(int year)
        {
            if (year <= 0)
            {
                label4.Text = "適切な年を入力してください。";
            }
            if (year / 4 == 0 && year / 100 != 0 || year / 400 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
