namespace Assignment12._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ransomNote = "abaaaaa";
            string magazine = "abaccaadaa";
            Dictionary<char, int> noteCount = new Dictionary<char, int>();
            Dictionary<char, int> magazineCount = new Dictionary<char, int>();
            bool valid = true;
            foreach (char character in ransomNote)
            {
                if(noteCount.ContainsKey(character))
                {
                    noteCount[character]++;
                }
                else
                {
                    noteCount.Add(character, 1);
                }
            }
            foreach (char character in magazine)
            {
                if (magazineCount.ContainsKey(character))
                {
                    magazineCount[character]++;
                }
                else
                {
                    magazineCount.Add(character, 1);
                }
            }
            foreach (var pair in noteCount)
            {
                if (!magazineCount.ContainsKey(pair.Key))
                {
                    valid = false;
                }
                else
                { 
                    if (pair.Value > magazineCount[pair.Key])
                    {
                        valid = false;
                    }
                }
            }
            Console.WriteLine(valid);
        }
    }
}
