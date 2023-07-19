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
            int num = int.Parse(textBoxChange.Text);
            double change = 0;

            if (num > 5000)
            {
                change = (num / 5000) % 5000;
                label11.Text = change.ToString() + "枚";
            }

            if (num > 1000)
            {
                change = ((num % 10000) / 1000) % 5;
                label12.Text = change.ToString() + "枚";
            }

            if (num > 500)
            {
                change = (num % 1000) / 500;
                label13.Text = change.ToString() + "枚";
            }

            if (num > 100)
            {
                change = ((num % 1000) / 100) % 5;
                label14.Text = change.ToString() + "枚";
            }

            if (num > 50)
            {
                change = (num % 100) / 50;
                label15.Text = change.ToString() + "枚";
            }

            if (num > 10)
            {
                change = ((num % 100) / 10) % 5;
                label16.Text = change.ToString() + "枚";
            }

            if (num > 5)
            {
                change = (num % 10) / 5;
                label17.Text = change.ToString() + "枚";
            }

            if (num > 1)
            {
                change = (num % 10) % 5;
                label18.Text = change.ToString() + "枚";
            }
        }
    }
}
