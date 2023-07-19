using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplitCost
{
    public partial class FormSplitCost : Form
    {
        public FormSplitCost()
        {
            InitializeComponent();
        }

        // 「割り勘フォーム」ロードのイベントハンドラ
        private void FormSplitCost_Load(object sender, EventArgs e)
        {
            labelResult1.Text = "";
            labelResult2.Text = "";
        }

        // 「計算するボタン」クリック時のイベントハンドラ
        private void ButtonSplit_Click(object sender, EventArgs e)
        {
            int money = int.Parse(textBoxMoney.Text);   // 税抜き金額
            int number = int.Parse(textBoxNumber.Text); // 人数
            const double Tax = 0.1;                     // 消費税率10%
            int addTax;                                 // 税込み金額
            int result1, result2;

            // 消費税を加算
            addTax = (int)(money * (1 + Tax));

            // 割り勘の額と余りを求める
            result1 = addTax / number;
            result2 = addTax % number;

            // ラベルに表示
            labelResult1.Text = result1 + " 円";
            labelResult2.Text = result2 + " 円";
        }
    }
}
