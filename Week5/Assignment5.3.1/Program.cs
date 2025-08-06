namespace Assignment5._3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] flowerBed = { 1, 0, 0, 0, 0, 0, 1 };
            int newFlowersGoal = 2;
           Console.WriteLine( CheckArray(flowerBed, newFlowersGoal));
        }
        static bool CheckArray(int[] flowerBed, int newFlowersGoal)
        {
            int newFlowersSum = 0;
            int counter = 0;
            for(int i = 0; i < flowerBed.Length; i++)
            {
                if (flowerBed[i] == 0)
                {
                    counter++;
                }
                else
                {
                    counter = 0;
                }
                if(counter == 3)
                {
                    newFlowersSum++;
                    counter = 1;
                }
                if(newFlowersSum == newFlowersGoal)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
