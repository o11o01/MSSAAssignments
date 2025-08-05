using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1._4._1
{
    public class Point
    {
        public string pointName { get; set; }
        public int xCoord { get; set; }
        public int yCoord { get; set; }

        public Point(int x, int y, string Name)
        {
            xCoord = x;
            yCoord = y;
            pointName = Name;
        }

        public void XPosition(int x2, string name2)
        {
            if (x2 > xCoord)
            {
                Console.WriteLine(name2 + " (" + x2 + ") Is further right than " + pointName +  " (" + xCoord + ")");
            }
            else if (x2 < xCoord)
            {
                Console.WriteLine(pointName + " (" + xCoord + ") Is further right than " + name2 + " (" + x2 + ")");
            }
            else
            {
                Console.WriteLine("Points X-Values are the same");
            }

        }
    }
}
