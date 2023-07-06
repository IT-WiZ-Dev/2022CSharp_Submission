using System;

class Program
{
    static void Main()
    {

        Console.WriteLine("           ***九九の表***");
        Console.WriteLine("   1  2  3  4  5  6  7  8  9");
        Console.WriteLine("-----------------------------");


        // 九九表を表示するための2重ループ
        for (int i = 1; i <= 9; i++)
        {
            Console.Write(i + "|");
            for (int j = 1; j <= 9; j++)
            {
                

                // 九九表の計算と表示
                int result = i * j;
                Console.Write($"{result,2} "); // 数値を2桁で表示する

                // 行の最後の列で改行する
                if (j == 9)
                {
                    Console.WriteLine();
                }
            }
        }

        // プログラムの終了を待機する
        Console.ReadLine();
    }
}
