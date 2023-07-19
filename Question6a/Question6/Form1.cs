using System;
using System.Windows.Forms;

namespace Question6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ResetLabels();
        }

        private void ResetLabels()
        {
            label5000yen.Text = "";
            label1000yen.Text = "";
            label500yen.Text = "";
            label100yen.Text = "";
            label50yen.Text = "";
            label10yen.Text = "";
            label5yen.Text = "";
            label1yen.Text = "";
        }

        private void buttonCul_Click(object sender, EventArgs e)
        {
            int otsuri;
            if (int.TryParse(textBoxChange.Text, out otsuri))
            {
                int rest = otsuri;

                int a5000yen = rest / 5000;
                rest %= 5000;

                int a1000yen = rest / 1000;
                rest %= 1000;

                int a500yen = rest / 500;
                rest %= 500;

                int a100yen = rest / 100;
                rest %= 100;

                int a50yen = rest / 50;
                rest %= 50;

                int a10yen = rest / 10;
                rest %= 10;

                int a5yen = rest / 5;
                rest %= 5;

                int a1yen = rest;

                label5000yen.Text = a5000yen.ToString();
                label1000yen.Text = a1000yen.ToString();
                label500yen.Text = a500yen.ToString();
                label100yen.Text = a100yen.ToString();
                label50yen.Text = a50yen.ToString();
                label10yen.Text = a10yen.ToString();
                label5yen.Text = a5yen.ToString();
                label1yen.Text = a1yen.ToString();
            }
            else
            {
                label5000yen.Text = ("エラー");

            }
        }
    }
}
