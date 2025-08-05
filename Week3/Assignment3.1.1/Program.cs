using System.Text;

namespace Assignment3._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int range = 100;
            StringBuilder sb = new StringBuilder();
            for (int i = 2; i <= range; i+= 2)
            {
                sb.Append($"{i}, ");

            }
            Console.WriteLine(sb.ToString());
        }
    }
}
