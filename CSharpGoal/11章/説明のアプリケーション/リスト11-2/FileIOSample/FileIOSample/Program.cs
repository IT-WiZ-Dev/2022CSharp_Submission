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

            // ファイルを全部読み込む例
            string readText = "";
            try
            {
                using (StreamReader reader1 =
                    new StreamReader("test1.txt", Encoding.Default))
                {
                    readText = reader1.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine(readText);

            // ファイルを1行ずつ読み込む例
            try
            {
                using (StreamReader reader2 =
                new StreamReader("test1.txt", Encoding.Default))
                {
                    string line;
                    while ((line = reader2.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("\n終了するには何かキーを押してください。");
            Console.Read();
        }

    }
}
