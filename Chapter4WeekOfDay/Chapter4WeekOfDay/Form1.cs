using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Linq;

namespace Chapter4WeekOfDay
{
    public partial class Form1 : Form
    {
        string[] arrDay = { "日", "月", "火", "水", "木", "金", "土" };
        int[] arrMaxDate = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            arrMaxDate[1] = 28;

            string yStg = textBoxYear.Text;
            //西暦が正しいかチェック
            if (yStg.Equals("") || !yStg.All(char.IsDigit))
            {
                labelW.Text = "西暦エラー";
                return;
            }
            int y = int.Parse(yStg);
            int m = (int)numericUpDownMonth.Value;
            int d = (int)numericUpDownDate.Value;
            //閏年かチェック
            if (y % 400 == 0)
            {
                arrMaxDate[1] = 29;
            }
            else if (y % 4 == 0 && y % 100 != 0)
            {
                arrMaxDate[1] = 29;
            }

            //妥当性チェック
            if (d > arrMaxDate[m - 1])
            {
                labelW.Text = "あり得ない日付";
                return;
            }



            if (m <= 2)
            {
                y--;
                m += 12;
            }
            int w = (5 * y / 4 - y / 100 + y / 400 + (26 * m + 16) / 10 + d) % 7;
            labelW.Text = arrDay[w] + "曜日です";
        }

    }
}
