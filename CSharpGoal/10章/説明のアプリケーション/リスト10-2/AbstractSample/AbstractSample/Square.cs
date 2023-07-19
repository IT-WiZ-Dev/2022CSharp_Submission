using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractSample
{
    // 派生クラス2
    class Square : Mark
    {
        public Square() : base("四角") { }

        // 抽象メソッドの実装
        public override void Draw()
        {
            Console.WriteLine("□");
        }
    }
}
