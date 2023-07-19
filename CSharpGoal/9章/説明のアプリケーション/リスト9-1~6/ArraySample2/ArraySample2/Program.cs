using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySample2
{
    class Program
    {
        static void Main(string[] args)
        {
            int no;

            Console.WriteLine("確認したい例の番号を入力してください。");
            Console.WriteLine("1: Lengthプロパティ");
            Console.WriteLine("2: Rankプロパティ");
            Console.WriteLine("3: Clearメソッド");
            Console.WriteLine("4: Sortメソッド");
            Console.WriteLine("5: Reverseメソッド");
            Console.WriteLine("6: Copyメソッド");
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
                        Console.WriteLine("● Arrayクラス Lengthプロパティの例");
                        ArrayLengthExample();
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.WriteLine("● Arrayクラス Rankプロパティの例");
                        ArrayRankExample();
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.WriteLine("● Arrayクラス Clearメソッドの例");
                        ArrayClearExample();
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.WriteLine("● Arrayクラス Sortメソッドの例");
                        ArraySortExample();
                        Console.WriteLine();
                        break;
                    case 5:
                        Console.WriteLine("● Arrayクラス Reverseメソッドの例");
                        ArrayReverseExample();
                        Console.WriteLine();
                        break;
                    case 6:
                        Console.WriteLine("● Arrayクラス Copyメソッドの例");
                        ArrayCopyExample();
                        Console.WriteLine();
                        break;
                }
            } while (no != 9);

            Console.WriteLine("終了するには何かキーを押してください。");
            Console.Read();
        }

        static void ArrayLengthExample()
        {
            double[] x1 = new double[] { 1.1, 1.2, 1.3 };
            for (int i = 0; i < x1.Length; i++)
                Console.Write(x1[i] + " ");
            Console.WriteLine();
        }

        static void ArrayRankExample()
        {
            int[] n1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };               // 1次元配列
            int[,] n2 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };  // 2次元配列
            int r1 = n1.Rank;
            int r2 = n2.Rank;

            Console.WriteLine("r1 = " + r1);
            Console.WriteLine("r2 = " + r2);
        }

        static void ArrayClearExample()
        {
            int[] n1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // 配列n1をn1[3]から4個分初期化
            Array.Clear(n1, 3, 4);
            for (int i = 0; i < n1.Length; i++)
                Console.Write(n1[i] + " ");
            Console.WriteLine();

            // 配列n1の全要素を初期化
            Array.Clear(n1, 0, n1.Length);
            for (int i = 0; i < n1.Length; i++)
                Console.Write(n1[i] + " ");
            Console.WriteLine();
        }

        static void ArraySortExample()
        {
            int[] n1 = { 28, 56, 23, 79, 12, 43, 93, 81, 54, 73 };

            // 配列n1をn1[3]から4個分並び替え
            Array.Sort(n1, 3, 4);
            for (int i = 0; i < n1.Length; i++)
                Console.Write(n1[i] + " ");
            Console.WriteLine();

            // 配列n1の全要素を昇順に並びかえ
            Array.Sort(n1);
            for (int i = 0; i < n1.Length; i++)
                Console.Write(n1[i] + " ");
            Console.WriteLine();
        }

        static void ArrayReverseExample()
        {
            int[] n1 = { 28, 56, 23, 79, 12, 43, 93, 81, 54, 73 };

            // 配列n1をn1[3]から4個分反転
            Array.Reverse(n1, 3, 4);
            for (int i = 0; i < n1.Length; i++)
                Console.Write(n1[i] + " ");
            Console.WriteLine();

            // 降順に並び替える
            //配列n1の全要素を昇順に並びかえてから全要素を反転
            Array.Sort(n1);
            Array.Reverse(n1);
            for (int i = 0; i < n1.Length; i++)
                Console.Write(n1[i] + " ");
            Console.WriteLine();
        }

        static void ArrayCopyExample()
        {
            int[] n1 = { 28, 56, 23, 79, 12, 43, 93, 81, 54, 73 };
            int[] n2 = new int[5];

            // n1の要素を先頭から5個分、n2にコピー
            Array.Copy(n1, n2, 5);
            for (int i = 0; i < n2.Length; i++)
                Console.Write(n2[i] + " ");
            Console.WriteLine();

            // n1の要素をn1[3]から5個分、n2の先頭にコピー
            Array.Copy(n1, 3, n2, 0, 5);
            for (int i = 0; i < n2.Length; i++)
                Console.Write(n2[i] + " ");
            Console.WriteLine();
        }
    }
}
