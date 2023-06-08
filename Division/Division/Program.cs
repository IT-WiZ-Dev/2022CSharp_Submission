using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            string yn;

            do
            {
                try
                {
                    do
                    {
                        Console.Write("割られる数＞");
                        n1 = int.Parse(Console.ReadLine());
                        Console.Write("割る数＞");
                        n2 = int.Parse(Console.ReadLine());
                        if (n2 == 0)
                        {
                            Console.WriteLine("0では割れません。再入力してください。");
                            continue;
                        }
                        Console.Write($"{n1} / {n2} = ");
                        if (n1 < 0 && n2 > 0)
                        {
                            Console.Write("-");
                            n1 = -n1;
                        }
                        else if (n1 > 0 && n2 < 0)
                        {
                            Console.Write("-");
                            n2 = -n2;
                        }
                        Console.Write(n1 / n2);
                    } while (n2 == 0);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                    break;
                }
                int remainder;
                for (int i = 1; i <= 50; i++)
                {
                    remainder = n1 % n2;
                    if (remainder == 0)
                        break;
                    n1 = remainder * 10;
                    if (i == 1)
                        Console.Write('.');
                    Console.Write(n1 / n2);
                }
                Console.Write('n');

                Console.WriteLine("処理を続けますか？ \'y\' / \'n\'");
                yn = Console.ReadLine();
            } while (yn == "y" || yn == "Y");

            Console.WriteLine("終了するには何かキーを押してください。");
            Console.Read();
        }
    }
}

       