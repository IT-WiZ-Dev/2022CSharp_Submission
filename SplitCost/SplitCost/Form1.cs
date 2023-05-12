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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label6.Text = "";
            label8.Text = "";
        }
        //「計算するボタン」クリックのイベントハンドラ
        private void button1_Click(object sender, EventArgs e)
        {
            //変数と定数の宣言
            int money;              //税抜き金額作業用変数
            double addTax;          //消費税税込みの金額格納用
            const double Tax = 0.1; //消費税率10%
            int hito;             //人
            int warikan;              //割り勘の額格納用
            int amari;

            //「税抜き金額」「人」テキストボックスの値を整数型変数に取得
            money = int.Parse(textBox1.Text);
            hito = int.Parse(textBox2.Text);

            //消費税を加算し消費税込みの金額を算出
            addTax = money;
            addTax *= (1 + Tax);
            money = (int)addTax;

            //割り勘の額と余りを算出
            warikan = money / hito;
            amari = money % hito;

            //割り勘の額と余りをラベルに表示
            label6.Text = warikan + "円";
            label8.Text = amari + "円";
        }
    }
}
