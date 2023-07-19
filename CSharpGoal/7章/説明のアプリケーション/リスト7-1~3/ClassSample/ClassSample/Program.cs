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

            Console.WriteLine("10チャンネルを設定します。");
            tv.SetChannel(10);
            Console.WriteLine($"TVは{tv.channel}チャンネルです。");

            Console.WriteLine("チャンネルを+2します。");
            tv.ChannelUP();
            tv.ChannelUP();
            Console.WriteLine($"TVは{tv.channel}チャンネルです。");

            Console.WriteLine("チャンネルを-1します。");
            tv.ChannelDown();
            Console.WriteLine($"TVは{tv.channel}チャンネルです。");

            Console.WriteLine("\n終了するには何かキーを押してください。");
            Console.Read();

        }
    }
}
