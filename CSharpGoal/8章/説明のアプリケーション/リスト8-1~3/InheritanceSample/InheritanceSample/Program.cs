using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Television tv = new Television();

            Console.Write($"電源：{(tv.Power ? "ON" : "OFF")}　");
            Console.WriteLine($"チャンネル:{tv.Channel} 音量：{tv.Volume}");

            Console.WriteLine("電源ボタンを押します。");
            tv.OnOff();
            Console.WriteLine($"電源：{(tv.Power ? "ON" : "OFF")}");

            Console.WriteLine("電源ボタンを押します。");
            tv.OnOff();
            Console.WriteLine($"電源：{(tv.Power ? "ON" : "OFF")}");

            Console.WriteLine("\n終了するには何かキーを押してください。");
            Console.Read();

        }
    }
}
