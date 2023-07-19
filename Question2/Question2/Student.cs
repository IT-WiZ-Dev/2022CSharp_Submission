using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    class Student
    {
        private int studentId { get; set; }
        private string studentName { get; set; }
        private string otherInfo { get; set; }
        public int StudentId
        {
            get { return studentId; }
            set{ studentId = value; }
        }
        public string StudentName
        {
            get { return studentName; }
            set { studentName = value; }
        }
        public string OtherInfo
        {
            get { return otherInfo; }
            set { otherInfo = value; }
        }
    }
}
