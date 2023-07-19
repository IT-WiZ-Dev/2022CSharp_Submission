using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Television tv = new Television();

            Console.WriteLine($"TV1　電源：{(tv.Power ? "ON" : "OFF")}　" +
                $"チャンネル:{tv.Channel}　音量：{tv.Volume}");

            Console.WriteLine("チャンネルを+2します。");
            tv.ChannelUP();
            tv.ChannelUP();
            Console.WriteLine($"TV1は{tv.Channel}チャンネルです。");

            Console.WriteLine("音量を-2します。");
            tv.VolumeDown();
            tv.VolumeDown();
            Console.WriteLine($"TV1の音量は{tv.Volume}です。");

            Television tv2 = new Television(8, 25);

            Console.WriteLine($"TV2　電源：{(tv2.Power ? "ON" : "OFF")}　" +
                $"チャンネル:{tv2.Channel}　音量：{tv2.Volume}");

            Console.WriteLine("チャンネルを+2します。");
            tv2.ChannelUP();
            tv2.ChannelUP();
            Console.WriteLine($"TV2は{tv2.Channel}チャンネルです。");

            Console.WriteLine("音量を-2します。");
            tv2.VolumeDown();
            tv2.VolumeDown();
            Console.WriteLine($"TV2の音量は{tv2.Volume}です。");

            Console.WriteLine("\n終了するには何かキーを押してください。");
            Console.Read();
        }
    }
}
