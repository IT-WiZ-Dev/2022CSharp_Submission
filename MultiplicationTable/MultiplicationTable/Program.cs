using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("     ＊＊＊九九の表＊＊＊");
        Console.WriteLine("　|      1     2    3    4    5    6    7    8    9");
        Console.WriteLine("-----------------------------------------");

        for (int i = 1; i <= 9; i++)
        {
            Console.Write($"{i}  |");
            for (int j = 1; j <= 9; j++)
            {
                Console.Write($"{i * j,6}");
            }
            Console.WriteLine();
        }
        Console.WriteLine("終了するには何かキーを押してください。");
        Console.Read();
    }
}
