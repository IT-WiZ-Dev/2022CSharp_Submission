using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("九九の表");

        // ヘッダーを表示する
        Console.Write("×\t");
        for (int i = 1; i <= 9; i++)
        {
            Console.Write($"{i}\t");
        }
        Console.WriteLine();

        // 区切り線を表示する
        Console.WriteLine("---------------------------------------------------------------------------");

        // 表の中身を表示する
        for (int i = 1; i <= 9; i++)
        {
            Console.Write($"{i}\t|");
            for (int j = 1; j <= 9; j++)
            {
                Console.Write($"{i * j}\t");
            }
            Console.WriteLine();
        }
    }
}
