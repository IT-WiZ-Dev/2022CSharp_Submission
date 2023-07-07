using System;
using System.Windows.Forms;

namespace MultiAlarm
{
    public partial class MainForm : Form
    {
        private Alarm[] alarms;
        private AlarmDialog alarmDialog;

        public MainForm()
        {
            InitializeComponent();
            //alarms = new Alarm[3];
            //alarmDialog = new AlarmDialog();
            //UpdateClock();
      
        }
        /*
        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateClock();
            CheckAlarms();
        }

        private void UpdateClock()
        {
            DateTime currentTime = DateTime.Now;
          
        }

        private void CheckAlarms()
        {
            DateTime currentTime = DateTime.Now;
            for (int i = 0; i < alarms.Length; i++)
            {
                if (alarms[i] != null && alarms[i].AlarmTime <= currentTime && !alarms[i].IsTriggered)
                {
                    MessageBox.Show($"Alarm {i + 1} triggered!");
                    alarms[i].IsTriggered = true;
                    alarms[i].CheckBox.Checked = false;
                }
            }
        }

        private void btnSetAlarm1_Click(object sender, EventArgs e)
        {
            SetAlarm(0);
        }

        private void btnSetAlarm2_Click(object sender, EventArgs e)
        {
            SetAlarm(1);
        }

        private void btnSetAlarm3_Click(object sender, EventArgs e)
        {
            SetAlarm(2);
        }

        private void SetAlarm(int index)
        {
         
            {
                alarms[index] = new Alarm
                {
                    
                    CheckBox = GetCheckBoxByIndex(index)
                };

                alarms[index].CheckBox.Checked = true;
                alarms[index].CheckBox.Text = alarms[index].AlarmTime.ToString("HH:mm:ss");
            }
        }

        private CheckBox GetCheckBoxByIndex(int index)
        {
            switch (index)
            {
          
                default:
                    throw new ArgumentOutOfRangeException(nameof(index));
            }
        }
        */
    }

    public class Alarm
    {
        public DateTime AlarmTime { get; set; }
        public CheckBox CheckBox { get; set; }
        public bool IsTriggered { get; set; }
    }
}
