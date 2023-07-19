using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachSample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = { 123, 456, 789, 1000 };

            foreach (int n in number)
            {
                Console.Write($"{n} ");
            }

            Console.WriteLine("\n終了するには何かキーを押してください。");
            Console.Read();
        }
    }
}
