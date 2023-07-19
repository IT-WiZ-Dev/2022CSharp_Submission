using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GotoSample
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j = 0, k = 0, no = 1;

            for (i = 1; i <= 10; i++)
            {
                for (j = 1; j <= 10; j++)
                {
                    for (k = 1; k <= 10; k++)
                    {
                        no += (i + j + k);
                        if (no >= 2000) goto OUT;
                    }
                }
            }
            OUT:
            Console.WriteLine($"i:{i} j:{j} k:{k} no:{no}");

            Console.WriteLine("終了するには何かキーを押してください。");
            Console.Read();
        }
    }
}
