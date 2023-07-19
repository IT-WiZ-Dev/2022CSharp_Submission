using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSample
{
    // インターフェースを実装するクラス2
    class Square : IMark
    {
        public Square()
        {
            Name = "四角";
        }

        // インターフェースで宣言されたメンバーはすべて実装する 
        public string Name { get; set; }    // 自動実装プロパティ

        public void Draw()
        {
            Console.WriteLine("□");
        }
    }
}
