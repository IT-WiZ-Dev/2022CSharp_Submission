using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 教科書第4章練習問題_WeekOfDay_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelYoubi.Text = "";
        }

       //文字列を整数値に変換
       //(仮因数)text：変換する文字列　val：変換した整列値
       //(返却値)なし
       private void TextToValue(string text, out int val)
        {
            if (int.TryParse(text, out val) == false)
                val = -1;
        }


        //うるう年かを判断するメソッド
        //(仮因数)seireki：西暦年 result：判断結果
        //(返却値)判定結果
        private void UrudoshiJudge(int seireki,out int urudoshi)
        {

        int amari1 = seireki % 4;
        int amari2 = seireki % 100;
        int amari3 = seireki % 400;

            if (amari1 == 0 && amari2 >= 1 || amari3 == 0)
                urudoshi = 1; //うるう年である

            else
                urudoshi = 0; //うるう年ではない
        }


        //年月日の妥当性をチェック
        //(仮因数)month：月　urudoshi：うるう年か否か　lastday：何日までか
        private void LastDayJudge(int month, int urudoshi, out int lastday)
        {
            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
                lastday = 31;
            else if (month == 2 && urudoshi == 1)  //2月でうるう年の時
                lastday = 29;
            else if(month == 2)  //2月でうるう年ではないとき
                lastday = 28;
            else
                lastday = 30;
        }


        //西暦年、月、日から曜日を求めるメソッド
        //(仮因数)seireki：西暦　month：月　day：日
        private string YoubiJudge(int seireki, int month, int day)
        {
            int YoubiNumber;
            string Youbi = "";

            if (month == 1 || month == 2)
            {
                seireki = seireki - 1;
                month = month + 12;
            }
            YoubiNumber = (5 * seireki / (4 - seireki) / 100 + seireki / 400 + (26 * month + 16) / 10 + day) % 7;  //曜日番号を求める計算
            {
                //ここから曜日番号から曜日を求める
                if (YoubiNumber == 0)
                    Youbi = "日曜日です";
                else if (YoubiNumber == 1)
                    Youbi = "月曜日です";
                else if (YoubiNumber == 2)
                    Youbi = "火曜日です";
                else if (YoubiNumber == 3)
                    Youbi = "水曜日です";
                else if (YoubiNumber == 4)
                    Youbi = "木曜日です";
                else if (YoubiNumber == 5)
                    Youbi = "金曜日です";
                else if (YoubiNumber == 6)
                    Youbi = "土曜日です";
            }
            return Youbi;

        }


        private void buttonYoubisansyutsu_Click(object sender, EventArgs e)
        {
            //西暦年を整数値に変換
            int seireki, month, day;
            TextToValue(textBoxSeireki.Text, out seireki);
            TextToValue(numericUpDownMonth.Text, out month);
            TextToValue(numericUpDownDay.Text, out day);

            //うるう年かを判断
            int urudoshi;
            UrudoshiJudge(seireki, out urudoshi);

            //年月日の妥当性をチェック
            int lastday;
            LastDayJudge(month, urudoshi, out lastday);

            //西暦、月、日から曜日を求める
            labelYoubi.Text = YoubiJudge(seireki, month, day);
        }
    }
}
