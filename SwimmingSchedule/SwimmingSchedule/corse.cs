using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimmingSchedule
{
    class corse
    {
        private string corseName;
        private int dayOfWeek;
        private int startTime;
        private int price;
    }
    public corse(string name, int day, int time, int p)
    {
        this corseName = name;
        this dayOfWeek = day;
        this startTime = time;
        this price = p;
    }
    
    public string CorseName
    {
        set
        {
            this.CorseName = value;
        }
        get
        {
            return this.CorseName;
        }
    }







}
