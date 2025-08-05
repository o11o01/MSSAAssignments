using System.Diagnostics.Metrics;

namespace Assignment5._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Palindrome(-121));
        }
        static bool Palindrome(int data)
        {
            if (data < 0)
            {
                return false;
            }
            int counter = 1;
            int dataTemp = data;
            for (int i = 1; i <= data; i = i * 10)
            {
                counter = i;
            }
            for (int i = 10; i < data * 10; i = i * 10)
            {
                if (dataTemp % 10 != (data / counter) % 10)
                {
                    return false;
                }
                counter = counter / 10;
                dataTemp = dataTemp / 10;

            }
            return true;
        }
    }
    
}
