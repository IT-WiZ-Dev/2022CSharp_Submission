using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //熊田晃大
        private void buttonCul_Click(object sender, EventArgs e)
        {
            double yen = int.Parse(textBoxChange.Text);
            label5000yen.Text = Math.Floor(yen / 5000).ToString("F0");
            yen = yen % 5000;
            label1000yen.Text = Math.Floor(yen / 1000).ToString("F0");
            yen = yen % 1000;
            label500yen.Text = Math.Floor(yen / 500).ToString("F0");
            yen = yen % 500;
            label100yen.Text = Math.Floor(yen / 100).ToString("F0");
            yen = yen % 100;
            label50yen.Text = Math.Floor(yen / 50).ToString("F0");
            yen = yen % 50;
            label10yen.Text = Math.Floor(yen / 10).ToString("F0");
            yen = yen % 100;
            label5yen.Text = Math.Floor(yen / 5).ToString("F0");
            yen = yen % 5;
            label1yen.Text = Math.Floor(yen / 1).ToString("F0");
            yen = yen % 1;

        }
    }
}
