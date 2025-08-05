using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4._2._1
{
    static public class Data
    {
        public static string ReadFile()
        {
            string fileInput;
            using (StreamReader stream = new StreamReader("StudentData.txt"))
            {
                fileInput = stream.ReadToEnd();
                fileInput = fileInput.TrimEnd();
            }
            return fileInput;
        }
        public static void WriteFile(string data, string location)
        {
            using (StreamWriter stream = new StreamWriter(location))
            {
                stream.WriteLine(data);
            }
        }
        public static void WriteFile(List<Student> data, string location)
        {
            string output = "";
            foreach (Student student in data)
            {
                output += $"{student.StudentID},{student.FirstName},{student.LastName},{student.GradeAverage}\n";
                WriteFile(output, location);
            }
        }
        public static List<Student> BuildList()
        {
            string[] data = Data.ReadFile().Split('\n');
            List<Student> students = new List<Student>();
            for (int i = 0; i < data.Length; i++)
            {
                string[] studentInfo = data[i].Split(',');
       
                students.Add(new Student(studentInfo[0], studentInfo[1], studentInfo[2], studentInfo[3]));
            }
            return students;
        }
        public static List<Student> SortList(List<Student> students)
        {
            students.Sort();

            return students;
        }
    }
}
