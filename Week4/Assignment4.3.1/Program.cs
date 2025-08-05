namespace Assignment4._3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int electricityUsed = 800;
            double totalCharge = 0;
            if(electricityUsed >= 600)
            {
                totalCharge += 2 * (electricityUsed - 600);
                electricityUsed -= (electricityUsed - 600);
            }
            if(electricityUsed >= 400)
            {
                totalCharge += 1.8 * (electricityUsed - 400);
                electricityUsed -= (electricityUsed - 400);
            }
            if (electricityUsed >= 200)
            {
                totalCharge += 1.5 * (electricityUsed - 200);
                electricityUsed -= (electricityUsed - 200);
            }
            totalCharge += 1.2 * electricityUsed;
            Console.WriteLine(totalCharge);
        }
    }
}
