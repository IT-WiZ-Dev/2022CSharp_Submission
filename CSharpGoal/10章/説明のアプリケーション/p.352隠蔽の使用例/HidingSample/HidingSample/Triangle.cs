using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HidingSample
{
    // 派生クラス1
    class Triangle : Mark
    {
        public Triangle() : base("三角") { }

        public new void Draw()      // メソッドの隠蔽
        {
            Console.WriteLine("△");
        }
    }
}
