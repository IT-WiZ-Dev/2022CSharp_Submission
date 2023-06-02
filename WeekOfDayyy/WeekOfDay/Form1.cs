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

        private void button1_Click(object sender, EventArgs e)
        {
            int nen;
            int tuki;
            int niti;
            nen = int.Parse(textBox1.Text);
            tuki = (int)numericUpDown1.Value;
            niti = (int)numericUpDown2.Value;

            // 月日の妥当性チェック
            if (tuki < 1 || tuki > 12 || niti < 1 || niti > DateTime.DaysInMonth(nen, tuki))
            {
                MessageBox.Show("ありえん");
                return;
            }


            // ツェラーの公式
            if (tuki < 3)
            {
                tuki += 12;
                nen--;
            }
            int w = (niti + 2 * tuki + 3 * (tuki + 1) / 5 + nen + nen / 4 - nen / 100 + nen / 400 + 2) % 7;
            string[] weekdays = { "土曜日", "日曜日", "月曜日", "火曜日", "水曜日", "木曜日", "金曜日" };
            string weekday = weekdays[w];

            label4.Text = weekday;
        }
    }
}
