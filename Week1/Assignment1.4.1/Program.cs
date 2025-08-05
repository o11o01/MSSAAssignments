using System.ComponentModel.Design;

namespace Assignment_1._4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point P1 = new Point(10, 20, "P1");
 
            Point P2 = new Point(20, 30, "P2");

            P1.XPosition(P2.xCoord, P2.pointName);
        }
        
    }
}
