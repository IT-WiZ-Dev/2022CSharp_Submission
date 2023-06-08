using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int val;
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    val = i * j;
                    System.Console.Write("{0,3}", val.ToString() + " ");
                }
                System.Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
