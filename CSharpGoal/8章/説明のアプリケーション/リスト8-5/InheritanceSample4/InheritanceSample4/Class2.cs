using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSample4
{
    // 派生クラス
    class Class2 : Class1
    {
        public new int x = 20;      // 基本クラスの変数xを隠蔽

        public new void M()         // 基本クラスのMメソッドを隠蔽
        {
            Console.WriteLine("派生クラスのメソッドが呼ばれました。");
        }
    }
}
