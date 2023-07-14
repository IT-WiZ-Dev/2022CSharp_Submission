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
        private Iwa iwashi;              
        private uho utubo;               
        private Ank ankou;                
        private int remainingTime = 600;   
        private bool isDayTime = true;      
        private int daytime = 100;          
        private int night = 50;             
        private int score = 0;              

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int formSizeW = this.ClientSize.Width; 
            
            int x = pictureBoxIwashi.Location.X;
            int y = pictureBoxIwashi.Location.Y;
            iwashi = new Iwa(x, y, 20, formSizeW, pictureBoxIwashi);
            x = pictureBoxUtubo.Location.X;
            y = pictureBoxUtubo.Location.Y;
            utubo = new uho(x, y, 10, formSizeW, pictureBoxUtubo);
            x = pictureBoxAnkou.Location.X;
            y = pictureBoxAnkou.Location.Y;
            ankou = new Ank(x, y, 10, formSizeW, pictureBoxAnkou);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            timer1.Start();

            swim();
        }

        
        private void swim()
        {
            int x, y;

            
            iwashi.Swim(out x, out y);
            iwashi.Move(x, y);
            utubo.Swim(out x, out y);
            utubo.Move(x, y);
            ankou.Swim(out x, out y);
            ankou.Move(x, y);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            remainingTime--;
            labelTime.Text = "残り時間：" + (remainingTime / 10) + "秒";

            if (isDayTime == true)  
            {
                daytime--;
                if (daytime == 0)
                {
                    isDayTime = false;      
                    iwashi.Sleep();         
                    utubo.Sleep();          
                    daytime = 100;         
                    this.BackColor = Color.Navy;
                }
            }
            else 
            {
                night--;
                if (night == 0)
                {
                    isDayTime = true;       
                    iwashi.WakeUp();        
                    utubo.WakeUp();         
                    night = 50;             
                    this.BackColor = Color.CornflowerBlue;
                }
            }

            if (remainingTime / 10 == 0)
            {
                timer1.Stop();
                labelTime.Text = "ゲームオーバー";
            }
            else
            {
                swim();
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (e.KeyChar >= '1' && e.KeyChar <= '9')
            {
                
                score += iwashi.Eat(int.Parse(e.KeyChar.ToString()), pictureBoxEsaS);
                score += utubo.Eat(int.Parse(e.KeyChar.ToString()), pictureBoxEsaL);
                score += ankou.Eat(int.Parse(e.KeyChar.ToString()), pictureBoxEsaM);

                labelScore.Text = "得点：" + score;
            }
        }
    }
}
