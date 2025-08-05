namespace Assignment_1._3._1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("What shape would you like to calculate the area of? \n Triangle = t, Square = s Rectangle = r");
            string userInput = Console.ReadLine().ToLower();
            while(userInput != "t" && userInput != "s" && userInput != "r")
                {
                    Console.WriteLine("Please enter a valid shape \"t, s, r\" ");
                    userInput = Console.ReadLine().ToLower();
                }

            Console.WriteLine("Please input shape height");
            double dimension1 = Convert.ToDouble(Console.ReadLine());
            double dimension2;
            if (userInput != "s")
            {
                Console.WriteLine("Please enter shape width/base");
                dimension2 = Convert.ToDouble(Console.ReadLine());
            }
            else
            {
                dimension2 = dimension1;
            }
            switch (userInput)
            {
                case "t":
                    Triangle(dimension1, dimension2);
                    break;
                case "s":
                case "r":
                    Rectangle(dimension1, dimension2);
                    break;
            }
        }
        static void Triangle(double tBase, double tHeight)
        {
            Console.WriteLine(0.5 * tBase * tHeight);
        }

        static void Rectangle(double rBase, double rHeight)
        {
            Console.WriteLine(rBase * rHeight);
        }
    }
}
