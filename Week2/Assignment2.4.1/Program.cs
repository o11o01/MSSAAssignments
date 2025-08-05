namespace Assignment2._4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter desired number of data elements");
            Console.Write("Number of elements:");
            int elements = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int[] data = new int[elements];
            int sum = 0;
            for (int i = 0; i < elements; i++)
            {
                Console.WriteLine($"Please enter data element #{i + 1}");
                data[i] = Convert.ToInt32(Console.ReadLine());
                sum += data[i];
            }
            Console.WriteLine($"Sum of all elements stored in the array is: {sum}");
        }
    }
}
