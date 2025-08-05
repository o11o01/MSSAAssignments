using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3._3._2
{
    public static class DataSource
    {
        public static List<Student> Students;
        public static List<Student> CreateData()
        {
            Students = new List<Student>()
            {
                new Student() { StudentID = 1, FirstName = "Kevin", LastName = "Liu", AdmissionMonth = month.January, Grade = 'A' },
                new Student() { StudentID = 2,  FirstName = "Martin", LastName = "Weber", AdmissionMonth = month.February, Grade = 'A'  },
                new Student() { StudentID = 3,   FirstName = "George", LastName = "Li", AdmissionMonth = month.March, Grade = 'A'  },
                new Student() { StudentID = 4,  FirstName = "Lisa", LastName = "Miller", AdmissionMonth = month.February, Grade = 'A'  },
                new Student() { StudentID = 5,   FirstName = "Run", LastName = "Liu", AdmissionMonth = month.October, Grade = 'A'  },
                new Student() { StudentID = 6,  FirstName = "Sean", LastName = "Stewart", AdmissionMonth = month.April, Grade = 'A'  },
                new Student() {StudentID = 7, FirstName = "Olinda", LastName = "Turner", AdmissionMonth = month.March, Grade = 'A' },
                new Student() {StudentID = 8, FirstName = "Jon", LastName = "Orton", AdmissionMonth = month.May, Grade = 'A' },
                new Student() {StudentID = 9, FirstName = "Toby", LastName = "Nixon", AdmissionMonth = month.June, Grade = 'A' },
                new Student() {StudentID = 10, FirstName = "Daniela", LastName = "Guinot", AdmissionMonth = month.July, Grade = 'A' },
            };
            return Students;
        }
    }
}
