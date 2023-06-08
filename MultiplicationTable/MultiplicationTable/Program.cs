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
            Console.Write("   ");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("* ");
            }
            Console.Write("九九の表");

            for (int i = 0; i < 3; i++)
            {
                Console.Write(" *");
            }
            Console.Write("\n");
            Console.Write("   |");

            for (int i = 1; i < 10; i++)
            {
                Console.Write("{0,3}",i);
            }
            Console.Write("\n");
            for (int i = 0; i < 32; i++)
            {
                Console.Write("-");
            }
            Console.Write("\n");
            for (int i = 1; i < 10; i++)
            {
                Console.Write(i+ "  |");
                for (int j = 1; j < 10; j++)
                {
                    Console.Write("{0,3}", i*j);
                }
                Console.Write("\n");
            }
            Console.Write("\n");
            Console.Write("終了するには何かキーを押してください。");
            Console.Read();
        }
    }
}
