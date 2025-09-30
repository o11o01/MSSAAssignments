namespace Assignment12._3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "abbacad";
            Stack<Char> stringData = new Stack<Char>();
            
            for(int i = 0; i < input.Length; i++)
            {
                if(stringData.TryPeek(out char result))
                {
                    if(result == input[i])
                    {
                        stringData.Pop();
                    }
                    else
                    {
                        stringData.Push(input[i]);
                    }
                }
                else
                {
                    stringData.Push(input[i]);
                }
            }
            input = new string(stringData.Reverse().ToArray());
            
            Console.WriteLine(input);
        }

    }
}
