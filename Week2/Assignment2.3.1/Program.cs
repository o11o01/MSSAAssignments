using System.IO.Enumeration;

namespace Assignment2._3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileName = "Test.txt";
            string name = "John";
            int age = 27;
            string address = "123 easy way Salt Lake City, Utah";
            using (StreamWriter stream = new StreamWriter(fileName))
            {
                stream.WriteLine($"{name} \n {age} \n {address} \n");
            }
            using (StreamReader stream = new StreamReader(fileName))
            {
                string temp;
                while((temp = stream.ReadLine()) != null)
                {
                    Console.WriteLine(temp);
                }
            }
                
        }
    }
}
