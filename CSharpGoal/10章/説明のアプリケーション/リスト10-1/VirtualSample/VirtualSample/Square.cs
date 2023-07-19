using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualSample
{
    // 派生クラス2
    class Square : Mark
    {
        public Square() : base("四角") { }

        public override void Draw()     // 仮想メソッドのオーバーライド
        {
            Console.WriteLine("□");
        }
    }
}
