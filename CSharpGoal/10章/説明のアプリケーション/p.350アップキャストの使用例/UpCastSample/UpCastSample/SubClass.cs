using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpCastSample
{
    // 派生クラス
    class SubClass : BaseClass
    {
        public new void Method1()       //メソッドの隠蔽
        {
            Console.WriteLine("派生クラス：隠蔽したメソッド");
        }

        public override void Method2()  //仮想メソッドのオーバーライド
        {
            Console.WriteLine("派生クラス：オーバーライドしたメソッド");
        }
    }
}
