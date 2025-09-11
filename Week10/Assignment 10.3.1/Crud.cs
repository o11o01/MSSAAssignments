using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_10._3._1
{
    static public class Crud
    {
        public static void addCar(Car input)
        {
            if (GetCarsVin(input.Vin) == null)
            {
                Records.context.Cars.Add(input);
                Records.context.SaveChanges();
            }
        }
        public static List<Car> GetCars()
        {
            return Records.context.Cars.ToList();
        }
        public static Car GetCarsVin(string vin)
        {
            return Records.context.Cars.Find(vin);
        }
        public static void DeleteCar(string vin)
        {
            Car temp = Records.context.Cars.Find(vin);
            if (temp != null)
            {
                Records.context.Cars.Remove(temp);
                Records.context.SaveChanges();
            }
        }
        public static void UpdateCar(string vin, Car input)
        {
            Car selectedCar = Records.context.Cars.Find(vin);
            if(selectedCar != null)
            {
                selectedCar.Manufacture = input.Manufacture;
                selectedCar.Model = input.Model;
                selectedCar.Price = input.Price;
                Records.context.SaveChanges();
            }
        }
    }
}
