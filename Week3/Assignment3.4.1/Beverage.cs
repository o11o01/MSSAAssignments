using System;
using System.Security.Cryptography.Pkcs;

public abstract class Beverage
{
	public int BevID
	{ get; set; }
	public string BevName
	{ get; set; }
	public DateTime ExpDate
	{ get; set; }
	public Container BevContainer
	{ get; set; }
	public Double SizeInOz
	{ get; set; }

	public Beverage(int BevID, string BevName, DateTime ExpDate, Container BevContainer, Double SizeInOz)
	{

	}
	public Beverage()
	{
        BevID = 0;
        BevName = "";
        ExpDate = new DateTime(2000, 1, 1);
        BevContainer = 0;
        SizeInOz = 16;
    }

}
public class Coffee : Beverage
{
	public Roast CofRoast
	{ get; set; }
	public bool IsDecaf
	{ get; set; }
	public Coffee(Roast CofRoast, bool IsDecaf)
	{

	}
	public Coffee()
	{

	}

}
public static class Data
{
	public static List<Coffee> CreateData()
	{
		List<Coffee> coffees = new List<Coffee>()
		{
            new Coffee() {BevID = 0, BevName = "Coffee", ExpDate = new DateTime(2025, 10, 31), BevContainer = 0, SizeInOz=16, CofRoast = Roast.light, IsDecaf = false },
            new Coffee() {BevID = 0, BevName = "Coffee", ExpDate = new DateTime(2025, 10, 31), BevContainer = 0, SizeInOz=16, CofRoast = Roast.light, IsDecaf = false },
            new Coffee() {BevID = 0, BevName = "Coffee", ExpDate = new DateTime(2025, 10, 31), BevContainer = 0, SizeInOz=16, CofRoast = Roast.light, IsDecaf = false },
            new Coffee() {BevID = 0, BevName = "Coffee", ExpDate = new DateTime(2025, 10, 31), BevContainer = 0, SizeInOz=16, CofRoast = Roast.light, IsDecaf = false },
            new Coffee() {BevID = 0, BevName = "Coffee", ExpDate = new DateTime(2025, 10, 31), BevContainer = Container.Bottle, SizeInOz=16, CofRoast = Roast.light, IsDecaf = false }
        };
		return coffees;
	}
}
public enum Container
{
    Glass,
    Bottle,
    Can
}
public enum Roast
{
	light,
	medium,
	dark
}