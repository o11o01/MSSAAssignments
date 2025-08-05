namespace Assignment_3._2._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dataInput = { 6, 7, 8, 3, 2, 1, 0 };
            int searchTerm = 2;
            Console.WriteLine(Search(dataInput, searchTerm));
        }
        static int Search(int[] data, int query )
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == query)
                {
                    return i;
                }
            }
            return -1;
            
        }
    }
}
