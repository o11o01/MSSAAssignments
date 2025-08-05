//test
namespace Assignment1._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many natural numbers would you like to add? In sequence from 1");
            int numQuantity = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= numQuantity; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }
    }
}
