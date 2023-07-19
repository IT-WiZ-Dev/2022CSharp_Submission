using System;

class Student
{
    public Student(int id,string name, string info)
    {
        studentId = id;
        studentName = name;
        otherInfo = info;
    }
    private int studentId { get; set; }
    private string studentName { get; set; }
    private string otherInfo { get; set; }
}