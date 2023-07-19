using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSample3
{
    // 派生クラス
    class Class2 : Class1
    {
        public Class2(string n) : base(n) { }

        public void NameChange(string n)
        {
            base.name = n; // 基本クラスのnameはprotectedなのでアクセス可能
        }
    }
}
