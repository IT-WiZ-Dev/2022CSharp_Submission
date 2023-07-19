using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddTax
{
    public partial class FormAddTax : Form
    {
        public FormAddTax()
        {
            InitializeComponent();
        }

        // 「消費税追加ボタン」クリックのイベントハンドラ
        private void ButtonAddTax_Click(object sender, EventArgs e)
        {
            int money;

            money = int.Parse(textBoxMoney.Text);
            // メソッドを呼んで税込金額をmoneyに取得
            money = AddTax(money);
            labelAddTax.Text = money + "円";
        }

        // 税込金額算出処理
        //（仮引数）m：税抜きの金額
        //（返却値）税込み金額
        private int AddTax(int m)
        {
            const double Tax = 0.1; // 消費税率10%

            return (int)(m * (1 + Tax));
        }
    }
}
