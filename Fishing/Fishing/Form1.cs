using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fishing
{
    public partial class Form1 : Form
    {

        Fish fish1;
        Fish fish2;
        Fish fish3;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fish1 = new Fish(
                pictureBox2.Location.X,
                pictureBox2.Location.Y,
                5,
                pictureBox2
                );

            fish2 = new Fish(
                pictureBox1.Location.X,
                pictureBox1.Location.Y,
                7,
                pictureBox1
                );

            fish3 = new Fish(
                pictureBox3.Location.X,
                pictureBox3.Location.Y,
                6,
                pictureBox3
                );

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fish1.Swim();
            fish2.Swim();
            fish3.Swim();
        }
    }
}
