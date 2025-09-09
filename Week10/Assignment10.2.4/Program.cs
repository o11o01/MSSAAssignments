namespace Assignment10._2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            List<int> ints = new List<int>();
            for(int i = 0; i < 10; i++)
            {
                ints.Add(rand.Next(60, 100));
                
            }
            var intQuerry = from num in ints
                            where num > 80
                            select num;
            foreach(int num in intQuerry)
            {
                Console.WriteLine(num);
            }
        }
    }
}
