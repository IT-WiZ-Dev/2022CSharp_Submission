using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 問4
 * Mainメソッドの中に配列arrが定義されている。
 * foreach文を用いて配列arrの要素を全てコンソールに表示しなさい。 
 * 
*/


namespace Question4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = new string[]{"orange","lemon","apple" };

            foreach (string num in arr)
            {
                // 画面に出力
                Console.WriteLine("{0}", num);
            }

        }
    }
}
