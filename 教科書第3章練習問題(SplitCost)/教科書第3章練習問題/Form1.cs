using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 教科書第3章練習問題
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelAddWarikanTax.Text = "";
            labelAddAmariTax.Text = "";
        }

        private void buttonAddTax_Click(object sender, EventArgs e)
        {

            //変数と定数の宣言
            int money; //お金作業用変数
            double addTax; //税込金額格納用
            const double Tax = 0.1; //消費税率10%

            int number; //人数格納用
            double warikan1; //割り勘金額格納(小数点あり)
            int warikan2; //割り勘金額格納。こっちを出力する。
            int amari; //余り金額格納用


            //「税抜き金額」「人数」テキストボックスの値をそれぞれ整数型変数に取得
            money = int.Parse(textBoxMoney.Text);　//金額
            number = int.Parse(textBoxNumber.Text); //人数

            //消費税を加算し、割り勘価格と余りを算出
            addTax = money;
            addTax *= (1 + Tax);　//税込み価格を求める
            money = (int)addTax;

            warikan1 = money / number; //割り勘金額を求める
            warikan2 = (int)warikan1;　//一時的に小数点を切り捨てる

            amari = money % number;　//余り金額を求める


            //割り勘金額と余り金額をそれぞれのラベルに表示
            labelAddWarikanTax.Text = warikan2 + "円";
            labelAddAmariTax.Text = amari + "円";


        }
    }
}
