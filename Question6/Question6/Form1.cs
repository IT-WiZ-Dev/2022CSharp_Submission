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

        private void Form1_Load(object sender, EventArgs e)
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
        

        private void textBoxChange_TextChanged(object sender, EventArgs e)
        {
            string inputText = textBoxChange.Text;
            int value1 = Convert.ToInt32(inputText);



        }
    }
       
    
}







        
    
}
