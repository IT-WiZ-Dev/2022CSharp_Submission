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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //変数と定数の宣言
            int money;     //お金変数
            int person;    //人数変数
            int amari;     //あまり
            const double Tax = 0.1;   //消費税率１０％

            money = int.Parse(textBox1.Text);
            person = int.Parse(textBox2.Text);
            amari = int.Parse(textBox1.Text);

            money = (int)(money+(money*Tax)) / person;

            amari = (int)(amari +(amari* Tax)) % person;

            label6.Text = money + "円";
            label8.Text = amari + "円"; 


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
