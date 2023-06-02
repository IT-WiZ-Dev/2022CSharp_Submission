using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int seireki;
            bool urudoshi = false;


            //存在しない年月日の判定
            if (!int.TryParse(textBox1.Text, out seireki)|| seireki < 0)
            {
                label1.Text = ("西暦年エラー");
                return;
            }

            //うるう年の判別
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
            //ニューメリックのところから各数値を抽出
            int tuki = (int)numericUpDown1.Value;
            int niti = (int)numericUpDown2.Value;

            //年月日の妥当性のチェック
            if (tuki < 1 || tuki > 12 || niti < 1 || niti > GetDaysInMonth(seireki, tuki))
            {
                label1.Text = ("あり得ない日付");
                return;
            }

            int dayOfWeek = CalculateDayOfWeek(seireki, tuki, niti, urudoshi);

            string dayOfWeekString = ConvertToDayOfWeekString(dayOfWeek);


            label1.Text = $"{dayOfWeekString}です";
        }

        private int GetDaysInMonth(int year,int month)
        {
            if(month == 2)
            {
                return IsLeapYear(year) ? 29 : 28;
            }
            else if(month == 4 || month == 6 || month == 9 || month == 11)
            {
                return 30;
            }
            else
            {
                return 31;
            }
        }


        //うるう年かそうでないか
        private bool IsLeapYear(int year)
        {
            if(year % 400 == 0)
            {
                return true;
            }
            else if (year % 100 == 0)
            {
                return false;
            }
            else if(year % 4 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private int CalculateDayOfWeek(int year,int month,int day,bool isLeapYear)
        {
            int[] t = new int[] { 0, 3, 2, 5, 0, 3, 5, 1, 4, 6, 2, 4 };
            if(month<3)
            {
                year--;
            }
            int dayOfWeekValue = (year + year / 4 - year / 100 + year / 400 + t[month - 1] + day) % 7;

            if(isLeapYear && (month == 2 || month == 3))
            {
                dayOfWeekValue = (dayOfWeekValue + 1) % 7;
            }
            return dayOfWeekValue;
        }

        private string ConvertToDayOfWeekString(int dayOfWeek)
        {
            switch(dayOfWeek)
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

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

        
    }
