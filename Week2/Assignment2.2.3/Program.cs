namespace Assignment2._2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Square or Circle? (S, C)");
            string choice = Console.ReadLine();
            switch(choice)
            {
                case "s":
                case "S":
                    Console.WriteLine("Enter length of side");
                    double side = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(Square.Area(side));

                    break;
                case "c":
                case "C":
                    Console.WriteLine("Enter radius of circle");
                    double radius = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(Circle.Area(radius));

                    break;
            }
        }
    }
}
