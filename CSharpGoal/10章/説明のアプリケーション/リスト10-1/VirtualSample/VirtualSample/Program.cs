using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Mark m1 = new Triangle();
            Mark m2 = new Square();

            DrawMark(m1);
            DrawMark(m2);

            Console.WriteLine("\n終了するには何かキーを押してください。");
            Console.Read();
        }

        static void DrawMark(Mark m)
        {
            Console.Write(m.Name + "マークを描画する：");
            m.Draw();
        }
    }
}
