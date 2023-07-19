using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSample5
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 c1 = new Class1();
            Class2 c2 = new Class2();

            c1.M();
            c2.M();

            Console.WriteLine("\n終了するには何かキーを押してください。");
            Console.Read();
        }
    }
}
