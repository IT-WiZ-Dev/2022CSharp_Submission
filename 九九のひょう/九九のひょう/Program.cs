using System;

class Program
{
    static void Main(string[] args)
    {
        const int tableSize = 9; // 九九の表のサイズ

        // タイトル行の表示
        Console.Write("   ");
        for (int i = 1; i <= tableSize; i++)
        {
            Console.Write($"{i,3} ");
        }
        Console.WriteLine();
        Console.WriteLine(new string('-', (tableSize + 1) * 4)); // 区切り線の表示

        // 九九の表の表示
        for (int i = 1; i <= tableSize; i++)
        {
            Console.Write($"{i,2} |");
            for (int j = 1; j <= tableSize; j++)
            {
                int result = i * j;
                Console.Write($"{result,3} ");
            }
            Console.WriteLine();
        }

        // プログラムが終了する前に、コンソール画面を開いたままにするための入力待ち処理
        Console.ReadLine();
    }
}

