using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HidingSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle m1 = new Triangle();
            Square m2 = new Square();
            Mark m3 = new Triangle();
            Mark m4 = new Square();

            // メソッドのオーバーロードで呼び分ける
            // ポリモーフィズムではない
            DrawMark(m1);   // ①を呼ぶ
            DrawMark(m2);   // ②を呼ぶ

            // 隠蔽ではアップキャストしても基本クラスのメソッドを呼ぶ
            DrawMark(m3);   // ③を呼ぶ
            DrawMark(m4);   // ③を呼ぶ

            Console.WriteLine("\n終了するには何かキーを押してください。");
            Console.Read();
        }

        // ①
        static void DrawMark(Triangle m)
        {
            Console.Write(m.Name + "マークを描画する：");
            m.Draw();
        }

        // ②
        static void DrawMark(Square m)
        {
            Console.Write(m.Name + "マークを描画する：");
            m.Draw();
        }

        // ③
        static void DrawMark(Mark m)
        {
            Console.Write(m.Name + "マークを描画する：");
            m.Draw();
        }
    }
}
