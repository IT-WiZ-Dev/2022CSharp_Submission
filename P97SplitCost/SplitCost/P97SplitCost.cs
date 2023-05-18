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
            textBoxMoney.Text = "0";
            textBoxNum.Text = "0";
        }


        private void buttonKeisan_Click(object sender, EventArgs e)
        {

            double total = int.Parse(textBoxMoney.Text) * 1.1;
            double ninzu = int.Parse(textBoxNum.Text);
            if(ninzu == 0)
            {
                return;
            }
            int hitori = (int)(total / ninzu);
            int amari = (int)(total % ninzu);
            label1total.Text = hitori.ToString() + "円";
            labelAmari.Text = amari.ToString() + "円";
        }
    }
}
