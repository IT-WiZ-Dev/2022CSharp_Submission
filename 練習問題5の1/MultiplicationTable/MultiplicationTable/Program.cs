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
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    Console.Write((i * j).ToString().PadLeft(2) + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
