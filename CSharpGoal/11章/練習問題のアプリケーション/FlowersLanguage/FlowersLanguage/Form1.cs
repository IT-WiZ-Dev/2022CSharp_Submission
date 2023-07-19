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
    // Form1クラス：指定した花の花ことばを表示するメインフォームのクラス
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        //「検索」ボタンクリックのイベントハンドラ
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            // 検索した花ことばをメッセージボックスに表示
            MessageBox.Show(FlowerLanguage.Get(textBoxName.Text, comboBoxColor.Text), "結果");
        }

        //「追加編集」ボタンクリックのイベントハンドラ
        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            // Form2のダイアログボックスを表示
            FormEdit form2 = new FormEdit();
            form2.ShowDialog();
            form2.Dispose();
        }
    }
}
