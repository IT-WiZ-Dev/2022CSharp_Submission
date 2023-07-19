using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HidingSample
{
    // 派生クラス2
    class Square : Mark
    {
        public Square() : base("四角") { }

        public new void Draw()      // メソッドの隠蔽
        {
            Console.WriteLine("□");
        }
    }
}
