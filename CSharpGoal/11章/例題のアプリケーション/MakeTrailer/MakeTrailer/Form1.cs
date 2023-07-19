using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakeTrailer
{
    // メインフォームクラス
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        //「予告作成ボタン」クリックのイベントハンドラ
        private void ButtonMake_Click(object sender, EventArgs e)
        {
            // 予告を作成してメッセージボックスに表示
            MessageBox.Show(Trailer.Get(textBoxA.Text, textBoxB.Text, textBoxC.Text), "結果");
        }

        //「追加編集ボタン」クリックのイベントハンドラ
        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            // 編集フォームを表示
            FormEdit formEdit = new FormEdit();
            formEdit.ShowDialog();
            formEdit.Dispose();
        }
    }
}
