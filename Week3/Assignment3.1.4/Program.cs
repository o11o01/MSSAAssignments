namespace Assignment3._1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter data in .csv format with trailling \",\" ie \"10, 0, 1, 2, 20,\"");
            int[] data = SeperateString(Console.ReadLine());

            for(int i = 0; i < data.Length; i++)
            {
                if (data[i] == 1 && data[i+1] == 1)
                {
                    data[i] = 0;
                    data[i+1] = 0;
                    break;
                }
            }

            for (int i = 0; i < data.Length; i++)
            {
                Console.Write($"{data[i]}, ");
            }
        }
        static int[] SeperateString(string input)
        {
            int dataCount = 0;
            int commaLocation = -2;

            // Counts number of data elements based on seperating character ","
            for (int i = 0; i < input.Length; i++)
            {

                if (input[i] == ',')
                {
                    dataCount++;
                }
            }

            int[] dataOut = new int[dataCount];
            dataCount = 0;
            // Inserts data elements that lead seperating character into table
                for (int i = 0; i < input.Length; i++)
            {
                
                if (input[i] == ',')
                {
                    dataOut[dataCount] = Convert.ToInt32((input.Substring(commaLocation + 2, i - commaLocation - 2)));
                    commaLocation = i;
                    dataCount++;
                }
            }
            return dataOut;
        }
    }
}
