using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathSample
{
    class Program
    {
        static void Main(string[] args)
        {
            int no;

            Console.WriteLine("確認したい例の番号を入力してください。");
            Console.WriteLine("1: PIフィールド");
            Console.WriteLine("2: Absメソッド");
            Console.WriteLine("3: Ceilingメソッド");
            Console.WriteLine("4: Floorメソッド");
            Console.WriteLine("5: Powメソッド");
            Console.WriteLine("6: Sqrtメソッド");
            Console.WriteLine("7: Sin，Cos，Tan メソッド");
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
                        Console.WriteLine("● Mathクラス PIフィールドの例");
                        PIExample();
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.WriteLine("● Mathクラス Absメソッドの例");
                        AbsExample();
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.WriteLine("● Mathクラス Ceilingメソッドの例");
                        CeilingExample();
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.WriteLine("● Mathクラス Floorメソッドの例");
                        FloorExample();
                        Console.WriteLine();
                        break;
                    case 5:
                        Console.WriteLine("● Mathクラス Powメソッドの例");
                        PowExample();
                        Console.WriteLine();
                        break;
                    case 6:
                        Console.WriteLine("● Mathクラス Sqrtメソッドの例");
                        SqrtExample();
                        Console.WriteLine();
                        break;
                    case 7:
                        Console.WriteLine("● Mathクラス Sin，Cos，Tan メソッドの例");
                        SinCosTanExample();
                        Console.WriteLine();
                        break;
                }
            } while (no != 9);

            Console.WriteLine("\n終了するには何かキーを押してください。");
            Console.Read();
        }

        static void PIExample()
        {
            double r = 3.4;
            double s = r * r * Math.PI;

            Console.WriteLine($"半径3.4の円の面積 = {s}");
        }

        // 紙面スペースの関係で割愛
        static void AbsExample()
        {
            int a = Math.Abs(-14);
            double x = Math.Abs(14.2);

            Console.WriteLine($"-14の絶対値 = {a}");
            Console.WriteLine($"14.2の絶対値 = {x}");
        }

        // 紙面スペースの関係で割愛
        static void CeilingExample()
        {
            double x1 = Math.Ceiling(14.2);
            double x2 = Math.Ceiling(-14.2);
            Console.WriteLine($"14.2以上の最小の整数値 = {x1}");
            Console.WriteLine($"-14.2以上の最小の整数値 = {x2}");
        }

        // 紙面スペースの関係で割愛
        static void FloorExample()
        {
            double x1 = Math.Floor(14.2);
            double x2 = Math.Floor(-14.2);
            Console.WriteLine($"14.2以下の最大の整数値 = {x1}");
            Console.WriteLine($"-14.2以下の最大の整数値 = {x2}");
        }

        static void PowExample()
        {
            double x = Math.Pow(2.0, 10.0);
            Console.WriteLine($"2の10乗 = {x}");
        }

        static void SqrtExample()
        {
            double x = Math.Sqrt(2.0);
            Console.WriteLine($"2の平方根 = {x}");
        }

        static void SinCosTanExample()
        {
            double angle = 30;
            double radians = angle * (Math.PI / 180);
            double sin = Math.Sin(radians);
            double cos = Math.Cos(radians);
            double tan = Math.Tan(radians);

            Console.WriteLine($"30度のサイン値 = {sin}");
            Console.WriteLine($"30度のコサイン値 = {cos}");
            Console.WriteLine($"30度のタンジェント値 = {tan}");
        }
    }
}
