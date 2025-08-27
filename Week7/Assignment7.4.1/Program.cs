namespace Assignment7._4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ParkingSystem Cars = new ParkingSystem(2, 1, 3);
            Console.WriteLine(Cars.addCar(0));
            Console.WriteLine(Cars.addCar(0));
            Console.WriteLine(Cars.addCar(0));
            Console.WriteLine(Cars.addCar(1));
            Console.WriteLine(Cars.addCar(1));
        }
    }
    public class ParkingSystem
    {
        int[] capacities = new int[3];
        public ParkingSystem(int small, int medium, int big)
        {
            capacities[0] = small;
            capacities[1] = medium;
            capacities[2] = big;
        }
        public bool addCar(int carType)
        {

             if (capacities[carType] > 0)
            {
                capacities[carType]--;
                return true;
            }
            return false;
        }
    }
}
