using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question5
{
    class NewModel : BaseModel
    {
        public int Num { get; private set; }
        public string Name { get; private set; }

        public NewModel(int num, string name) : base(num, name)
        {

        }
    }
}
