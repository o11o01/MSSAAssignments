using System.Text.Json;
using System.Xml;
using System.Xml.Serialization;
namespace Assignment10._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student newStudent = new Student();
            newStudent.grade = 91.2;
            newStudent.name = "John";
            newStudent.numAssignments = 10;
            string filename = $"{newStudent.name}";
            TextWriter writer = new StreamWriter(filename);


             string jsonString = JsonSerializer.Serialize(newStudent);
             Console.WriteLine(jsonString);
             Student jsonStudent = JsonSerializer.Deserialize<Student>(jsonString);
             Console.WriteLine(jsonStudent.grade);


            XmlSerializer xmlserializer = new XmlSerializer(typeof(Student));
            xmlserializer.Serialize(writer, newStudent);
            writer.Close();
            Stream filestream = new FileStream(filename, FileMode.Open);
            XmlReader reader = new XmlTextReader(filestream);
            
            Student xmlStudent = (Student)xmlserializer.Deserialize(reader);
            Console.WriteLine(xmlStudent.name);
            reader.Close();
        }
    }
    public class Student
    {
        public double grade
        { get; set;  }
        public string name
        { get; set; }
        public int numAssignments
        { get; set; }
    }
}
