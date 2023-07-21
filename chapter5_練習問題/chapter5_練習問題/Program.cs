using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter5_練習問題
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" " + "＊＊＊九九の表＊＊＊");
            Console.Write(" " + "｜");
            int n = 1;
            for (int i = 1; i<=9; i++)
            {
                Console.Write("{0,3}", n);
                n = n + 1;
            }
            Console.WriteLine(" ");
            for (int i = 1; i <= 32; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine(" ");
            //1の段
            Console.Write("1" +  "｜");
            int n_1 = 1;
            for (int i1 = 1; i1 <= 9; i1++)
            {
                Console.Write("{0,3}", n_1);
                n_1 = n_1 + 1;
            }
            Console.WriteLine(" ");

            //2の段
            Console.Write("2" + "｜");
            int n_2 = 2;
            for (int i2 = 1; i2 <= 9; i2++)
            {
                Console.Write("{0,3}", n_2);
                n_2 = n_2 + 2;
            }
            Console.WriteLine(" ");

            //3の段
            Console.Write("3" + "｜");
            int n_3 = 3;
            for (int i3 = 1; i3 <= 9; i3++)
            {
                Console.Write("{0,3}", n_3);
                n_3 = n_3 + 3;
            }
            Console.WriteLine(" ");

            //4の段
            Console.Write("4" + "｜");
            int n_4 = 4;
            for (int i4 = 1; i4 <= 9; i4++)
            {
                Console.Write("{0,3}", n_4);
                n_4 = n_4 + 4;
            }
            Console.WriteLine(" ");

            //5の段
            Console.Write("5" + "｜");
            int n_5 = 5;
            for (int i5 = 1; i5 <= 9; i5++)
            {
                Console.Write("{0,3}", n_5);
                n_5 = n_5 + 5;
            }
            Console.WriteLine(" ");

            //6の段
            Console.Write("6" + "｜");
            int n_6 = 6;
            for (int i6 = 1; i6 <= 9; i6++)
            {
                Console.Write("{0,3}", n_6);
                n_6 = n_6 + 6;
            }
            Console.WriteLine(" ");

            //7の段
            Console.Write("7" + "｜");
            int n_7 = 7;
            for (int i7 = 1; i7 <= 9; i7++)
            {
                Console.Write("{0,3}", n_7);
                n_7 = n_7 + 7;
            }
            Console.WriteLine(" ");

            //8の段
            Console.Write("8" + "｜");
            int n_8 = 8;
            for (int i8 = 1; i8 <= 9; i8++)
            {
                Console.Write("{0,3}", n_8);
                n_8 = n_8 + 8;
            }
            Console.WriteLine(" ");

            //9の段
            Console.Write("9" + "｜");
            int n_9 = 9;
            for (int i9 = 1; i9 <= 9; i9++)
            {
                Console.Write("{0,3}", n_9);
                n_9 = n_9 + 9;
            }
            Console.WriteLine(" ");
            Console.ReadKey();
        }
    }
}
