using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractSample
{
    // 派生クラス1
    class Triangle : Mark
    {
        public Triangle() : base("三角") { }

        // 抽象メソッドの実装
        public override void Draw()
        {
            Console.WriteLine("△");
        }
    }
}
