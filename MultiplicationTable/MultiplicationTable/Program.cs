using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t＊＊＊九九の表＊＊＊");

    
        for (int i = 1; i <= 9; i++)
        {
            Console.Write($"　{i,2}");
        }
        Console.WriteLine();

        Console.WriteLine("　|----------------------------------"); // 線

        for (int i = 1; i <= 9; i++)
        {
            Console.Write($"{i,2}|"); // 左横の見出しの位置
            for (int j = 1; j <= 9; j++)
            {
                Console.Write($"{i * j,2}　");
            }
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}