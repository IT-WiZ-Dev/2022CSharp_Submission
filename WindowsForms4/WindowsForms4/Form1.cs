using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;





namespace WindowsForms4
{
    public partial class Form1 : Form
    {
        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeComponent();
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            int seireki;
            bool urudoshi = false;



            if (!int.TryParse(textBox1.Text, out seireki))
            {
                MessageBox.Show("入力値が正しくありません");
                return;
            }



            // 閏年の判断
            if (seireki % 400 == 0)
            {
                urudoshi = true;
            }
            else if (seireki % 4 == 0)
            {
                if (seireki % 100 != 0)
                {
                    urudoshi = true;
                }
            }



            int tuki = (int)numericUpDown1.Value;
            int niti = (int)numericUpDown2.Value;



            // 年月日の妥当性チェック
            if (tuki < 1 || tuki > 12 || niti < 1 || niti > GetDaysInMonth(seireki, tuki))
            {
                MessageBox.Show("日付が無効です");
                return;
            }



            // 曜日の計算
            int WindowsForms4 = CalculateWindowsForms4(seireki, tuki, niti, urudoshi);



            string String = ConvertToDayOfWeekString(WindowsForms4);



            label4.Text = $"{WindowsForms4}です";
        }



        private int GetDaysInMonth(int year, int month)
        {
            if (month == 2)
            {
                return IsLeapYear(year) ? 29 : 28;
            }
            else if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                return 30;
            }
            else
            {
                return 31;
            }
        }



        private bool IsLeapYear(int year)
        {
            if (year % 400 == 0)
            {
                return true;
            }
            else if (year % 100 == 0)
            {
                return false;
            }
            else if (year % 4 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        private int CalculateWindowsForms4(int year, int month, int day, bool isLeapYear)
        {
            int[] t = new int[] { 0, 3, 2, 5, 0, 3, 5, 1, 4, 6, 2, 4 };
            if (month < 3)
            {
                year--;
            }
            int WindowsForms4Value = (year + year / 4 - year / 100 + year / 400 + t[month - 1] + day) % 7;



            if (isLeapYear && (month == 2 || month == 3))
            {
                WindowsForms4Value = (WindowsForms4Value + 1) % 7;
            }



            return WindowsForms4Value;
        }



        private string ConvertToDayOfWeekString(int dayOfWeek)
        {
            switch (dayOfWeek)
            {
                case 0:
                    return "日曜日";
                case 1:
                    return "月曜日";
                case 2:
                    return "火曜日";
                case 3:
                    return "水曜日";
                case 4:
                    return "木曜日";
                case 5:
                    return "金曜日";
                case 6:
                    return "土曜日";
                default:
                    return "";
            }
        }


       
    }
}


