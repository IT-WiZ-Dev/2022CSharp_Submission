using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_練習問題
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label7.Text = " ";
            label8.Text = " ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int money = int.Parse(textBox1.Text);
            const double tax = 0.1;
            double z;
            int people = int.Parse(textBox2.Text);
            int mod;
            double c;

            z = money;
            z *= (1 + tax);
            c = z;
            z = z / people;
            c = z % people;
            money = (int)z;
            mod = (int)c;

            label7.Text =  money.ToString() + "円";
            label8.Text = mod.ToString() + "円";

        }
    }
}
