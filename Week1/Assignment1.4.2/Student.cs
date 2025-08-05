using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._4._2
{
    public class Student
    {
        private int studentID;
        public int StudentID 
        {
            get { return studentID; }
            set { studentID = value; }
        }
        private string studentFName;
        public string StudentFName 
        {
            get { return studentFName; }
            set { studentFName = value; }
        }
        private string studentLName;
        public string StudentLName 
        {
            get { return studentLName; }
            set { studentLName = value; }
        }
        private char studentGrade;
        public char StudentGrade
        {
            get { return studentGrade; }
            set { studentGrade = value; }
        }
        public Student(int StudentID, string StudentFName, string StudentLName, char StudentGrade)
        {
            studentID = StudentID;
            studentFName = StudentFName;
            studentLName = StudentLName;
            studentGrade = StudentGrade;
        }
        public void print()
        {
            Console.WriteLine(studentID + "\n" + studentFName + "\n" + studentLName + "\n" + studentGrade);
        }
    }
}
