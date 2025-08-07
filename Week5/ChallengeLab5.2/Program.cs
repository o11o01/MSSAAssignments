namespace ChallengeLab5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = { 9, 6, 4, 2, 3, 5, 7, 0, 1 };
            input = Sort(input);
            Console.WriteLine(Search(input));
        }
        static int[] Sort(int[] input)
        {
            int temp = 0;
            bool change = true;
            while (change)
            {
                change = false;
                for (int i = 0; i < input.Length; i++)
                {
                    if (i < input.Length - 1)
                    {
                        if (input[i] > input[i + 1])
                        {
                            temp = input[i];
                            input[i] = input[i + 1];
                            input[i + 1] = temp;
                            change = true;
                        }
                    }
                }
            }
            return input;
        }
        static int Search(int[] input)
        {
            for (int i = 0; i < input.Length;i++)
            {
                if (input[i] != i)
                {
                    return (i);
                }
            }
            return input.Length;
        }
    }
}
