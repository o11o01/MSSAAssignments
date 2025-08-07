namespace ChallengeLab5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] integers = { 2, 2, 1};
            Dictionary<int, int> count = new Dictionary<int, int>();
            for (int i = 0; i < integers.Length; i++)
            {
                if (count.ContainsKey(integers[i]))
                {
                    count[integers[i]]++;
                }
                else
                {
                   count.Add(integers[i], 1);
                }
            }
            foreach (int i in count.Keys)
            {
                if (count[i] == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
