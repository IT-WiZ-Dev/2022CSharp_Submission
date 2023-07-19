using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpCastSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("基本クラスのインスタンスを生成");
            BaseClass bbc = new BaseClass();
            bbc.Method1();      // 基本クラスのメソッドを実行
            bbc.Method2();      // 基本クラスのメソッドを実行

            Console.WriteLine("\n派生クラスのインスタンスを生成");
            SubClass ssc = new SubClass();
            ssc.Method1();      // 派生クラスのメソッドを実行
            ssc.Method2();      // 派生クラスのメソッドを実行

            Console.WriteLine("\n派生クラスのインスタンスをアップキャスト");
            BaseClass bsc = new SubClass();
            bsc.Method1();      // 基本クラスのメソッドを実行
            bsc.Method2();      // 派生クラスのメソッドを実行

            Console.WriteLine("\n終了するには何かキーを押してください。");
            Console.Read();
        }
    }
}
