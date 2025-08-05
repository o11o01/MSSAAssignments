using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata.Ecma335;

namespace Assignment2._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            while (repeat)
            {
                Console.WriteLine("Enter numbers for operation (n if value not needed)");
                string temp1 = Console.ReadLine();
                Console.WriteLine("Enter numbers for operation (n if value not needed)");
                string temp2 = Console.ReadLine();
                Console.WriteLine("Enter numbers for operation (n if value not needed)");
                string temp3 = Console.ReadLine();
                Console.WriteLine("Enter symbol of desired operation(+, *)");
                string operation = Console.ReadLine();
                if (operation == "+")
                {
                    if (decimal.TryParse(temp3, out decimal num3))
                    {
                        decimal.TryParse(temp2, out decimal num2);
                        decimal.TryParse(temp1, out decimal num1);

                        decimal sum = Arithmetic.Add(num1, num2, num3);
                        Console.WriteLine(sum);
                    }
                    else
                    {
                        int.TryParse(temp1, out int num1);
                        int.TryParse(temp2, out int num2);

                        int sum = Arithmetic.Add(num1, num2);
                        Console.WriteLine(sum);
                    }
                }
                else if (operation == "*")
                {
                    if (float.TryParse(temp3, out float num3))
                    {
                        float.TryParse(temp2, out float num2);
                        float.TryParse(temp1, out float num1);
                        float product = Arithmetic.Multiply(num1, num2, num3);
                        Console.WriteLine(product);
                    }
                    else
                    {
                        float.TryParse(temp1, out float num1);
                        float.TryParse(temp2, out float num2);
                        float product = Arithmetic.Multiply(num1, num2);
                        Console.WriteLine(product);
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid math symbol. Either \"+\" or \"*\"");
                    operation = Console.ReadLine();
                }
                Console.WriteLine("Would you like to continue? (y/n)");
                if(Console.ReadLine().ToLower() == "n")
                {
                    repeat = false;
                }
            }
        }
    }
}
