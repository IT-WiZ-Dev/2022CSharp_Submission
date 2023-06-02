using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rensyuumondai4._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int Form1_Load(object sender, EventArgs e)
        {


            int y, m, d, days, n;
            char buf[BUFFER_SIZE], c;

            printf("Please input days\n");
            while (1)
            {
                fgets(buf, BUFFER_SIZE, stdin);
                n = sscanf(buf, "%d %c", &days, &c);
                if (n == 1)
                {
                    break;
                }
                else if (n == -1)
                {
                    continue;
                }
                else
                {
                    printf("Usage:days\n");
                    return 0;
                }
            }

            if (days < 0)
            {
                printf("error:days\n");
                return 0;
            }
            y = (days + 305) / 146097 * 400
                + (days + 305) % 146097 / 36524 * 100
                + (days + 305) % 146097 % 36524 / 1461 * 4
                + (days + 305) % 146097 % 36524 % 1461 / 365;
            d = days - (365 * (y - 1) + y / 4 - y / 100 + y / 400 + 31 + 28 + 1);
            if (d == -1)
            {
                y--;
                d = 365;
            }
            for (m = 3; m < 15; m++)
            {
                if (306 * (m + 1) / 10 - 122 <= d && 306 * (m + 2) / 10 - 122 > d)
                    break;
            }
            d -= 306 * (m + 1) / 10 - 122 - 1;
            if (m > 12)
            {
                y++;
                m -= 12;
            }
            printf("%d年%d月%d日\n", y, m, d);
            switch (days % 7)
            {
                case 0:
                    label4.Text="日曜日です";
                    break;
                case 1:
                    label4.Text = "火曜日です";
                    break;
                case 2:
                    label4.Text = "水曜日です";
                    break;
                case 3:
                    label4.Text = "木曜日です";
                    break;
                case 4:
                    label4.Text = "金曜日です";
                    break;
                case 5:
                    label4.Text = "土曜日です";
                    break;
                case 6:
                    label4.Text = "日曜日です";
                    break;
            }
            return 0;
        }



    }
}
}
