namespace Assignment3._2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(5);
            Circle c2 = new Circle(5);
            Circle c3 = c1 + c2;
            Console.WriteLine(c3.Area);
        }
    }
}
