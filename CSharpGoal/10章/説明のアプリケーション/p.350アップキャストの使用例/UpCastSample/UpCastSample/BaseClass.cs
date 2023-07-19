using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpCastSample
{
    // 基本クラス
    class BaseClass
    {
        public void Method1()
        {
            Console.WriteLine("基本クラス：普通のメソッド");
        }

        public virtual void Method2()   //仮想メソッド
        {
            Console.WriteLine("基本クラス：仮想メソッド");
        }
    }
}
