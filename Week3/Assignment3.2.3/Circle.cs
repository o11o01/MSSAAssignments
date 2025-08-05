using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3._2._3
{
    internal class Circle
    {
        private double area;
        public double Area
        { get; set; }
        public Circle(double radius = 0)
        {
            
            Area = (3.14 * (radius * radius));
        }
        static public Circle operator +(Circle c1, Circle c2)
        {
            Circle circle = new Circle();
            circle.Area = c1.Area + c2.Area;
            return circle;
        }
        static public Circle operator -(Circle c1, Circle c2)
        {
            Circle circle = new Circle();
            circle.Area = Math.Abs(c1.Area - c2.Area);
            return circle;
        }
    }
}
