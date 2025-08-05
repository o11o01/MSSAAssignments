using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3._3._2
{
    public class Student
    {
        public int StudentID
        { get; set; }
        public string FirstName
        { get; set; }
        public string LastName
        { get; set; }
        public string Address
        { get; set; }
        public month AdmissionMonth
        { get; set; }
        public char Grade
        { get; set; }

        public Student(int studentID, string firstName, string lastName, string address, month admissionMonth, char grade)
        {
            StudentID = studentID;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            AdmissionMonth = admissionMonth; 
        }
        public Student()
        {
            FirstName = "";
            LastName = "";
            Address = "";
        }
    }
    public enum month
    {
        January,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December,
    }
}
