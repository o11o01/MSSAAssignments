using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "AwAdebe";
            char[] chars = input.ToCharArray();
            string vowels = "aeiou";
            int end = input.Length - 1;
            int start = 0;
            while (start < end)
            {
                bool swap = true;
                for (int i = start; i < end; i++)
                {
                    if (vowels.Contains<char>(char.ToLower(chars[i])))
                    {
                        start = i;
                        break;
                    }
                    else 
                    { 
                        swap = false;
                    }
                }
                for (int i = end; i > start-1; i--)
                {
                    if (vowels.Contains<char>(chars[i]))
                    {
                        end = i;
                        break;
                    }
                    else
                    {
                        swap = false;
                    }
                }
                if (swap == true)
                {
                    char temp = chars[start];
                    chars[start] = chars[end];
                    chars[end] = temp;
                    start++;
                    end--;
                }
            }
            
            Console.WriteLine(input = new string(chars));
        }
    }
}
