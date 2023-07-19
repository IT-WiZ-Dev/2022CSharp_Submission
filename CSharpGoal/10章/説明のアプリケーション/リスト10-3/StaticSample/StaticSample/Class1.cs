using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticSample
{
    class Class1
    {
        public string Name;
        public int Score;
        public static int PassScore = 50;

        public Class1(string name, int score)
        {
            this.Name = name;
            this.Score = score;
            PassScore = 60;
        }
    }
}
