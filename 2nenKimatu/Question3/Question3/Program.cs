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
        //値渡しの整数を２つ足し算した結果を参照渡しの整数型へ代入するメソッド
        //引数列：a、b＝値渡し　r＝参照渡し
        public void AddNum(int a, int b, ref int r) 
        {
            r = a + b;
        }


        static void Main(string[] args)
        {
        }
    }
}
