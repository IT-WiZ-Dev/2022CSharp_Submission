using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//ボタンクリック//
        {
            //変数の定義//
            int mony;
            int nin;
            double addTax;
            const double Tax = 0.1;

          mony = int.Parse(textBox1.Text);
            nin = int.Parse(textBox2.Text);

            addTax = mony;
            addTax *= (1 + Tax);
            mony = (int)addTax;

            label7.Text =  mony/nin + "円";
            label8.Text =  (mony % nin).ToString() + "円";   
        }
    }
}
