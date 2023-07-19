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

        private void buttonCul_Click(object sender, EventArgs e)
        {
            int money = int.Parse(textBoxChange.Text);
            int[] change = { 5000, 1000, 500, 100, 50, 10, 5, 1 };
            int[] count = { 0, 0, 0, 0, 0, 0, 0, 0 };
            for (int i = 0; i < 8; i++) 
            {
                count[i] = money / change[i];
                money -= change[i] * count[i];
            }
            label5000yen.Text = count[0].ToString();
            label1000yen.Text = count[1].ToString();
            label500yen.Text = count[2].ToString();
            label100yen.Text = count[3].ToString();
            label50yen.Text = count[4].ToString();
            label10yen.Text = count[5].ToString();
            label5yen.Text = count[6].ToString();
            label1yen.Text = count[7].ToString();
        }
    }
}
