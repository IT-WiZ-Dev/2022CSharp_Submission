using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"合格点は{Class1.PassScore}点です。");

            Class1 c1 = new Class1("青森一郎", 60);
            Class1 c2 = new Class1("岩手二郎", 70);
            Class1 c3 = new Class1("秋田三郎", 80);

            Console.WriteLine($"合格点は{Class1.PassScore}点です。");
            Console.WriteLine($"{c1.Name} は {c1.Score}点です。");
            Console.WriteLine($"{c2.Name} は {c2.Score}点です。");
            Console.WriteLine($"{c3.Name} は {c3.Score}点です。");

            Class1.PassScore += 10;

            Console.WriteLine($"合格点は{Class1.PassScore}点に上がりました。");

            Console.WriteLine("\n終了するには何かキーを押してください。");
            Console.Read();
        }
    }
}
