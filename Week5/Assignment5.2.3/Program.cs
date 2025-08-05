namespace Assignment5._2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            printNatural(num1);
        }
        static void printNatural(int num1)
        {
            if (num1 > 0)
            {
                Console.WriteLine(num1);
                num1--;
                printNatural(num1);
            }
        }
    }
}
