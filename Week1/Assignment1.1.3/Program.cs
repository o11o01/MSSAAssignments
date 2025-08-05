namespace Assignment1._1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Dividend");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Divisor");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your Quotient is " + (num1 / num2) + " with a remainder of " + (num1 % num2));
        }
    }
}
