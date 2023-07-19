using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private Button button1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1 = new Button();

            button1.Name = "button1";
            button1.Text = "開く";

            button1.Location = new Point(100, 100);
            button1.Size = new Size(80, 20);

            button1.Click += new EventHandler(Button1_Click);

            Controls.Add(button1);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            if (form2.ShowDialog() == DialogResult.OK)
            {
                label1.Text = form2.Feeling;
            }
            form2.Dispose();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString();
        }
    }
}
