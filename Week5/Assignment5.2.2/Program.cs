namespace Assignment5._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 10;
            int num1 = 1;
            printNatural(num1, count);
        }
        static void printNatural(int num1, int count)
        {
            if (num1 <= count)
            {
                Console.WriteLine(num1);
                num1++;
                printNatural(num1, count);
            }
        }
    }
}
