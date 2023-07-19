using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualSample
{
    // 派生クラス1
    class Triangle : Mark
    {
        public Triangle() : base("三角") { }

        public override void Draw()     // 仮想メソッドのオーバーライド
        {
            Console.WriteLine("△");
        }
    }
}
