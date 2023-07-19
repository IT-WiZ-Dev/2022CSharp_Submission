using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 問3
 * 下記の通りの参照渡しのメソッドを作成しなさい
 * 
 * メソッド名：AddNum
 * 引数列：値渡しの整数型を２つ、参照渡しの整数型を１つ
 * 戻り値：なし
 * 処理：値渡しの整数を２つ足し算した結果を参照渡しの整数型へ代入するメソッド
 * 
 * 
*/




namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            AddNum(a);
            int b = 10;
            AddNum(b);
            int c = 10;
            AddNum(ref c,ref a,ref b);
            Console.WriteLine(c);
            Console.Read();
        }

        private static void AddNum(int a)
        {
            a = a + 1;
        }
        private static void AddNum(ref int c,ref int a,ref int b)
        {
            c = a + b;
        }

    }
}
