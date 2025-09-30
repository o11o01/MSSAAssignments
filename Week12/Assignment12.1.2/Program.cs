namespace Assignment12._1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> input = new LinkedList<int>();
            bool isPalindrome = true;
            input.AddLast(1);
            input.AddLast(0);
            input.AddLast(1);
            input.AddLast(2);
            input.AddLast(1);
            input.AddLast(0);
            input.AddLast(1);


            while (input.Count > 1)
            {
                if (input.First.Value == input.Last.Value)
                {
                    input.RemoveFirst();
                    input.RemoveLast();
                }
                else
                {
                    isPalindrome = false;
                    break;
                }
            }
            Console.WriteLine(isPalindrome);
        }
    }
}
