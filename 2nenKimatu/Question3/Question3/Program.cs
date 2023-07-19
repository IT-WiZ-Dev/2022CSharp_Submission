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
            int value1 = 5;
            int value2 = 10;
            int result = 0;

            Console.WriteLine("Before calling AddNum method:");
            Console.WriteLine("Value1: " + value1);
            Console.WriteLine("Value2: " + value2);
            Console.WriteLine("Result: " + result);

            AddNum(value1, value2, ref result);

            Console.WriteLine("\nAfter calling AddNum method:");
            Console.WriteLine("Value1: " + value1);
            Console.WriteLine("Value2: " + value2);
            Console.WriteLine("Result: " + result);
        }

        public static void AddNum(int val1, int val2, ref int result)
        {
            result = val1 + val2;
        }
    }
}
  
 



  
