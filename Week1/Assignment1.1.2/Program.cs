namespace Assignment1._1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 1st number to be added");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter 2nd number to be added");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The Sum of " + num1 + " and " + num2 + " is " + (num1 + num2));
        }
    }
}
