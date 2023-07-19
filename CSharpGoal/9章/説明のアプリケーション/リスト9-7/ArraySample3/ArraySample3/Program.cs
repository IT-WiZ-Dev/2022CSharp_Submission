using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySample3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] n3 = new int[2, 3, 4];
            int m = 1;
            for (int i = 0; i < n3.GetLength(0); i++)
            {
                for (int j = 0; j < n3.GetLength(1); j++)
                {
                    for (int k = 0; k < n3.GetLength(2); k++)
                    {
                        n3[i, j, k] = m++;
                    }
                }
            }

            for (int i = 0; i < n3.GetLength(0); i++)
            {
                for (int j = 0; j < n3.GetLength(1); j++)
                {
                    for (int k = 0; k < n3.GetLength(2); k++)
                        Console.Write($"({i}, {j}, {k}) = {n3[i, j, k]}\t");
                    Console.Write("\n");
                }
                Console.Write("\n");
            }

            Console.WriteLine("\n終了するには何かキーを押してください。");
            Console.Read();
        }
    }
}