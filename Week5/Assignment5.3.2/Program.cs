namespace Assignment5._3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stairsNum = 6;
            Console.WriteLine(climbVariations(stairsNum));
        }
        static int climbVariations(int stairs)
        {
            int variations1 = 0;
            int variations2 = 1;
            for(int i = 0; i < stairs; i++)
            {
                variations2 = variations1 + variations2;
                variations1 = variations2 - variations1;
            }
            return variations2;
        }
    }
}
