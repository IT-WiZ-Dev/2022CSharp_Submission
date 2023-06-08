using System;

class Program
{
    Random random;
    readonly int answer;
    int minRange = 0; // 範囲の最小値
    int maxRange = 100; // 範囲の最大値

    public Program()
    {
        random = new Random();
        answer = random.Next(1, 101);
    }

    static void Main()
    {
        Program program = new Program();
        program.StartGame();

        Console.ReadLine();
    }

    void StartGame()
    {
        int guess;
        int attempts = 0;

       

        do
        {
            Console.Write("{0}から{1}の間で数値を当ててください。", minRange, maxRange);
            Console.Write("＞");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out guess))
            {
                Console.WriteLine("入力値が正しくありません。再入力してください。");
                continue;
            }

            if (guess < minRange || guess > maxRange)
            {
                Console.WriteLine("{0}から{1}の間で数値を入力してください。", minRange, maxRange);
                continue;
            }

            attempts++;

            if (guess < answer)
            {
                Console.WriteLine("答はもっと大きいです。");
                minRange = guess + 1;
            }
            else if (guess > answer)
            {
                Console.WriteLine("答はもっと小さいです。");
                maxRange = guess - 1;
            }
            else
            {
                Console.WriteLine("おめでとう。{0}回目で当たりました。", attempts);
            }

        } while (guess != answer);
    }
}
