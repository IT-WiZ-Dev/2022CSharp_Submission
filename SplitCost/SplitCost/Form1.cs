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
            label7.Text = "";
            label8.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int money = int.Parse(textBox1.Text);   
            int number = int.Parse(textBox2.Text); 
            const double Tax = 0.1;                     
            int addTax;                                 
            int one_person, amari;

            addTax = (int)(money * (1 + Tax));

            one_person = addTax / number;
            amari = addTax % number;

            label7.Text = one_person + " 円";
            label8.Text = amari + " 円";
        }
    }
}
