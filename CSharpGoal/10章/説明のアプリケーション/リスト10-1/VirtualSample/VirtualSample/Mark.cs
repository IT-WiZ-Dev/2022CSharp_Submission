using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualSample
{
    // 基本クラス
    class Mark
    {
        public Mark(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public virtual void Draw()  //仮想メソッド
        {
            Console.WriteLine("");  //とりあえず空文字列を描く
        }
    }
}
