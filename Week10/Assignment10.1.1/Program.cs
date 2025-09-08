using System.Text.Json;
using System.Xml;
using System.Xml.Serialization;
namespace Assignment10._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> listStudents = new List<Student>();
            listStudents.Add(new Student());
            listStudents.Add(new Student());
            listStudents[0].grade = 91.2;
            listStudents[0].name = "John";
            listStudents[0].numAssignments = 10;
            listStudents[1].grade = 67.3;
            listStudents[1].name = "Josh";
            


            string jsonString = JsonSerializer.Serialize(listStudents);
            Console.WriteLine(jsonString);
            List<Student> jsonStudents = JsonSerializer.Deserialize<List<Student>>(jsonString);
            Console.WriteLine(jsonStudents[0].grade);


            string filename = $"{listStudents[0].name}";
            TextWriter writer = new StreamWriter(filename);
            XmlSerializer xmlserializer = new XmlSerializer(typeof(List<Student>));
            xmlserializer.Serialize(writer, listStudents);
            writer.Close();
            Stream filestream = new FileStream(filename, FileMode.Open);
            XmlReader reader = new XmlTextReader(filestream);
            
            List<Student> xmlStudents = (List<Student>)xmlserializer.Deserialize(reader);
            Console.WriteLine(xmlStudents[0].name);
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
