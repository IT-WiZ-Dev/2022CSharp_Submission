using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label4.Visible == true)
            {
                label4.Visible = false;
            }
            else
            {
                label4.Visible = true;
            }
            if (label6.Visible == true)
            {
                label6.Visible = false;
            }
            else
            {
                label6.Visible = true;
            }

            int ii = int.Parse(textBox1.Text);
            int dd = int.Parse(textBox2.Text);
            int answer = ii / dd;
            int answer2 = ii % dd;
            label4.Text = answer.ToString();
            label6.Text = answer2.ToString();
        }


        private void label4_Click(object sender, EventArgs e)
        {
            label4.Text = "";

        }

        private void label6_Click(object sender, EventArgs e)
        {
            label6.Text = "";
        }
    }
}
