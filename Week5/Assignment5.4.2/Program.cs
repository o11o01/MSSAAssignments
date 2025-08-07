namespace Assignment5._4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = { { 1, 2, 3, }, { 4, 5, 6 }, { 7, 8, 9 } };
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int i2 = 0; i2 < matrix.GetLength(1); i2++)
                {
                    Console.Write(matrix[i, i2]);
                }
                Console.WriteLine();
                sum += matrix[i, i];
            }
            Console.WriteLine("\n");
            Console.WriteLine(sum);
        }
    }
}
