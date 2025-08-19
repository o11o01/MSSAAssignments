namespace Assignment7._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] grades = { 98, 97, 65, 80, 70 };
            for (int i = 0; i < grades.Length; i++)
            {
                int smallest = i;
                int temp = 0;
                for (int i2 = i; i2 < grades.Length; i2++)
                {
                    if (grades[i2] < grades[smallest])
                    { smallest = i2; }
                }
                temp = grades[smallest];
                grades[smallest] = grades[i];
                grades[i] = temp;
                for (int i3 = 0; i3 < grades.Length; i3++)
                {
                    Console.Write(grades[i3] + ", ");
                }
                Console.WriteLine();
            }
        }
    }
}
