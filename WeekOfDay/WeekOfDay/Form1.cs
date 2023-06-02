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
            ans.Text = "";


        }


        //メインボタンを押したとき
        private void button1_Click(object sender, EventArgs e)
        {
            //年月日を整列型に変換
            int year;
            int month = (int)NumericUpDown1.Value;
            int day = (int)NumericUpDown2.Value;

            //西暦年エラーチェック
            if (int.TryParse(text.Text, out year))
            {
                //int型に変換済み
            }
            else
            {
                ans.Text = "西暦年エラー";
                return;
            }

            if(year < 0)
            {
                ans.Text = "西暦年エラー";
                return;
            }

            //日付チェック
            if(ValCheck(year, month, day) == false)
            {
                ans.Text = "あり得ない日付";
                return;
            }


            //結果
            ans.Text = DayOfWeek(year, month, day);

        }



        //閏年かを判定するメソッド
        private Boolean UruCheck (int year)
        {
            int a = year / 4;
            int b = year / 100;
            int c = year / 400;

            if(a == 0 && b != 0)
            {
                return true;
            }

            else if(c == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        //年月日の妥当性チェック
        private Boolean ValCheck (int year, int month, int day)
        {
            switch(month)
            {
                case 1:
                    if(day >= 1 && day <= 31)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case 2:
                    //閏年の場合
                    if(UruCheck(year) == true)
                    {
                        if(day >= 1 && day <= 29)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    //閏年でない場合
                    else if(UruCheck(year) == false)
                    {
                        if (day >= 1 && day <= 28)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }

                case 3:
                    if (day >= 1 && day <= 31)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case 4:
                    if (day >= 1 && day <= 30)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case 5:
                    if (day >= 1 && day <= 31)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case 6:
                    if (day >= 1 && day <= 30)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case 7:
                    if (day >= 1 && day <= 31)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case 8:
                    if (day >= 1 && day <= 31)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case 9:
                    if (day >= 1 && day <= 30)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case 10:
                    if (day >= 1 && day <= 31)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case 11:
                    if (day >= 1 && day <= 30)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case 12:
                    if (day >= 1 && day <= 31)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                default:
                    return false;
            }
        }


        //曜日を見つけるメソッド
        private string DayOfWeek(int year, int month, int day)
        {

            int w = (5 * year / 4 - year / 100 + year / 400 + (26 * month + 16) / 10 + day) % 7;

            if(month == 1)
            {
                year = year - 1;
                w = (5 * year / 4 - year / 100 + year / 400 + (26 * 13 + 16) / 10 + day) % 7;
            }
            else if (month == 2)
            {
                year = year - 1;
                w = (5 * year / 4 - year / 100 + year / 400 + (26 * 14 + 16) / 10 + day) % 7;
            }


            switch (w)
            {
                case 0:
                    return "日曜日です";

                case 1:
                    return "月曜日です";

                case 2:
                    return "火曜日です";

                case 3:
                    return "水曜日です";

                case 4:
                    return "木曜日です";

                case 5:
                    return "金曜日です";

                case 6:
                    return "土曜日です";

                default:
                    return "";
            }
        }
    }
}
