using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSample5
{
    // 派生クラス
    class Class2 : Class1
    {
        public override void M()
        {
            Console.WriteLine("派生クラスのMメソッドが呼ばれました。");
        }
    }
}
