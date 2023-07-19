﻿using System;
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
    public partial class FormWeek : Form
    {
        public FormWeek()
        {
            InitializeComponent();
        }

        //「曜日フォーム」ロードのイベントハンドラ
        private void FormWeek_Load(object sender, EventArgs e)
        {
            // 曜日のクリア
            labelWeek.Text = "";
        }


        // 曜日を求める
        //（仮引数）y:西暦年　m:月　d:日　
        //（返却値）曜日 0=日 1=月 2=火 3=水 4=木 5=金 6=土
        private int WeekOfDay(int y, int m, int d)
        {
            if (m == 1 || m == 2)
            {
                y--;
                m += 12;
            }

            return (5 * y / 4 - y / 100 + y / 400 + (26 * m + 16) / 10 + d) % 7;
        }

        // 閏年の判定
        //（引数） y:西暦年
        //（戻り値）true=閏年　false=閏年以外
        private bool IsLeapYear(int y)
        {
            bool rc = false;

            if (y % 4 == 0 && (y % 100 != 0 || y % 400 == 0))
            {
                rc = true;
            }

            return rc;
        }

        // 年月日の妥当性チェック
        //（引数） y:西暦年　m:月　d:日
        //（戻り値）true=妥当性OK　false=妥当性NG　
        private bool CheckDate(int y, int m, int d)
        {
            bool rc = true;

            if (m < 1 || m > 12 || d < 1)
                rc = false;
            else if (m == 1 || m == 3 || m == 5 || m == 7 ||
                m == 8 || m == 10 || m == 12)
            {
                if (d > 31)
                    rc = false;
            }
            else if (m == 4 || m == 6 || m == 9 || m == 11)
            {
                if (d > 30)
                    rc = false;
            }
            else
            {
                if (IsLeapYear(y) == true)
                {
                    if (d > 29)
                        rc = false;
                }
                else
                {
                    if (d > 28)
                        rc = false;
                }
            }

            return rc;
        }

        // 「曜日算出ボタン」クリックのイベントハンドラ
        private void ButtonGetWeek_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxYear.Text, out int year) != true || year < 0)
            {
                labelWeek.Text = "西暦年エラー";
                return;
            }

            int month = (int)numericUpDownMonth.Value;
            int day = (int)numericUpDownDay.Value;

            if (CheckDate(year, month, day) == false)
            {
                labelWeek.Text = "あり得ない日付";
                return;
            }
            int week = WeekOfDay(year, month, day);

            switch (week)
            {
                case 0:
                    labelWeek.Text = "日曜日です";
                    break;
                case 1:
                    labelWeek.Text = "月曜日です";
                    break;
                case 2:
                    labelWeek.Text = "火曜日です";
                    break;
                case 3:
                    labelWeek.Text = "水曜日です";
                    break;
                case 4:
                    labelWeek.Text = "木曜日です";
                    break;
                case 5:
                    labelWeek.Text = "金曜日です";
                    break;
                case 6:
                    labelWeek.Text = "土曜日です";
                    break;
                default:
                    labelWeek.Text = "算出エラーです";
                    break;
            }
        }
    }
}
