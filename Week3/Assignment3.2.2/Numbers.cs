using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3._2._2
{
    internal class Numbers
    {

        public int[,] Numbers1
        { get; set; }
        public Numbers(int size)
        {
            int[,] Numbers1 = new int[size, size];

        }
        public void Input()
        {
            for (int i2 = 0; i2 < Numbers1.GetLength(1); i2++)
            {
                for (int i = 0; i < Numbers1.GetLength(0); i++)
                {
                    Console.WriteLine($"Enter data element {i}");
                    Numbers1[i, i2] = IntInput(Console.ReadLine());
                }
            }
        }
        static int IntInput(string data)
        {
            int result;
            while (!Int32.TryParse(data, out result))
            {
                Console.WriteLine("Please enter a valid integer");
            }
            return result;
        }
    }
}
