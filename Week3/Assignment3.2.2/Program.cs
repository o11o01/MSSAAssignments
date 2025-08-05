using System.Net.Http.Headers;

namespace Assignment3._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter desired size of array.");
            int arraySize = IntInput(Console.ReadLine());
            int[,] numbers1 = new int[arraySize, arraySize];
            int[,] numbers2 = new int[arraySize , arraySize ];
            int[,] result = new int[arraySize , arraySize];
            Console.WriteLine("Array 1");
            for (int i2 = 0; i2 < numbers1.GetLength(1); i2++)
            {
                for (int i = 0; i < numbers1.GetLength(0); i++)
                {
                    Console.WriteLine($"Enter data element {i}, {i2}");
                    numbers1[i, i2] = IntInput(Console.ReadLine());
                }
            }
            Console.WriteLine("Array 2");
            for (int i2 = 0; i2 < numbers2.GetLength(1); i2++)
            {
                for (int i = 0; i < numbers2.GetLength(0); i++)
                {
                    Console.WriteLine($"Enter data element {i}, {i2}");
                    numbers2[i, i2] = IntInput(Console.ReadLine());
                }
            }
            for (int i2 = 0; i2 < numbers1.GetLength(1); i2++)
            {
                for (int i = 0; i < numbers1.GetLength(0); i++)
                {
                    result[i,i2] = (numbers1[i, i2] + numbers2[i, i2]);
                }
            }
            foreach (int i in numbers1)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            foreach (int i in numbers2)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            foreach (int i in result)
            {
                Console.Write($"{i} ");
            }
        }
        static int IntInput(string data)
        {
            int result;
            while (!Int32.TryParse(data, out result))
            {
                Console.WriteLine("Please enter a valid integer");
            }
            return result;
        }
    }
}
