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
            Console.WriteLine("   * * * 九九の表 * * *");
            Console.Write("   |");
            for (int i = 1; i <= 9; i++)
            {
                Console.Write($"{i,3}");
            }
            Console.WriteLine("\n--------------------------------");

            for (int x = 1; x <= 9; x++)
            {
                Console.Write($"{x}  |");
                for (int y = 1; y <= 9; y++)
                {
                    Console.Write($"{x * y,3}");
                }
                Console.Write('\n');
            }

            Console.WriteLine("\n終了するには何かキーを押してください。");
            Console.Read();
        }
    }
}
