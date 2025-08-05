using System.ComponentModel;

namespace Assignment4._1._1
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Form1 form1 = new Form1();
            Application.Run(form1);
            
        }

    }
    public class Person
    {
       public string FirstName
        { get; set; }
        public string LastName
        { get; set; }
        public string MobilePhone
        { get; set; }
        public string WorkPhone
        { get; set; }
        public string Address
        { get; set; }
        public Person(string firstName, string lastName, string mobilePhone, string workPhone, string address)
        {
            FirstName = firstName;
            LastName = lastName;
            MobilePhone = mobilePhone;
            WorkPhone = workPhone;
            Address = address;

        }
        public Person()
        {
            FirstName = "Default";
            LastName = "Default";
            MobilePhone = "Default";
            WorkPhone = "Default";
            Address = "Default";

        }
    }
    public static class Data
    {
        public static Dictionary<string, Person> CreateData()
        {
            Dictionary<string, Person> people = new Dictionary<string, Person>();
            
            people.Add("JohnSmith", new Person("John", "Smith", "(555)555-5555", "(555)555-5555", "123 Easy Way"));
            people.Add("JoshSmith", new Person("Josh", "Smith", "(555)555-5555", "(555)555-5555", "123 Easy Way"));
            people.Add("RyanSmith", new Person("Ryan", "Smith", "(555)555-5555", "(555)555-5555", "123 Easy Way"));
            return people;
        }
    }
}