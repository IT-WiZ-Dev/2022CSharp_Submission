using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;


namespace MakeTrailer
{
    // 予告ファイルの入出力クラス
    static class ContentsFileIO
    {
        // 予告を保存するファイルとディレクトリ
        private const string DirName = "Data";
        private const string FileName = DirName + "\\contents.csv";

        // 予告の内容を読み込むメソッド
        //（戻り値）予告を格納したリスト
        public static List<string> Read()
        {
            List<string> list = new List<string>();
            // ファイルが無ければnullを返却
            if (File.Exists(FileName) == false)
            {
                return null;
            }

            // 予告ファイルの読み込み
            try
            {
                using (StreamReader reader = new StreamReader
                (FileName, Encoding.Default))
                {
                    // ファイルを1行ずつ読み出す
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        list.Add(line);
                    }
                }
                return list;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "エラー",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return list;
            }
        }

        // 予告の内容を書き込むメソッド
        //（仮引数）list：ファイルに書き込む予告
        public static void Write(List<string> list)
        {
            // ディレクトリが無ければ作成する
            if (Directory.Exists(DirName) == false)
            {
                Directory.CreateDirectory(DirName);
            }

            // 予告の内容を書き込む
            try
            {
                using (StreamWriter writer = new StreamWriter
                    (FileName, false, Encoding.Default))
                {
                    foreach (string s in list)
                    {
                        writer.Write(s);
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
