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
            Console.WriteLine("　＊＊＊九九の表＊＊＊");
                Console.Write("  |");
                for(int j = 1; j <= 9; j++)
                {
                    Console.Write($"{j,3}");
                }
                Console.Write("\n");
            for(int h = 1;  h <=16; h++)
            {
                Console.Write("- ");
            }
            Console.Write("\n");
            for(int t = 1; t <= 9; t++)
            {
                Console.Write(t + " |");
                for(int y = 1; y <= 9; y++)
                {
                    int n = t * y;
                    Console.Write($"{n,3}");
                }
                Console.Write("\n");
            }
            Console.WriteLine("終了するには何かキーを押してください");
        }
    }
}
