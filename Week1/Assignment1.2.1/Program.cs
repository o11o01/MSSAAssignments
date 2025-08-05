// test
namespace Assignment1._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine(num1 + " and " + num2 + " match!");
            }
            else
            {
                Console.WriteLine(num1 + " and " + num2 + " don't match!");
            }
        }
    }
}
