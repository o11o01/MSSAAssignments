namespace Assignment10._2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char startingCharacter = 'A';
            char endingCharacter = 'M';
            string[] Cities = new string[]{"Rome","London","Nairobi","California","Zurich","New Delhi","Amsterdam","Abu Dhabi","Paris" };
            var stringQuery = from city in Cities
                              where city.ToUpper().StartsWith(startingCharacter) && city.ToUpper().EndsWith(endingCharacter)
                              select city;
            foreach(string city in stringQuery)
            {
                Console.WriteLine(city);
            }
        }
    }
}
