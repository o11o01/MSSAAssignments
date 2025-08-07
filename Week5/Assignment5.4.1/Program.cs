namespace Assignment5._4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputData = 1234;
            printDigit(inputData);
        }
        static void printDigit(int data)
        {

            if (data > 9)
            {
                printDigit(data / 10);
            }
            Console.Write(data % 10 + " ");
        }
    }
}
