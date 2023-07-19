using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileSample
{
    class Program
    {
        static void Main(string[] args)
        {
            int no;

            Console.WriteLine("確認したい例の番号を入力してください。");
            Console.WriteLine("1: Existsメソッド");
            Console.WriteLine("2: Createメソッド");
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
                        Console.WriteLine("● Fileクラス Existsメソッドの例");
                        ExistsExample();
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.WriteLine("● Fileクラス Createメソッドの例");
                        CreateExample();
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.WriteLine("● Fileクラス Deleteメソッドの例");
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
            string fileName = @"C:¥Windows¥explorer.exe";
            if (File.Exists(fileName) == true)
                Console.WriteLine(fileName + "は存在します。");
            else
                Console.WriteLine(fileName + "は存在しません。");
        }

        static void CreateExample()
        {
            try
            {
                if (File.Exists("test.txt") == false)
                {
                    Console.WriteLine("test.txt ファイルは存在しないので作成します。");
                    FileStream fs = File.Create("test.txt");
                    fs.Close();     // ファイルをクローズ
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
                if (File.Exists("test.txt") == true)
                {
                    Console.WriteLine("test.txt ファイルは存在するので削除します。");
                    File.Delete("test.txt");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
