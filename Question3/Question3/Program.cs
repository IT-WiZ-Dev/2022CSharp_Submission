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
    using System;

    public class MathOperations
    {
        public static void AddNum(int num1, int num2, ref int result)
        {
            result = num1 + num2;
        }
    }

    public class Program
    {
        public static void Main()
        {
            int a = 10;
            int b = 20;
            int sum = 0;
            MathOperations.AddNum(a, b, ref sum);
            Console.WriteLine(sum); 
        }
    }
}