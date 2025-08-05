namespace Assignment3._2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arraySize = 4;
            double[] userInput = new double[arraySize];
            for(int i = 0; i <arraySize; i++)
            {
                Console.Write($"Enter data element {i}:");
                userInput[i] = ValidateDouble(Console.ReadLine());
            }
            double[] result = Average(userInput);
            foreach(double i in result)
            {
                Console.WriteLine(i);
            }
        }
        static double[] Average(double[] input)
        {
            double[] result = new double[2];
            foreach ( double i in input )
            {
                result[0] += i;
            }
            result[1] = result[0] / input.Length;
            return result;
        }
        static double ValidateDouble(string input)
        {
            double result;
            while(!double.TryParse(input, out result))
            {
                Console.WriteLine("Please enter a valid double");
                input = Console.ReadLine();
            }
            return result;
        }
    }
}
