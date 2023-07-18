using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiAlarm
{
    public partial class Form2 : Form
    {

        internal int alarmhour = 0;
        internal int alarmminute = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            alarmhour = (int)numerichour.Value;
            alarmminute = (int)numericminute.Value;


            //設定後に閉じる
            DialogResult = DialogResult.OK;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            numerichour.Value = DateTime.Now.Hour;
            numericminute.Value = DateTime.Now.Minute;
        }
    }
}
