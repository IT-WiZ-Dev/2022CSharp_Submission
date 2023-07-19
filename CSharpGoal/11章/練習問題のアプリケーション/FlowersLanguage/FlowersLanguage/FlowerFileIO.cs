using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowersLanguage
{
    // ファイル入出力クラス：花言葉をファイルへ入出力する静的クラス
    static class FlowerFileIO
    {
        // 花言葉を保存するファイルとディレクトリ
        private const string DirName = "Data";
        private const string FileName = DirName + "\\flower.csv";

        // 花ことばの内容を読み込むメソッド
        //（戻り値）花言葉を格納した辞書
        public static Dictionary<string, string> Read()
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            // ファイルが無ければnullを返却
            if (File.Exists(FileName) == false)
            {
                return null;
            }

            // 花言葉ファイルの読み込み
            try
            {
                using (StreamReader reader =
                    new StreamReader(FileName, Encoding.Default))
                {
                    // ファイルを1行ずつ読み出す
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        // カンマで分割して辞書に登録
                        string[] s = line.Split(',');
                        dictionary.Add(s[0], s[1]);
                    }
                }
                return dictionary;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "エラー",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return dictionary;
            }
        }

        // 花言葉の内容を書き込むメソッド
        //（仮引数）dictionary：ファイルに書き込む花と花言葉の辞書
        public static void Write(Dictionary<string, string> dictionary)
        {
            // ディレクトリが無ければ作成する
            if (Directory.Exists(DirName) == false)
            {
                Directory.CreateDirectory(DirName);
            }

            // 花言葉の内容を書き込む
            try
            {
                using (StreamWriter writer =
                    new StreamWriter(FileName, false, Encoding.Default))
                {
                    foreach (string key in dictionary.Keys)
                    {
                        writer.WriteLine("{0},{1}", key, dictionary[key]);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "エラー",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }   
    }
}
