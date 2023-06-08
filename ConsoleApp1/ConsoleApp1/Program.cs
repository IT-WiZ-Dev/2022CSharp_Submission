using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ***九九の表*** ");

            Console.Write("\t");
            for (int i = 1; i <= 9; i++)
            {
                Console.Write("{0}\t", i);
            }
            Console.WriteLine();

            Console.WriteLine("----------------------------------------------------------------------------");

            // 九九の表を作成するためのループ
            for (int i = 1; i <= 9; i++)
            {
                Console.Write("{0} |\t", i);
                for (int j = 1; j <= 9; j++)
                {
                    Console.Write("{0,3}\t", i * j);
                }
                Console.WriteLine();
            }
            Console.WriteLine("終了するには何かキーを押してください。");
            Console.ReadLine();
        }
    }
}
