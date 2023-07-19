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
            //熊田晃大
            int ans = 0;
            AddNum(5, 7, ref ans);
            Console.WriteLine(ans); // 12
        }
        static void AddNum(int val1, int val2, ref int val3)
        {
            val3 = val1 + val2;
        }
    }
}
