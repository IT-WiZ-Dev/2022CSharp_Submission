using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowersLanguage
{
    // Form2クラス：花言葉の追加・編集・削除を行うフォームのクラス
    public partial class FormEdit : Form
    {
        public FormEdit()
        {
            InitializeComponent();
        }

        // フォームロードのイベントハンドラ
        private void FormEdit_Load(object sender, EventArgs e)
        {
            // 花言葉をファイルから入力する
            Dictionary<string, string> flowers = FlowerFileIO.Read();

            if (flowers == null)
            {
                MessageBox.Show("花言葉ファイルが存在しません。", "エラー",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // すべての花の名前と花言葉をDataGridViewに追加
                foreach (string key in flowers.Keys)
                {
                    char[] delimiter = { '(', ')' };
                    string[] s = key.Split(delimiter);

                    if (s.Length >= 2)
                        // 花の色がある場合
                        dataGridViewContents.Rows.Add("削除", s[0], s[1], flowers[key]);
                    else
                        // 花の色がない場合
                        dataGridViewContents.Rows.Add("削除", key, "", flowers[key]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //「OKボタン」クリックのイベントハンドラ
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            // DataGridViewの行数を取得
            int count = dataGridViewContents.Rows.Count;
            Dictionary<string, string> flowers = new Dictionary<string, string>();

            for (int i = 0; i < count - 1; i++)
            {
                // 各列の値をKeyとValueに編集して辞書に追加
                string c1 = (string)dataGridViewContents[1, i].Value;   // 花の名前
                string c2 = (string)dataGridViewContents[2, i].Value;   // 花の色
                string c3 = (string)dataGridViewContents[3, i].Value;   // 花ことば
                if (c2 == "")
                    flowers.Add(c1, c3);
                else
                    flowers.Add(c1 + "(" + c2 + ")", c3);
            }

            // DataGridViewの内容をファイルに保存
            FlowerFileIO.Write(flowers);
        }

        // DataGridViewの「削除ボタン」クリックのイベントハンドラ
        private void DataGridViewContents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 削除ボタンの確認
            if (e.ColumnIndex == dataGridViewContents.Columns["DeleteButton"].Index)
            {
                // メッセージボックスで削除OKなら
                if (DialogResult.Yes == MessageBox.Show("本当に削除してもいいですか？",
                        "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    try
                    {
                        // 削除
                        dataGridViewContents.Rows.RemoveAt(e.RowIndex);
                    }
                    catch (InvalidOperationException ex)
                    {
                        MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
