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
            Console.Write("     ");
            for (int i = 1; i <= 9; i++)
            {
                Console.Write("{0,-4}", i); // 上の行に1から9の表示
            }
            Console.WriteLine();

            for (int i = 1; i <= 9; i++)
            {
                Console.Write("{0,-4}", i); // 左の列に1から9の表示

                for (int j = 1; j <= 9; j++)
                {
                    Console.Write("{0,-4}", i * j);
                }
                Console.WriteLine();
            }

        }
    }
}
