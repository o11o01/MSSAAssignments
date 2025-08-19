namespace Assignmente7._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 6, 5, 2, 1, 3, 4, 7, 9, 8, 1, 2, 3, 6, 7, 12, 11, 13, 14, 16, 17 };
            int gap = ints.Length;
            Display(ints);
            while (gap > 1)
            {
                gap = (gap / 2);
                for (int i = 0; i < (ints.Length - gap); i++)
                {
                    if (ints[i] > ints[i + gap])
                    {
                        int temp = ints[i];
                        ints[i] = ints[i + gap];
                        ints[i + gap] = temp;
                        Display(ints);
                        if(i > 0)
                        { i -= 2; }
                    }
                }
                
            }
        }
        static void Display(int[] ints)
        {
            for (int i = 0; i < ints.Length; i++)
            {
                Console.Write(ints[i] + ",");
            }
            Console.WriteLine();
        }
    }
}
