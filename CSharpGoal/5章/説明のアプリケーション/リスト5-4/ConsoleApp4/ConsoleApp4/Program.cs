using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{1000:C}");         // 通貨表示
            Console.WriteLine($"{250:X}");          // 16進表示
            Console.WriteLine($"{2500000:N}");      // 数値表示
            Console.WriteLine($"{123.45678:F3}");   // 小数点以下の桁数指定
            Console.WriteLine($"{2.0 / 3.0:P}");    // %表示

            Console.WriteLine("終了するには何かキーを押してください。");
            Console.Read();
        }
    }
}
