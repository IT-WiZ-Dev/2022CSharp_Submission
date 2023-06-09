using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ＊＊＊九九の表＊＊＊");
            Console.Write(" ");
            Console.Write("{0,3}","|");
            for (int a = 1; a <= 9; a++)
            {
                Console.Write("{0,3}",a);
            }
            Console.WriteLine(" ");
            Console.WriteLine("------------------------------");

            for (int i = 1; i <= 9; i++)
            {
                Console.Write(i);
                Console.Write("{0,3}", "|");
                for (int j = 1; j <= 9; j++)
                {
                    Console.Write($"{i * j,3}");
                }
                Console.WriteLine();
            }

            // プログラムの終了を待機する
            Console.ReadLine();
        }
    }
}
