using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplitCost_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 変数と定数の宣言
            int money;  // お金作業用変数
            int people;
            int amari;
            double addTax;             // 税込み金額格納用
            const double Tax = 0.1;    // 消費税率10%

            // 「金額」テキストボックスの値を整数型変数に取得
            money = int.Parse(textBox1.Text);
            people = int.Parse(textBox2.Text);

            // 消費税を加算し税込金額を算出
            addTax = money;
            addTax *= (1 + Tax);
            amari = (int)addTax % people;

            money = (int)addTax / people;

            // 税込金額をラベルに表示
            labelAddTax.Text = amari + "円";
            textBoxMoney.Text = money + "円";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
