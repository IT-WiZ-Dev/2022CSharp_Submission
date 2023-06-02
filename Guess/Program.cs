using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int A = r.Next(0,100);
            int B = 101;
            int Count = 0;
            while (A != B)
            {
                B = int.Parse(Console.ReadLine());
                if (B >100 || B < 0)
                {
                    Console.WriteLine("入力値が正しくないです");
                }
                if (A < B)
                {
                    Console.WriteLine("答えより大きいです");
                }
                else if(A > B)
                {
                    Console.WriteLine("答えより小さいです");
                }
                Count++;
            }
            Console.WriteLine(Count + "回目で当たりました");
            Console.Write('\n');
        }
    }
}
