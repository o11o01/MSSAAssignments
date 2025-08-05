namespace Assignment2._4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter X Coord");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Y Coord");
            int y = Convert.ToInt32(Console.ReadLine());
            if (x > 0)
            {
                if (y > 0)
                {
                    Console.WriteLine($"The point ({x},{y}) is in the first quadrant");
                }
                else
                {
                    Console.WriteLine($"The point ({x},{y}) is in the fourth quadrant");
                }
            }
            else
            {
                if (y > 0)
                {
                    Console.WriteLine($"The point ({x},{y}) is in the second quadrant");
                }
                else
                {
                    Console.WriteLine($"The point ({x},{y}) is in the third quadrant");
                }
            }
        }
    }
}
