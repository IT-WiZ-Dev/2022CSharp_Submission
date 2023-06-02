using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeeekOfDay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void listBoxMonth_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelYoubi_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelYoubi.Text = "";
        }

        private int uruJuge(string text)
        {
            if (!int.TryParse(text, out int years))
            {
                return -1; // エラーを示す値を返す
            }

            int a = years % 4;
            int b = years % 100;
            int c = years % 400;
            int x = 0;
            if (a == 0 && b != 0 || c == 0)
            {
                x = 1;
            }
            return x;
        }


        private string monthdaysJuge(int month, int days, int y)
        {
            int d = 0;
            string g = "";
            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                d = 31;
            }
            else if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                d = 30;
            }
            else if (month == 2 && y == 1)
            {
                d = 29;
            }
            else if (month == 2 && y == 0)
            {
                d = 28;
            }
            if (days > d)
            {
                g = "あり得ない日付";
            }
            return g;
        }

        private string youbiJuge(int years, int month, int days)
        {
            int w = 0;
            if (month == 1 || month == 2)
            {
                years = years - 1;
                month = month + 12;
            }
            w = (5 * years
                / 4 - years / 100 + years / 400 + (26 * month + 16) / 10 + days) % 7;

            string[] daysOfWeek = { "日曜日です", "月曜日です", "火曜日です", "水曜日です", "木曜日です", "金曜日です", "土曜日です" };
            string k = daysOfWeek[w];
            return k;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            //うるう年判定
            int y;
            y = uruJuge(textBoxYear.Text);

            if (!int.TryParse(textBoxYear.Text, out int years) || years <= 0)
            {
                labelYoubi.Text = "西暦年エラー";
                return;
            }

            int month = (int)numericUpDownMonth.Value;
            int days = (int)numericUpDownDay.Value;
            string f;
            f = monthdaysJuge(month, days, y);
            labelYoubi.Text += f;

            if (labelYoubi.Text == "")
            {
                string k = "";
                k = youbiJuge(years, month, days);
                labelYoubi.Text = k;
            }


        }
    }
}
