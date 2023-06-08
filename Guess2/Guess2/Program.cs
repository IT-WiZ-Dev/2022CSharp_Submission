using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess2
{
    class Program
    {
        static void Main(string[] args)
        {
            int randno = Newnum(1, 101);

            const int num = 3;
            int count = 0;
            int low = 0;
            int high = 100;


            while (true)
            {

                Console.Write("0から100の間の数値を当ててください。 ＞");

                int input = Convert.ToInt32(Console.ReadLine());

                if (input == 0)
                    Console.WriteLine("入力値が正しくありません。再入力してください。");

                else if (input < randno)
                {
                    Console.WriteLine("答はもっと大きいです。");
                    ++count;
                    continue;
                }

                else if (input > randno)
                {
                    Console.WriteLine("答はもっと小さいです。");
                    ++count;
                    continue;

                }

                else
                {
                    Console.WriteLine("おめでとう。" + count + "回目で当たりました。");
                    break;
                }













            }


        }


        static int Newnum(int low, int high)
        {
           
            Random random = new Random();
            
            return random.Next(low, high);

            
        }

    }
}


