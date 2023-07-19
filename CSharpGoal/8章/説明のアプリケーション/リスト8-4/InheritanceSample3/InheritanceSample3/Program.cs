using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSample3
{
    class Program
    {
        static void Main(string[] args)
        {
            Class2 c2 = new Class2("旧姓");

            Console.WriteLine(c2.Name);     // "旧姓"を出力

            //c2.name = "新しい姓";         //「アクセスできない保護レベル」のエラー
            c2.NameChange("結婚後の姓");
            Console.WriteLine(c2.Name);     // "結婚後の姓"を出力

            Console.WriteLine("\n終了するには何かキーを押してください。");
            Console.Read();
        }
    }
}
