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
        private void Urudosi(string year, int month, int day)
        {
            string a = textBox1.Text;
            int b = (int)numericUpDown1.Value;
            int c = (int)numericUpDown2.Value;
            int d = int.Parse(a);

            bool result = false;
            int daymax = 0;

            if (d % 400 == 0)
                result = true;
            else if (b % 4 == 0 && b % 100 != 0)
                result = true;
        
            switch (b)
            {
                case 1:
                    daymax = 31;
                    break;
                case 2:
                    if (result == true)
                        daymax = 29;
                    else
                        daymax = 28;
                    break;
                case 3:
                    daymax = 31;
                    break;
                case 4:
                    daymax = 30;
                    break;
                case 5:
                    daymax = 31;
                    break;
                case 6:
                    daymax = 30;
                    break;
                case 7:
                    daymax = 31;
                    break;
                case 8:
                    daymax = 31;
                    break;
                case 9:
                    daymax = 30;
                    break;
                case 10:
                    daymax = 31;
                    break;
                case 11:
                    daymax = 30;
                    break;
                case 12:
                    daymax = 31;
                    break;
            }

            if (b == 1)
                b = 13;
            else if (b == 2)
                b = 14;

            int w = (5 * d / 4 - d / 100 + d / 400 + (26 * b + 16) / 10 + c) % 7;

            int i = 0;
            bool canConvert = int.TryParse(a, out i);
            
        }
      
        private void button1_Click(int b, int c, int d, int daymax, bool canConvert, int w)
        {
            if(w == 0)
            {
                label4.Text = "日曜日です";
            }
            else if(w == 1)
            {
                label4.Text = "月曜日です";
            }
            else if(w == 2)
            {
                label4.Text = "火曜日です";
            }
            else if(w == 3)
            {
                label4.Text = "水曜日です";
            }
            else if(w == 4)
            {
                label4.Text = "木曜日です";
            }
            else if(w == 5){
                label4.Text = "金曜日です";
            }
            else if(w == 6)
            {
                label4.Text = "土曜日です";
            }

            if (d <= 0 || canConvert == false)
                label4.Text = "西暦年エラー";

            if (c > daymax)
                label4.Text = "あり得ない日付";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Text = "";
        }
    }
}
