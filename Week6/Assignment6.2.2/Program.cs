namespace Assignment6._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] data = { 2, 3, 4, 5, 6 };
            int[] left = new int[data.Length];
            int[] right = new int[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                if (i ==0)
                {
                    left[i] = data[i];
                }
                else
                {
                    left[i] = left[i-1] * data[i];
                }
            }
            for (int i = data.Length - 1;i >= 0; i--)
            {
                if (i == data.Length - 1)
                {
                    right[i] = data[i];
                }
                else
                {
                    right[i] = right[i + 1] * data[i];
                }
            }
            for (int i = 0; i < data.Length; i++)
            {
                if (i == 0)
                {
                    data[i] = right[i + 1];
                }
                else if (i == data.Length - 1)
                {
                    data[i] = left[i - 1];
                }
                else
                {
                    data[i] = left[i - 1] * right[i + 1];
                }
                Console.WriteLine(data[i]);
            }

        }
    }
}
