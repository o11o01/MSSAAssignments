namespace Assignment_4._3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] testData = { 1, 5, 1, 6, 7, 7 };
            Dictionary<int, int> numsCount = new Dictionary<int, int>();
            for (int i = 0; i < testData.Length; i++)
            {
                if (numsCount.ContainsKey(testData[i]))
                {
                    numsCount[testData[i]] ++;
                }
                else
                {
                    numsCount.Add(testData[i], 1);
                }
            }
            foreach (var i in numsCount)
            {
                    if(i.Value == 1)
                {
                    Console.WriteLine(i.Key);
                }    
            }
        }
    }
}
