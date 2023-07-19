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
            int num1 = 3;
            int num2 = 6;
            int result = 0;

            AddNum(num1, num2, ref result);

            Console.WriteLine("Result: " + result);
            Console.ReadLine();
        }

        static void AddNum(int value1, int value2, ref int sum)
        {
            sum = value1 + value2;
        }
    }
  }
