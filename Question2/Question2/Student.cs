using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    class Student
    {
        private int studentID;
        private string studentName;
        private string otherinfo;

        public int StudentID
        {
            get { return studentID; }
            set { studentID = value; }
        }

        public string StudentName
        {
            get { return studentName; }
            set { studentName = value; }

        }

        public string Otherinfo
        {
            get { return otherinfo; }
            set { otherinfo = value; }
        }
    }
}
