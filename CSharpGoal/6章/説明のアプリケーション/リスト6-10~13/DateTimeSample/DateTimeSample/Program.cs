using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeSample
{
    class Program
    {
        static void Main(string[] args)
        {
            int no;

            Console.WriteLine("確認したいサンプルの番号を入力してください。");
            Console.WriteLine("1: DateTime プロパティ");
            Console.WriteLine("2: DateTime Addメソッド");
            Console.WriteLine("3: DateTime Perseメソッド");
            Console.WriteLine("4: DateTime ToXxxxXxxxStringメソッド");
            Console.WriteLine("5: DateTime ToStringメソッド");
            Console.WriteLine("9: 終了");

            do
            {
                Console.Write("番号＞ ");
                try
                {
                    string s = Console.ReadLine();
                    no = int.Parse(s);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                    break;
                }

                switch (no)
                {
                    case 1:
                        Console.WriteLine("● DateTime プロパティの例");
                        DateTimePropertyExample();
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.WriteLine("● DateTime Addメソッドの例");
                        DateTimeAddExample();
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.WriteLine("● DateTime Perseメソッドの例");
                        DateTimeParseExample();
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.WriteLine("● DateTime ToXxxxXxxxStringメソッドの例");
                        DateTimeToXxxxXxxxStringExample();
                        Console.WriteLine();
                        break;
                    case 5:
                        Console.WriteLine("● DateTime ToStringメソッドの例");
                        DateTimeToStringExample();
                        Console.WriteLine();
                        break;
                }
            } while (no != 9);

            Console.WriteLine("\n終了するには何かキーを押してください。");
            Console.Read();
        }

        // リスト6-10
        static void DateTimePropertyExample()
        {
            Console.WriteLine("今日の日付：" + DateTime.Today);
            Console.WriteLine("現在の日付と日時：" + DateTime.Now);
            // 現在の日付と日時を取得する
            DateTime now = DateTime.Now;
            Console.WriteLine("年 = " + now.Year);
            Console.WriteLine("月 = " + now.Month);
            Console.WriteLine("日 = " + now.Day);
            Console.WriteLine("時 = " + now.Hour);
            Console.WriteLine("分 = " + now.Minute);
            Console.WriteLine("秒 = " + now.Second);
            Console.WriteLine("曜日 = " + now.DayOfWeek);
        }

        // リスト6-11
        static void DateTimeAddExample()
        {
            DateTime now = DateTime.Now;                    //現在の日時を得る
            Console.WriteLine(now);                         //現在日時の表示
            TimeSpan addSpan = new TimeSpan(10, 10, 10);    //TimeSpan（時,分,秒）
            DateTime answer = now.Add(addSpan);             //TimeSpanの加算
            Console.WriteLine(answer);
            addSpan = new TimeSpan(1, 1, 1, 1);             //TimeSpan（日,時,分,秒）
            answer = now.Add(addSpan);                      //TimeSpanの加算
            Console.WriteLine(answer);
        }

        // ページ数の都合で割愛
        static void DateTimeParseExample()
        {
            DateTime dt = DateTime.Parse("2019/07/07 10:10:10");
            Console.WriteLine(dt);
        }

        // リスト6-12
        static void DateTimeToXxxxXxxxStringExample()
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToShortTimeString());
        }

        // リスト6-13
        static void DateTimeToStringExample()
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToString());
            Console.WriteLine("D = " + now.ToString("D"));
            Console.WriteLine("T = " + now.ToString("T"));
            Console.WriteLine("d = " + now.ToString("d"));
            Console.WriteLine("t = " + now.ToString("t"));
            Console.WriteLine("m = " + now.ToString("m"));
        }
    }
}
