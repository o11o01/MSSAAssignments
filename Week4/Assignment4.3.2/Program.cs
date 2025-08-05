namespace Assignment4._3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] testData = { 10, 1, 5, 1, 6, 7, 7, 1, 3, 4, 5, 1, 1, 20 };
            Dictionary<int, int> numsCount = new Dictionary<int, int>();
            for (int i = 0; i < testData.Length; i++)
            {
                if (numsCount.ContainsKey(testData[i]))
                {
                    numsCount[testData[i]] += 1;
                }
                else
                {
                    numsCount.Add(testData[i], 1);
                }
            }
            foreach(var i in numsCount)
            {
                Console.WriteLine(i);
            }
        }
    }
}
