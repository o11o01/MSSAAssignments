namespace Assignment10._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee(5001, 29, "John"),
                new Employee(5001, 30, "Henry"),
                new Employee(5000, 29, "Josh"),
                new Employee(6000, 19, "Chad")
            };
            var employeeQuery = from employee in employees
                                where employee.Age < 30 && employee.Salary > 5000
                                select employee;
            foreach(Employee employee in employeeQuery)
            {
                Console.WriteLine($"Name-{employee.Name} Salary-{employee.Salary} Age-{employee.Age}");
            }
                 
        }
    }
    public class Employee
    {
        public int Salary
        { get; set; }
        public int Age
        { get; set; }
        public string Name
        { get; set; }
        public Employee(int salary, int age, string name)
        {
            Salary = salary;
            Age = age;
            Name = name;
        }
    }
}
