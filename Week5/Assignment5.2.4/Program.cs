namespace Assignment5._2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "radar";
            Console.WriteLine(Palindrome(input));
        }
        static bool Palindrome(string input)
        {
            if (input.Length > 1)
            {
                if (input[0] == input[input.Length - 1])
                {
                    input = input.Substring(1, input.Length - 2);
                    return Palindrome(input);
                    
                }
                else return false; 
            }
            else
            {
                return true;
            }
        }
    }
}
