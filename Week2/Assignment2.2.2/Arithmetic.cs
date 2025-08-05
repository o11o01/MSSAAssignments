using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2._2._2
{
    public class Arithmetic
    {
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public static decimal Add(decimal num1, decimal num2, decimal num3)
        {
            return num1 + num2 + num3;

        }
        public static float Multiply(float num1, float num2)
        {
            return num1 * num2;
        }
        public static float Multiply(float num1, float num2, float num3)
        {
            return num1 * num2 * num3;
        }
    }
}
