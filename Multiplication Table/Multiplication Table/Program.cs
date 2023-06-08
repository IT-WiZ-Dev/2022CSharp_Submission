using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 9; // 九九のサイズ

            Console.WriteLine("*** 九九の表 ***");
          
            
            Console.Write("  ");
           
            for (int i = 1; i <= size; i++)
            {
                
                Console.Write($"{i,3}");
            }
            Console.WriteLine();
            Console.WriteLine("--------------------------------------");


            for (int i = 1; i <= size; i++)
            {
                Console.Write($"{i,2}|");
                for (int j = 1; j <= size; j++)
                {
                    int result = i * j;
                    Console.Write($"{result,3}");
                }
                Console.WriteLine();
            }
        }
    }
}
