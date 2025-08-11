namespace Assignment6._1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] data = { 0, 1, 0, 3, 0, 4, 12, 0};
            int zeroCount = 1;
            for(int i = 0; i < data.Length - zeroCount; i++)
            {

                if (data[i + zeroCount] != 0)
                {
                    data[i] = data[i + zeroCount];
                }
                else
                {
                    zeroCount++;
                    i--;
                }
            }
            for(int i = data.Length - zeroCount; i < data.Length; i++)
            {
                data[i] = 0;
            }
            foreach( int i in data)
            {
                Console.WriteLine(i);
            }
            
        }
    }
}
