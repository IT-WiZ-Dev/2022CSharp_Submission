using System;

class Program
{
    static void Main()
    {
        int minNumber = 1;
        int maxNumber = 100;
        Random random = new Random();
        int targetNumber = random.Next(minNumber, maxNumber + 1);
        int attempts = 0;
        int guess = 0;

        while (guess != targetNumber)
        {
            Console.Write($"{minNumber}から{maxNumber}の間の数字を当ててください。＞ ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out guess))
            {
                Console.WriteLine("入力値が正しくありません。再入力してください。");
                continue;
            }

            if (guess < minNumber || guess > maxNumber)
            {
                Console.WriteLine("入力値が正しくありません。再入力してください。");
                continue;
            }

            attempts++;

            if (guess < targetNumber)
            {
                Console.WriteLine("答はもっと大きいです。");
                minNumber = guess + 1;
                Console.WriteLine();
            }
            else if (guess > targetNumber)
            {
                Console.WriteLine("答はもっと小さいです。");
                maxNumber = guess - 1;
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"おめでとう。{attempts}回目で当たりました。");
            }
        }

        Console.ReadLine();
    }
}
