using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSample
{
    // インターフェースを実装するクラス1
    class Triangle : IMark
    {
        public Triangle()
        {
            Name = "三角";
        }

        // インターフェースで宣言されたメンバーはすべて実装する 
        public string Name { get; set; }    // 自動実装プロパティ

        public void Draw()
        {
            Console.WriteLine("△");
        }
    }
}
