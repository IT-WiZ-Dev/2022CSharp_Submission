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
            Console.WriteLine("＊＊＊九九の表＊＊＊");
            for (int i = 1; i < 10; i++)
            {
                for(int j = 1; j < 10; j++)
                    Console.Write("{0,3}", i*j);
                Console.Write('\n');
            }
            Console.WriteLine("終了するにはEnterキーを押してください。");
            Console.ReadLine();
        }
    }
}
