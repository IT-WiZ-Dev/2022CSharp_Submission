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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //変数宣言
            double addTax;
            const double Tax = 0.1;
            //テキストボックスの金額取得
            int tmp = int.Parse(textBox1.Text);
            //税込み金額算出
            addTax = tmp + tmp * Tax;
            //結果をラベルに挿入
            label6.Text = (int)addTax / int.Parse(textBox2.Text) + "円";
            label8.Text = (int)addTax % int.Parse(textBox2.Text) + "円";
        }
    }
}
