using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int money;　//お金作業

            double addTax;　//税込み金額

            const double Tax = 0.1;　//消費税率10％

            int hito;//人数の変数

            int hit;//人数の補助
            int okane;

            


            //金額を変数に格納
            money = int.Parse(textBoxokane.Text);
            //人数を変数に格納
            hito = int.Parse(textBoxhito.Text);


            //消費税を計算
            addTax = money;
            addTax *= (1 + Tax);
            money = (int)addTax;


            //一人当たりとあまり
            hit = money / hito;
            okane = money % hito;

            //出力
            labelKingaku.Text = hit + " 円";
            labelAmari.Text = okane + " 円";

        }
    }
}
