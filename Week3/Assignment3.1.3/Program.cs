namespace Assignment3._1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to determine number of spaces");
            string userIn = Console.ReadLine();
            int spacesCount = 0;
            for (int i = 0; i < userIn.Length; i++)
            {
                if (userIn[i] == ' ')
                {
                    spacesCount++;
                }
            }
            Console.WriteLine($" \"{userIn}\" contains {spacesCount} spaces");
        }
    }
}
