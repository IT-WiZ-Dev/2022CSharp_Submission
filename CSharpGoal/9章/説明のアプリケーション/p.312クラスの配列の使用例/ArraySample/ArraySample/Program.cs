using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySample
{
    class Program
    {
        static void Main(string[] args)
        {
            // クラスのインスタンスで初期化
            Class1[] c1 = {
                new Class1(1),
                new Class1(2),
                new Class1(3),
            };

            Console.WriteLine("{0}, {1}, {2}", c1[0].N, c1[1].N, c1[2].N);

            // クラスのインスタンスを代入
            Class1[] c2 = new Class1[3];
            c2[0] = new Class1(10);
            c2[1] = new Class1(20);
            c2[2] = new Class1(30);

            Console.WriteLine("{0}, {1}, {2}", c2[0].N, c2[1].N, c2[2].N);

            Console.WriteLine("\n終了するには何かキーを押してください。");
            Console.Read();
        }
    }
}
