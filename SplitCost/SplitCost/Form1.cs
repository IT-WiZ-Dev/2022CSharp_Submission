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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label7.Text = "";
            label9.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double kakaku;
            int nin;
            int kokakaku;
            int amari;
            kakaku = int.Parse(textBox1.Text)*1.1;
            nin = int.Parse(textBox2.Text);
            kokakaku = (int)kakaku / nin;
            amari = (int)kakaku % nin;
            label7.Text =kokakaku.ToString();
            label9.Text=amari.ToString();
        }
    }
}
