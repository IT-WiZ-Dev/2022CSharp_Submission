using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question5
{
    class NewModel:BaseModel
    {
        public NewModel(int num, string name) : base(num, name)
        {
            Num = num;
            Name = name;
        }
        public int Num { get; set; }
        public string Name { get; set; }
    }
}
