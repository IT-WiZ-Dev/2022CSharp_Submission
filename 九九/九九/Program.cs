using System;

class Program
{
    const int TargetNumber = 42; // 当たりの数

    static void Main()
    {
        Console.WriteLine("数当てゲームを始めます！");
        Console.WriteLine("0から100の範囲で、思い浮かんだ数を入力してください。");

        int attempts = 0;
        bool isCorrect = false;
        int lowerBound = 0; // 現在のヒント範囲の下限
        int upperBound = 100; // 現在のヒント範囲の上限

        while (!isCorrect)
        {
            Console.Write($"予想した数 ({lowerBound} から {upperBound}): ");
            string input = Console.ReadLine();
            int guess;

            if (int.TryParse(input, out guess))
            {
                if (guess < 0 || guess > 100)
                {
                    Console.WriteLine("0から100の範囲で数を入力してください。");
                    continue;
                }

                attempts++;

                if (guess < TargetNumber)
                {
                    Console.WriteLine("もっと大きな数です！");
                    lowerBound = guess + 1;
                }
                else if (guess > TargetNumber)
                {
                    Console.WriteLine("もっと小さな数です！");
                    upperBound = guess - 1;
                }
                else
                {
                    isCorrect = true;
                }
            }
            else
            {
                Console.WriteLine("数を入力してください。");
            }
        }

        Console.WriteLine($"おめでとうございます！ {attempts}回目で当たりました！");
    }
}
