namespace Assignment2._4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] data = { -31, -12, -161, -7 };
            int temp = 0;
            for (int i = 1; i <data.Length; i++)
            {
                if (data[i] > data[temp])
                {
                    temp = i;
                }
            }
            Console.WriteLine(temp);
            Console.WriteLine(data[temp]);
        }
    }
}
