using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dai5syou
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("  ＊＊＊九九の表示＊＊＊");
            Console.Write("   |");
            for(int i = 1; i < 10; i++)
            {
                Console.Write("{0,3}", i);
            }
            Console.WriteLine();
            Console.WriteLine("______________________________");
            for (int i = 1; i < 10; i++)
            {
                Console.Write(i);
                Console.Write("  |");
                for(int j = 1; j < 10; j++)
                {
                    int ans = i * j;
                    Console.Write("{0,3}",ans);
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
