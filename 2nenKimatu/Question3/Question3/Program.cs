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
        }

        public void AddNum()
        {
            int i = 5;
            int o = 5;
            int u = i + o;
            value1(u);
            Console.WriteLine(u);
            value2(ref u);
            Console.WriteLine(u);
        }

        public void value1 (int x)
        {
            x = 10;
        }

        public void value2 (ref int x)
        {
            x = 10;
        }

    }
}
