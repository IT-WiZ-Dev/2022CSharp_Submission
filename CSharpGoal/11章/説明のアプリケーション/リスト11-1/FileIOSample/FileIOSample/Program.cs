using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIOSample
{
    class Program
    {
        static void Main(string[] args)
        {
            // 文字列を全部書き込む例
            string writeText = "文字列をファイルに書き込みました。";

            try
            {
                using (StreamWriter writer1 = new StreamWriter
                    ("test1.txt", false, Encoding.Default))
                {
                    writer1.Write(writeText);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            // 複数の文字列を1行ずつ書き込む例
            string[] writeText2 = { "続けて文字列を",
                                    "改行しながら", "書き込みます。" };

            try
            {
                using (StreamWriter writer2 = new StreamWriter
                    ("test1.txt", true, Encoding.Default))
                {
                    foreach (string s in writeText2)
                    {
                        writer2.WriteLine(s);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
