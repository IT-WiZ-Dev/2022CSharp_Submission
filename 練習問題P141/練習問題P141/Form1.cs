using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 練習問題P141
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Y = textBoxseireki.Text;           //テキストボックスからstring型でテキストを受け取る

            int Year = int.Parse(textBoxseireki.Text);//テキストボックスからint型で西暦年を受け取る
            int month = (int)numericmonth.Value;　　　//Numericから月をint型で受け取る
            int Day = (int)numericday.Value;　　　　　//Numericから日をint型で受け取る

            bool uruu;　　　　　　　　　　　　　　　　//閏年かどうか判定するメソッドの結果を格納する変数

            int w = 0;　　　　　　　　　　　　　　　　//曜日を求める公式の結果を格納する変数

            string[] youbi = new string[7];　　　　　 //各曜日をstrig型で格納している配列
            youbi[0] = "日曜日";
            youbi[1] = "月曜日";
            youbi[2] = "火曜日";
            youbi[3] = "水曜日";
            youbi[4] = "木曜日";
            youbi[5] = "金曜日";
            youbi[6] = "土曜日";
            string[] arr = { "a","b"};
            string Result;　　　　　　　　　　　　　　//配列と公式の結果を使って出した結果を格納するメソッド

            bool isNumer = int.TryParse(Y, out _);　　//テキストボックスからstring型で受け取ったテキストをint型に変換できるか否かを判定

            if(!isNumer)　　　　　　　　　　　//int型に変換出来なかったら西暦年エラーと表示
            {
                labelResult.Text = "西暦年エラー";
            }


            //閏年かどうか判定
            if (Year%400 == 0)
            {
                uruu = true;
            }else if (Year/4 == 0 && Year/100 == 0)
            {
                uruu = true;
            }
            else
            {
                uruu = false;
            }
            
            //年月日の妥当性チェックを行うメソッド
            if(month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                if(Day <= 31)
                {
                    if (month == 1)
                    {
                        Year = Year - 1;
                        month = month + 12;
                        w = (Year * 5 / 4 - Year / 100 + Year / 400 + (month * 26 + 16) / 10 + Day) % 7;
                    }
                    else
                    {
                        w = (Year * 5 / 4 - Year / 100 + Year / 400 + (month * 26 + 16) / 10 + Day) % 7;
                    }
                }
                else
                {
                    labelResult.Text = "ありえない日付";
                }
                    
            }else if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                if(Day <= 30)
                {
                    w = (Year * 5 / 4 - Year / 100 + Year / 400 + (month * 26 + 16) / 10 + Day) % 7;
                }
                else
                {
                    labelResult.Text = "ありえない日付";
                }
            }else if (month == 2 && uruu == true)
            {
                if(Day <= 29)
                {
                        Year = Year - 1;
                        month = month + 12;
                        w = (Year * 5 / 4 - Year / 100 + Year / 400 + (month * 26 + 16) / 10 + Day) % 7;
                }
                else
                {
                    labelResult.Text = "ありえない日付";
                }
            }else if (month == 2 && uruu == false)
            {
                if(Day <= 28)
                {
                    Year = Year - 1;
                    month = month + 12;
                    w = (Year * 5 / 4 - Year / 100 + Year / 400 + (month * 26 + 16) / 10 + Day) % 7;
                }
                else
                {
                    labelResult.Text = "ありえない日付";
                }
            }
            else
            {
                labelResult.Text = "ありえない日付";
            }

           
            labelResult.Text = youbi[w] + "です";


           


        }
    }
}
