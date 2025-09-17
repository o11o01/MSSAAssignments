namespace Assignment11._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[] { 7,1,5,3,6,4 };
            int min = input[0] + 1;
            int profit = 0;
            for(int i = 0; i < input.Length; i++)
            {
                if (input[i] < min)
                {
                    min = (input[i]);
                    for(int j = i; j <input.Length; j++)
                    {
                        if (input[j] - input[i] > profit)
                        {
                            profit = input[j] - input[i];
                        }
                    }
                }
            }
            Console.WriteLine(profit);
        }
    }
}
