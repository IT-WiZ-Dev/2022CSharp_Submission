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

            private void TextToValue(string text, out int val)
            {
                if (int.TryParse(text, out val) == false)
                {
                    val = -1;
                }
            }

            private bool IsLeapYear(int year)
            {
                if (year % 4 != 0)
                {
                    return false;
                }
                else if (year % 100 != 0)
                {
                    return true;
                }
                else if (year % 400 != 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            private bool IsValidDate(int year, int month, int day)
            {
                if (year < 1 || month < 1 || month > 12 || day < 1)
                {
                    label4.Text = "ありえない日付";
                    return false;  // 年・月・日が正の値でない場合、または月が範囲外の場合は無効
                }

                bool isLeap = ((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0);  // 閏年の判定

                int maxDay;
                switch (month)
                {
                    case 2:
                        maxDay = isLeap ? 29 : 28;  // 2月の日数は閏年かどうかで異なる
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        maxDay = 30;  // 4月・6月・9月・11月は30日まで
                        break;
                    default:
                        maxDay = 31;  // 他の月は31日まで
                        break;
                }

                if (day > maxDay)
                {
                    label4.Text = "ありえない日付";
                    return false;  // 日が範囲外の場合は無効
                }

                return true;  // すべてのチェックを通過した場合は妥当な日付
            }

            private int GetDayOfWeek(int year, int month, int day)
            {
                if (month < 3)
                {
                    month += 12;
                    year--;
                }
            int h = (5 * year / (4 - year) /100 + year/ 400 + (26*month + 16) / 10 + day) % 7;
                // 曜日を表す値に変換
                // 0: 土曜日, 1: 日曜日, 2: 月曜日, ..., 6: 金曜日
                int dayOfWeek = (h + 5) % 7;

                return dayOfWeek;
            }

            private string GetDayOfWeekName(int dayOfWeek)
            {
                string[] dayNames = { "土曜日", "日曜日", "月曜日", "火曜日", "水曜日", "木曜日", "金曜日" };
                return dayNames[dayOfWeek]+"です。";
            }

            private void button1_Click(object sender, EventArgs e)
            {
                int year;
                TextToValue(textBoxYear.Text, out year);
                int month = (int)numericUpDown1.Value;
                int day = (int)numericUpDown2.Value;

                if (!int.TryParse(textBoxYear.Text, out year) || year < 0)
                {
                    label4.Text = "西暦年エラー";
                    return;
                }

                if (IsValidDate(year, month, day))
                {
                    int dayOfWeek = GetDayOfWeek(year, month, day);
                    string dayOfWeekName = GetDayOfWeekName(dayOfWeek);
                    label4.Text = dayOfWeekName;
                }
                else
                {
                    label4.Text = "無効な日付";
                }
            }
        }
 }

