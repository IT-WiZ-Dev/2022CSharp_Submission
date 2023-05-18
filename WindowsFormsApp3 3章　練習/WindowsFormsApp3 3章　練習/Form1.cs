using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3_3章_練習
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double dd = double.Parse(textBox1.Text);
            int ii = int.Parse(textBox2.Text);
            dd = dd * 1.1;
            int hitori = (int)dd / ii;
            int amari = (int)dd % ii;

            label6.Text = hitori.ToString() + "円";
            label8.Text = amari.ToString()+ "円";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label6.Text = "";
            label8.Text = "";
        }
    }
}
