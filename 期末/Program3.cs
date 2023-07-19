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
        private static int n2;

        static void Main(string[] args)
        { 
            int n1,n2,n3;
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());

            AddNum(n1,n2,n3);
           
        }

        private static void AddNum(int n1, int n2, int n3)
        {
        
            int a = n1;
            Console.Write("{0} → ", a);
            Test(a);
            Console.Write("{0}\n", a);
        }

        static void Test(int a)
        {
           a = n2; // メソッド内で値を書き換える。
        }
    }
}

  