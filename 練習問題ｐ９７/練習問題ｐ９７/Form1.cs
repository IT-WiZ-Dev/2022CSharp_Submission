using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 練習問題ｐ９７
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int money;
            double people;
            double one_people;
            double amari;


            money = int.Parse(textBoxMoney.Text);
            people = int.Parse(textBoxPeople.Text);

            one_people = money * 1.1 / people;
            amari = money * 1.1 % people;

            label7.Text = (int)one_people + "円";
            label8.Text = (int)amari + "円";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
