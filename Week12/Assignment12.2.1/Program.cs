namespace Assignment12._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> input = new LinkedList<int>();
            int checkVal = 2;
            input.AddLast(1);
            input.AddLast(2);
            input.AddLast(1);
            input.AddLast(3);
            input.AddLast(2);
            var temp = input.First;
            while(temp != null)
            {
                if (temp.Value == checkVal)
                {
                    temp = temp.Previous;
                    
                    input.Remove(temp.Next);
                }
                    temp = temp.Next;
            }
            foreach(int value in input)
            {
                Console.WriteLine(value);
            }
        }
    }
}
