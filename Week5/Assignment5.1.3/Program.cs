    namespace Assignment_5._1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 1, 2, 3, 1};
            foreach (int i in ints)
            {
                Console.Write(i + ",");
            }
            Console.WriteLine();
            Console.WriteLine(CheckArrayUnique(ints));
        }
        static bool CheckArrayUnique(int[] inputData)
        {
            Dictionary<int, int> dataCounts = new Dictionary<int, int>();
            for ( int i = 0; i < inputData.Length; i++)
            {
                if (dataCounts.ContainsKey(inputData[i]))
                {
                    return true;
                }
                dataCounts.Add(i, 1);
            }
            return false; 
        }
    }
}
