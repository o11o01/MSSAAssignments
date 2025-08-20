namespace Assignment7._3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tree tree1 = new Tree();
            int[] ints = { 20, 4, 46, 5, 9, 12, 9, 8, 7, };
            for(int i = 0; i < ints.Length; i++)
            {
                tree1.add(ints[i]);
            }
            Tree tree2 = new Tree();
            tree2.Root = tree1.search(9);
        }
    }
}
