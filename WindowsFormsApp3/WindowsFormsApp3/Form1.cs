using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//計算ボタン
        {
            int money;         //お金作業用変数
            double addTax;      //税込み金額格納用
            const double Tax = 0.1;  //消費税率10％
            int number;        //人数


            //「金額」「人数」テキストボックスの値を整数型変数に取得
            money = int.Parse(textBox1.Text);
            number = int.Parse(textBox2.Text);

            //消費税を加算し税込み金額を算出
            addTax = money;
            addTax *= (1 + Tax);
            money = (int)addTax;


            //一人当たりの金額と余りをラベルに表示
            label6.Text = money / number + "円";
            label8.Text = money % number + "円";
            












        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}






