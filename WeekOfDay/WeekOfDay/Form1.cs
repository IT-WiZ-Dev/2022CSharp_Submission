using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            labelWeekResult.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //年月日を整数型に変換
            int year;
            TextToValue(textBoxYear.Text, out year);

            int month, day;
            NumericToValue(numericUpDownMonth.Value, out month);
            NumericToValue(numericUpDownDay.Value, out day);

            //西暦年が閏年かどうか判定
            String leapyear;
             LeapYearJudge(year,out leapyear);

            //月日の妥当性判定　0＝妥当、-1＝不当
            int dayValidity;
            if(month > 0)
            {
                DayValidityJudge(month, day, leapyear, out dayValidity);
            }
            else
            {
                dayValidity = month;
            }
            
            //曜日判定
            if(year == -1)
            {
                labelWeekResult.Text = "西暦年エラー";
            }else if(dayValidity == -1)
            {
                labelWeekResult.Text = "あり得ない日付";
            }
            else
            {
                if(month == 1 || month == 2)
                {
                    year = year - 1;
                    month = month + 12;
                }
                labelWeekResult.Text = WeekJudge(year, month, day);
            }
        }


        //Stringからintに変換
        private void TextToValue(string text, out int val)
        {
            if (int.TryParse(text, out val) == false)
                val = -1; //西暦年エラー
            else if (val < 0 )
                val = -1; //西暦年エラー
        }

        //Decimalからintに変換
        private void NumericToValue(decimal num, out int val)
        {
            val = (int)num;
        }

        //閏年or平年を判定
        private string LeapYearJudge(int year,out string result)
        {
            if (year % 400 == 0)
                result = "閏年";
            else if (year % 4 == 0 && year % 100 != 0)
                result = "閏年";
            else
                result = "平年";

            return result;
        }  

        //日付の妥当性を判定
        private void DayValidityJudge(int month,int day,string leapyear,out int val)
        {
            if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                if (day > 30)
                {
                    val = -1;
                }
                else
                {
                    val = 0;
                }
            }
            else if (month == 2 && leapyear == "閏年")
            {
                if (day > 29)
                {
                    val = -1;
                }
                else
                {
                    val = 0;
                }
            }
            else if (month == 2 && leapyear == "平年")
            {
                if (day > 28)
                {
                    val = -1;
                }
                else
                {
                    val = 0;
                }
            }
            else
            {
                val = 0;
            }
        }

        //曜日を判定
        private string WeekJudge(int year,int month,int day)
        {
            string DayOfWeek = null;
            int weekNum = (5 * year / 4 - year / 100 + year / 400 + (26 * month + 16) / 10 + day) % 7;

            if (weekNum == 0)
                DayOfWeek = "日曜日です";
            else if (weekNum == 1)
                DayOfWeek = "月曜日です";
            else if (weekNum == 2)
                DayOfWeek = "火曜日です";
            else if (weekNum == 3)
                DayOfWeek = "水曜日です";
            else if (weekNum == 4)
                DayOfWeek = "木曜日です";
            else if (weekNum == 5)
                DayOfWeek = "金曜日です";
            else if (weekNum == 6)
                DayOfWeek = "土曜日です";

            return DayOfWeek;
        }
    }
}
