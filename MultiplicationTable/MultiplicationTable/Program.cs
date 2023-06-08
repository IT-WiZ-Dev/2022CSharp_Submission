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
            Console.WriteLine("＊＊＊九九の表＊＊＊");

            Console.Write(" ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("  {0}", i);
            }
            Console.Write("\n");

            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0} ", i);
                for (int j = 0; j < 10; j++)
                {
                    if (i * j < 10)
                    {
                        Console.Write(" {0} ", i * j);
                    }
                    else
                    {
                        Console.Write("{0} ", i * j);
                    }
                }
                Console.Write("\n");
            }
        }
    }
}
