using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter5MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("　　＊＊＊九九の表＊＊＊");
            Console.Write("　　｜");
            for (int i = 1; i <= 9; i++)
            {
                Console.Write($"{i,3}");
            }
            Console.WriteLine();
            for (int i = 0; i < 33; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
            int row = 1;
            for (int i = 1; i <= 9; i++)
            {
                Console.Write($"{row}　 ｜");
                row++;
                for (int j = 1; j <= 9; j++)
                {
                    Console.Write($"{i * j, 3}");
                }
                Console.WriteLine();
            }
            Console.WriteLine("終了するには何かキーを押してください。");
            Console.Read();
        }
    }
}
