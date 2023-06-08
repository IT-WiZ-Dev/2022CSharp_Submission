using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{

    class Program
    {
        static void Main()
        {
            // ヘッダーの表示
            Console.WriteLine("  |  1  2  3  4  5  6  7  8  9");
            Console.WriteLine("--------------------------------");

            // 九九の表を表示
            for (int i = 1; i <= 9; i++)
            {
                Console.Write($"{i} |");

                for (int j = 1; j <= 9; j++)
                {
                    int result = i * j;
                    Console.Write($" {result,2}");
                }

                Console.WriteLine();
                
            }

            Console.ReadKey();
        }
    }
}






  