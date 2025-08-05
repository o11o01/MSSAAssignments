using System.ComponentModel.Design;
//test
namespace Assignment1._2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool again = true;
            do
            { 
                Console.WriteLine("Please Enter your first number");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please Enter symbol of desired operation");
                string operation = Console.ReadLine();

                Console.WriteLine("Please enter your second number");
                int num2 = Convert.ToInt32(Console.ReadLine());

                int solution = 0;
                bool complete = false;
                while (!complete)
                {
                    switch (operation)
                    {
                        case "+":
                            solution = num1 + num2;
                            complete = true;
                            Console.WriteLine(num1 + "+" + num2 + "=" + solution);
                            break;

                        case "-":
                            solution = num1 - num2;
                            complete = true;
                            Console.WriteLine(num1 + "-" + num2 + "=" + solution);
                            break;

                        case "*":
                            solution = num1 * num2;
                            complete = true;
                            Console.WriteLine(num1 + "*" + num2 + "=" + solution);
                            break;

                        case "/":
                            if (num2 != 0)
                            {
                                solution = num1 / num2;
                                Console.WriteLine(num1 + "/" + num2 + "=" + solution);
                            }
                            else
                            {
                                Console.WriteLine("Please divide by a non zero number");
                            }
                            complete = true;
                            break;
                        default:
                            Console.WriteLine("Please enter a valid math operator such as (+, -, /, *)");
                            operation = Console.ReadLine();

                            break;
                    }
                }
                Console.WriteLine("Would you like to perform another operation? (y/n)");
                if (Console.ReadLine().ToLower() == "y")
                {
                    again = true;
                }
                else
                {
                    again = false;
                }

            } while (again);
        }
    }
}
