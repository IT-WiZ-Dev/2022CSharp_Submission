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
            Console.Write("   * * * 九九の表 * * *");
            Console.Write('\n');
            Console.Write("   |  1  2  3  4  5  6  7  8  9");
            Console.Write('\n');
            Console.Write("_________________________________");
            Console.Write('\n');
            for (int i = 1; i <= 9; i++)
            {
                Console.Write("{0}   |",i);
                for(int j = 1; j <= 9; j++)
                {
                    Console.Write("{0,3}",i*j);
                }
                Console.Write('\n');
            }
            Console.Write('\n');

        }
    }
}
