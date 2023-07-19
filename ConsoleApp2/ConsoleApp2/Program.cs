using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("    * * * ");
            Console.Write("九九の表");
            Console.Write(" * * *");
            Console.ReadLine();
            Console.Write("    |");

            for (int i = 1; i <= 9; i++)
            {
                Console.Write("  ");
                Console.Write(i);
            }
            
            Console.ReadLine();
            Console.Write("---------------------------------");

            for (int i = 1; i<= 9; i++)
            {
                Console.ReadLine();
                Console.Write(i);
                Console.Write("   |");
                for (int n = 1; n <= 9; n++)
                {

                    Console.Write("{0,3}", i * n);
                }
            }
            Console.ReadLine();

            Console.WriteLine("終了するには何かキーを押してください。");
            Console.Read();
        }
    }
}
