using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 第４章_練習問題
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //int tosi = (int)textBox1.Text;
            int tuki = (int)numericUpDown1.Value;
            int hi = (int)numericUpDown2.Value;


        }

        private int Day(int tosi, int tuki, int hi)
        {
            if(tuki == 1 || tuki == 2)
            //1月か2月の時は
            {
                tosi--;//年を前年にして
                tuki += 12;//プラス12しないとダメ。
            }

            //教科書に合った式
            return (5 * tosi / 4 - tosi / 100 + tosi / 400 + (26 * tuki + 16) / 10 + hi % 7);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
        private bool UruYear(int year)
        {
            //うるう年はtrue
            bool rc = false;
            string yobi = null;

            year = int.Parse(textBox1.Text);
            label4.Text = yobi;


            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        rc = true;
                    }
                    else
                    {
                        rc = false;
                    }
                }
                else
                {
                    rc = true;
                }
            }
            else
            {
                rc = false;
            }

            return rc;
        }


        private bool Yobi(int tosi, int tuki, int hi)
        {

            bool rc = true;

            if (tuki < 1 || tuki > 12 || hi < 1)
                rc = false;
            else if (tuki == 1 || tuki == 3 || tuki == 5 || tuki == 7 ||
                tuki == 8 || tuki == 10 || tuki == 12)
            {
                if (hi > 31)
                    rc = false;
            }
            else if (tuki == 4 || tuki == 6 || tuki == 9 || tuki == 11)
            {
                if (hi > 30)
                    rc = false;
            }
            else
            {
                if (UruYear(tosi) == true)
                {
                    if (hi > 29)
                        rc = false;
                }
                else
                {
                    if (hi > 28)
                        rc = false;
                }
            }

            return rc;
        }
        // 「曜日算出ボタン」クリックのイベントハンドラ
        private void ButtonGetWeek_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int tosi) != true || tosi < 0)
            {//テキストボックス１に入った年が現在の年よりも上
                label4.Text = "西暦年エラー";
                return;
            }

            int tuki = (int)numericUpDown1.Value;
            int hi = (int)numericUpDown2.Value;

            if (Yobi(tosi, tuki, hi) == false)
            {
                label4.Text = "あり得ない日付";
                return;
            }
            int week = Day(tosi, tuki, hi);

            switch (week)
            {
                case 0:
                    label4.Text = "日曜日です";
                    break;
                case 1:
                    label4.Text = "月曜日です";
                    break;
                case 2:
                    label4.Text = "火曜日です";
                    break;
                case 3:
                    label4.Text = "水曜日です";
                    break;
                case 4:
                    label4.Text = "木曜日です";
                    break;
                case 5:
                    label4.Text = "金曜日です";
                    break;
                case 6:
                    label4.Text = "土曜日です";
                    break;
                default:
                    label4.Text = "算出エラーです";
                    break;
            }
        }

    private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
        }
    }
}
