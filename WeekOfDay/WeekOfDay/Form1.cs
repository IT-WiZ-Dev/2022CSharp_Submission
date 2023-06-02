using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeekOfDay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tuki = int.Parse(domainUpDown1.Text);
            int hi = int.Parse(domainUpDown2.Text);
            if (tuki > 12 || hi > 31)
            {
                label4.Text = "ありえない数字が入ってます。";
            }



            int year = 0;
            int month =0;
            int day = 0;
            year = int.Parse(textBox1.Text);
            month = int.Parse(domainUpDown1.Text);
            day = int.Parse(domainUpDown2.Text);
            DateTime dateValue = new DateTime(year, month, day);
            string weekname=dateValue.ToString("dddd");
            label4.Text = weekname + "です。";
        }
    }
}
