using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 練習問題3_割り勘
{
    public partial class buttonAddTax : Form
    {
        public buttonAddTax()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //変数と定数の宣言
            int money;
            double addTax;
            const double Tax = 0.1;
            int hitoriatari;
            int amari;


            //整数型変数に取得
            money = int.Parse(textBoxMoney.Text);

            //消費税を加算し税込金額を算出
            addTax = money;
            addTax *= (1 + Tax);
            money = (int)addTax;

            int ninnzuu = int.Parse(textBox2ninnzuu.Text);

            hitoriatari = money / ninnzuu;
            amari = money % ninnzuu;

            //表示
            label5.Text = hitoriatari + "円";
            label8.Text = amari + "円";





        }
    }
}
