using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HidingSample
{
    // 基本クラス
    class Mark
    {
        public Mark(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public void Draw()
        {
            Console.WriteLine("");  // とりあえず空文字列を描く
        }
    }
}
