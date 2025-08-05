namespace Assignment4._2._1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
        
    }
    public class Student : IComparable<Student>
    {
        public string StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string GradeAverage { get; set; }
        public bool Selected { get; set; }
        public int CompareTo(Student otherStudent)
        {
            return Double.Parse(otherStudent.GradeAverage).CompareTo(Double.Parse(GradeAverage));
        }
        public Student(string ID, string FName, string LName, string GAverage)
        {
            StudentID = ID;
            FirstName = FName;
            LastName = LName;
            GradeAverage = GAverage;
            Selected = false;
        }
        public Student()
        {
            StudentID = "0";
            FirstName = "Default";
            LastName = "Default";
            GradeAverage = "0";
            Selected = false;
        }
    }
}