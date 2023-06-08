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
            Console.WriteLine("  * * *九九の表* * * ");
            for (int i = 1; i <= 9; i++)
            {
                if (i == 1)
                {
                    Console.Write($"  |");
                }
                Console.Write($"{i,3}");
            }
            Console.WriteLine(" ");
            Console.WriteLine("-------------------------------");
            for (int i = 1; i <= 9; i++)
            {
                Console.Write($"{i} |");
                for (int j = 1; j <= 9; j++)
                {
                    Console.Write($"{i * j,3}");
                }
                Console.WriteLine();
            }

        }
    }
}
