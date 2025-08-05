namespace Assignment3._1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a year to check if its a leap year");
            int year = ReadUserInt();
            if ((year % 4) == 0 && !((year % 100) == 0) || year % 400 == 0)
            {
                Console.WriteLine($"{year} is a leap year");
            }
            else 
            {
                Console.WriteLine($"{year} is not a leap year");
            }
        }
        static int ReadUserInt()
        {
            int result;
            while(!Int32.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine("please enter a valid integer");
            }
            return result;
        }
    }
}
