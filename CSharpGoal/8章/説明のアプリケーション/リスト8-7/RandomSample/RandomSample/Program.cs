using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();      //Randomインスタンスの生成

            // 0 以上で MaxValue（2,147,483,647）より小さい乱数を5個
            for (int i = 0; i < 5; i++)
                Console.Write(rnd.Next() + " ");
            Console.WriteLine();

            // 0 以上で100より小さい乱数を10個
            for (int i = 0; i < 10; i++)
                Console.Write(rnd.Next(100) + " ");
            Console.WriteLine();

            // 10 以上で20より小さい乱数を10個
            for (int i = 0; i < 10; i++)
                Console.Write(rnd.Next(10, 20) + " ");
            Console.WriteLine();

            Console.WriteLine("\n終了するには何かキーを押してください。");
            Console.Read();
        }
    }
}
