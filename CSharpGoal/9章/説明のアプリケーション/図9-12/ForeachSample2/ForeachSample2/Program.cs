using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachSample2
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1[] number = {
                new Class1(123),
                new Class1(456),
                new Class1(789),
                new Class1(1000)
            };

            foreach (Class1 n in number)
            {
                n.Number *= 2;
            }

            foreach (Class1 n in number)
            {
                Console.WriteLine($"{n.Number}");
            }

            Console.WriteLine("\n終了するには何かキーを押してください。");
            Console.Read();
        }
    }
}
