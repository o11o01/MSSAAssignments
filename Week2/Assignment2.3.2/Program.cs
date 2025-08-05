namespace Assignment2._3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter bill total, prior to tipping");
            double total = Convert.ToDouble(Console.ReadLine());
            double tip = 0;
            Console.WriteLine("Please enter desired tip amount IE(0.25)");
            double percent = Convert.ToDouble(Console.ReadLine());
            if(percent > 1)
            {
                percent = percent / 100;
            }
            tip = (total * percent);
            Console.WriteLine($"Tip {tip.ToString("C")} ({percent.ToString("P")}) for a total of {(tip + total).ToString("C")}");
        }
    }
}
