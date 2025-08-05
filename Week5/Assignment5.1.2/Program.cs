namespace Assignment_5._1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = 123455;
            SumDigits(input);
        }
        static int SumDigits(int inputData)
        {
            int sum = 0;
            while(inputData > 0)
            {
                sum += inputData % 10;
                Console.WriteLine(sum);
                inputData /= 10;
            }
            return sum;
        }
    }
}
