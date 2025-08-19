using System.Text;

namespace Assignment7._2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string string1 = "care";
            string string2 = "race";
            StringBuilder temp = new StringBuilder(string2, string2.Length);
            if (string1.Length == string2.Length)
            {
                for (int i = 0; i < string1.Length; i++)
                {
                    for (int i2 = 0; i2 < temp.Length; i2++)
                    {
                        if (temp[i2] == string1[i])
                        {
                            temp.Remove(i2, 1);
                            break;
                        }

                    }

                }
            }
            if (temp.Length == 0)
            {
                Console.WriteLine($"{string1} and {string2} are anagrams");
            }
            else
            {
                Console.WriteLine($"{string1} and {string2} are not anagrams");
            }
        }
    }
}
