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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a;
            int b;
            int Hitoriatari;
            int Amari;
            double add = 1.1;
            double c;
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            c = a;
            c *= add;
            Hitoriatari = (int)c / b;
            label7.Text = Hitoriatari + " 円";
            Amari = (int)c % b;
            label8.Text = Amari + " 円";


        }
    }
}
