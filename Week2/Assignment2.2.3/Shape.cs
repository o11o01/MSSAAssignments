using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2._2._3
{
    abstract public class Shape
    {
        public int id { get; set; }
        public int name { get; set; }
        public string color { get; set; }

        public string Area()
        {
            return "Calculates area of shape";
        }
    }
    public class Square : Shape
    {
        public int length { get; set; }

        static public double Area(double num1)
        {
            return num1 * num1;
        }
    }
    public class Circle : Shape
    {
        public int radius { get; set; }
        static public double Area(double num1)
        {
            return 3.14 * (num1 * num1);
        }
    }
}
