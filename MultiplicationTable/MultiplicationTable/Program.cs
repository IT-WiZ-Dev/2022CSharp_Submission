using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("   * * * 九九の表 * * *   ");

            Console.Write("   |");
            for (int i = 1; i <= 9; i++)
            {
                Console.Write("{0,3}", i);
            }
            Console.WriteLine();
            Console.WriteLine(new string('-', 32));

            for (int j = 1; j <= 9; j++)
            {
                Console.Write(j);
                Console.Write("  |");

                for (int k = 1; k <= 9; k++)
                {
                    Console.Write("{0,3}", j * k);
                }

                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}

