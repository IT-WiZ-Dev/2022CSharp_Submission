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
        public void AddNum(String lang) //関数名(引数の型 引数の値)
        {
            int m = 1, n = 3;
            int a = m + n;
            Console.WriteLine(a); //出力内容に引数の値を入れている
        }


        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.AddNum("C#"); //引数として、"C#"を渡している


        }
    }
}
