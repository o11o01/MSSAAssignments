using System.Text;

namespace Assignment_7._1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word1 = "13579";
            string word2 = "24680";
            int stringLength = Math.Max(word1.Length, word2.Length);
            StringBuilder merge = new StringBuilder();
            for (int i = 0; i < stringLength; i++)
            {
                if (i < word1.Length)
                {
                    merge = merge.Append((word1[i]));
                }
                if (i < word2.Length)
                {
                   merge =  merge.Append(word2[i]);
                }
            }
            Console.WriteLine(merge.ToString());
        }
    }
}
