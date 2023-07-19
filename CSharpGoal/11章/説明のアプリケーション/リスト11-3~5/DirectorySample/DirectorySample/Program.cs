using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DirectorySample
{
    class Program
    {
        static void Main(string[] args)
        {
            int no;

            Console.WriteLine("確認したい例の番号を入力してください。");
            Console.WriteLine("1: Existsメソッド");
            Console.WriteLine("2: CreateDirectoryメソッド");
            Console.WriteLine("3: Deleteメソッド");
            Console.WriteLine("9: 終了");

            do
            {
                Console.Write("番号＞ ");
                try
                {
                    string s = Console.ReadLine();
                    no = int.Parse(s);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                    break;
                }

                switch (no)
                {
                    case 1:
                        Console.WriteLine("● Directoryクラス Existsメソッドの例");
                        ExistsExample();
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.WriteLine("● DirectoryクラスCreateDirectoryメソッドの例");
                        CreateDirectoryExample();
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.WriteLine("● Directoryクラス Deleteメソッドの例");
                        DeleteExample();
                        Console.WriteLine();
                        break;
                }
            } while (no != 9);

            Console.WriteLine("\n終了するには何かキーを押してください。");
            Console.Read();
        }

        static void ExistsExample()
        {
            string directory = @"C:¥Program Files¥Microsoft Office";
            if (Directory.Exists(directory) == true)
                Console.WriteLine(directory + "ディレクトリは存在します。");
            else
                Console.WriteLine(directory + "ディレクトリは存在しません。");
        }

        static void CreateDirectoryExample()
        {
            try
            {
                if (Directory.Exists("test") == false)
                {
                    Console.WriteLine("testディレクトリが存在しないので作成します。");
                    Directory.CreateDirectory("test");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void DeleteExample()
        {
            try
            {
                if (Directory.Exists("test") == true)
                {
                    Console.WriteLine("testディレクトリは存在するので削除します。");
                    Directory.Delete("test", true);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
