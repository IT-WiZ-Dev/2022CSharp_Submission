using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dai5syou2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

           
                int randomNumber = random.Next(1, 101); // 1から100までのランダムな数を生成
            int n = -1;
            int sita = 0;
            int ue = 100;
            int sum = 0;
            while (true ) 
            {
                Console.Write(sita + "から" + ue + "の間の数値を当ててください.＞");
               
                int number;
                string input = Console.ReadLine(); // ユーザーからの入力を受け取る
                if (int.TryParse(input, out number))
                {
                    sum++;
                    n =number;
                    if (n < sita || n > ue)
                    {
                        Console.WriteLine("入力値が正しくありません。再入力してください");
                    }
                    else if (randomNumber == n)
                    {
                       
                        Console.WriteLine("おめでとう。" +sum+ "回目に当たりました");
                        break;
                    }
                    else if (n - sita > ue - n)
                    {
                        ue = n - 1;
                        Console.WriteLine("答えはもっと小さいです");
                    }
                    else
                    {
                        sita = n +1;
                        Console.WriteLine("答えはもっと大きいです");
                    }
                }
                else
                {
                    Console.WriteLine("入力値が正しくありません。再入力してください");
                }
              
            } 
            
        }
    }
}
