using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int ans = random.Next(0, 101);
        int guessCount = 0;
        int min = 0;
        int max = 100;

        while (true)
        {
            Console.Write($"{min} から {max} の範囲で入力してください: ");
            string input = Console.ReadLine();
            int guess;

            if (!int.TryParse(input, out guess))
            {
                Console.WriteLine("数字を入力してください。");
                continue;
            }

            if (guess < min || guess > max)
            {
                Console.WriteLine("再入力してください。");
                continue;
            }

            guessCount++;

            if (guess < ans)
            {
                Console.WriteLine("入力した数は正解より小さいです。");
                min = guess + 1;
            }
            else if (guess > ans)
            {
                Console.WriteLine("入力した数は正解より大きいです。");
                max = guess - 1;
            }
            else
            {
                Console.WriteLine($"おめでとう！{guessCount}回目で当たりました。");
                break;
            }
        }
    }
}
