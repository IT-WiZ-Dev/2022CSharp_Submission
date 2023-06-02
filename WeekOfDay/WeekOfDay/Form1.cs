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

        /*
        private string DayError(int Month , int Day)
        {
            string result;
            bool Uru;

            //閏年を判別する
            if (0 == Year % 4 && 0 != Year % 100 || 0 == Year % 400)
                Uru = true;
            else
                Uru = false;

            //年月日の妥当性をチェック
            if (Month == 1 || Month == 3 || Month == 5 || Month == 7 || Month == 8 || Month == 10 || Month == 12)
                if (Day > 31)
                    result = "あり得ない日付";
            if (Month == 4 || Month == 6 || Month == 9 || Month == 11)
                if (Day > 30)
                    result = "あり得ない日付";
            if (Month == 2 && Uru == true)
                if (Day > 29)
                    result = "あり得ない日付";
            if (Month == 2 && Uru == false)
                if (Day > 28)
                    result = "あり得ない日付";
            return result;
        }
        */
        private void button1_Click(object sender, EventArgs e)
        {
            
            int Year;
            int Month;
            int Day;
            bool Uru;
            int Youbi;

            //西暦年エラー
            int nunber;
            bool sucsess = int.TryParse(textBoxYear.Text, out nunber);
            if (sucsess == false)
            {
                labelYoubi.Text = "西暦年エラー";
                return;
            }

            Year = int.Parse(textBoxYear.Text);
            Month = (int)numericUpDownMonth.Value;
            Day = (int)numericUpDownDay.Value;

            if(Year < 0)
            {
                labelYoubi.Text = "西暦年エラー";
                return;
            }
            

            //閏年を判別する
            if (0 == Year % 4 && 0 != Year % 100 || 0 == Year % 400)
                Uru = true;
            else
                Uru = false;

            //年月日の妥当性をチェック
            if (Month == 1 || Month == 3 || Month == 5 || Month == 7 || Month == 8 || Month == 10 || Month == 12)
            {
                if (Day > 31)
                {
                    labelYoubi.Text = "あり得ない日付"; 
                    return;
                }
                   
            }
            if (Month == 4 || Month == 6 || Month == 9 || Month == 11)
            {
                if (Day > 30)
                {
                    labelYoubi.Text = "あり得ない日付";
                    return;
                }
            }
            if (Month == 2 && Uru == true)
            {
                if (Day > 29)
                {
                    labelYoubi.Text = "あり得ない日付"; 
                    return;
                }
            }
            if (Month == 2 && Uru == false)
            {
                if (Day > 28)
                {
                    labelYoubi.Text = "あり得ない日付";
                    return;
                }
            }

            //前年の13、14月にする
            if (Month == 1 || Month == 2)
            {
                Month = Month + 12;
                Year = Year - 1;
            }

            //曜日を求める
            Youbi = ((5 * Year / 4) - (Year / 100) + (Year / 400) + ((26 * Month + 16) / 10) + (Day)) % 7;
            if (Youbi == 0)
                labelYoubi.Text = "日曜日です";
            else if (Youbi == 1)
                labelYoubi.Text = "月曜日です";
            else if (Youbi == 2)
                labelYoubi.Text = "火曜日です";
            else if (Youbi == 3)
                labelYoubi.Text = "水曜日です";
            else if (Youbi == 4)
                labelYoubi.Text = "木曜日です";
            else if (Youbi == 5)
                labelYoubi.Text = "金曜日です";
            else if (Youbi == 6)
                labelYoubi.Text = "土曜日です";

        }
    }
}
