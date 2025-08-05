namespace Assignment_5._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "Hello world";
            Console.WriteLine(LastWord(input));
        }
        static int LastWord(string input)
        {
            for (int i = input.Length - 1; i > 0; i--)
            {
                if (input[i] == ' ')
                {
                    return(input.Length - i -1);
                }
            }
            return (input.Length);
        }
    }
}
