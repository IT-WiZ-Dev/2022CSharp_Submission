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
            Console.WriteLine("　　   ***九九の表***　　");
            Console.WriteLine("   |  1  2  3  4  5  6  7  8  9");
            Console.WriteLine("--------------------------------");
            for (int i = 1;i <= 9; i++)
            {
                Console.Write(i + "  |");
                for (int j = 1;j <= 9;j++)
                {
                    if (j == 9)
                    {
                        if (i*j >= 10)
                        {
                            Console.WriteLine(" " + i * j);
                        }
                        else
                        {
                            Console.WriteLine("  " + i * j);
                        }
                    }
                    else
                    {
                        if (i*j >= 10)
                        {
                            Console.Write(" " + i * j);
                        }
                        else
                        {
                            Console.Write("  " + i * j);
                        }
                    }
                }
            }
                    
        }
    }
}
