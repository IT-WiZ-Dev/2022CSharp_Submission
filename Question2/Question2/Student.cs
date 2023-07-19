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
        public Student(string studentName, string otherInfo, int studentId)
        {
            this.studentName = studentName;
            this.otherInfo = otherInfo;
            this.studentId = studentId;
           
        }
        public int StudentId
        {
            set
            {
                this.studentId = value;
            }
            get
            {
                return this.studentId;
            }
        }
        

        
    }
}
