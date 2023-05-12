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


        private void button1_Click(object sender, EventArgs e)
        {
            //変数と定数の宣言
            int money;
            int people;
            int pay;
            int amari;
            double addTax;
            const double Tax = 0.1;

            //テキストボックスの値を取得
            money = int.Parse(textBoxMoney.Text);
            people = int.Parse(textBoxPeople.Text);

            //税込み金額の算出
            addTax = money;
            addTax *= (1 + Tax);
            money = (int)addTax;

            //一人あたりの金額と余りの計算
            pay = money / people;
            amari = money % people;

            //ラベルに表示
            label7.Text = (int)pay + "円";
            label8.Text = (int)amari + "円";
        }
    }
}
