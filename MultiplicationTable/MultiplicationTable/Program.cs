using System;

class Program
{
    static void Main()
    {
        // 九九の表を表示
        Console.WriteLine("***九九の表***");

        // 横に1～9の数字を表示
        Console.Write("   |");
        for (int i = 1; i <= 9; i++)
        {
            Console.Write("{0,3}", i);
        }
        Console.WriteLine();

        // 横線を表示
        Console.WriteLine("--------------------------------");

        // 縦と計算結果を表示
        for (int i = 1; i <= 9; i++)
        {
            Console.Write("{0,2} |", i);
            for (int j = 1; j <= 9; j++)
            {
                Console.Write("{0,3}", i * j);
            }
            Console.WriteLine(); // 改行
        }

        // キー入力待ち
        Console.WriteLine("終了するには何かキーを押してください。");
        Console.ReadKey();
    }
}