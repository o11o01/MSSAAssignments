namespace Assignment10._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> ints = new List<int> { 2, -1, 3, -3, 10, -200 };
            var intQuery = from num in ints
                           where num > 0
                           select num;
            foreach(int num in intQuery)
            {
                Console.Write($"{num}, ");
            }
        }
    }
}
