using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractSample
{
    // 基本クラス（抽象クラス）
    abstract class Mark
    {
        public Mark(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        // 抽象メソッド
        public abstract void Draw();
    }
}
