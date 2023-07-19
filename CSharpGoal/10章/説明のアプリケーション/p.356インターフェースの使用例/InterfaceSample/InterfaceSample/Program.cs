using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle m1 = new Triangle();
            Square m2 = new Square();

            // インターフェースを実装したクラスから
            // 生成したインスタンスを実引数に指定
            DrawMark(m1);
            DrawMark(m2);

            Console.WriteLine("\n終了するには何かキーを押してください。");
            Console.Read();
        }

        // ポリモーフィズムを実現するために
        // 仮引数の型をインターフェースにする
        static void DrawMark(IMark m)
        {
            Console.Write(m.Name + "マークを描画する：");
            m.Draw();
        }
    }
}
