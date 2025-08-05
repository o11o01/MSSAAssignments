namespace Assignment3._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] numbers = { { 1, 5, 6, }, { 3, 4, 2 } };
            for(int i2 = 0; i2 <= numbers.GetLength(1); i2++)
            {
                for (int i = 0; i < numbers.GetLength(0); i++)
                {
                    Console.Write($"{numbers[i, i2]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
