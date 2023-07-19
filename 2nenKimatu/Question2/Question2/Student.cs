using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    class Student
    {
        private int studentId;
        private string studentName;
        private string otherInfo;

        public int StudentId
        {
            set { studentId = value; }
            get { return studentId; }
        }

        public string StudentName
        {
            set { studentName = value; }
            get { return studentName; }
        }

        public string OtherInfo
        {
            set { otherInfo = value; }
            get { return otherInfo; }
        }
    }
}
