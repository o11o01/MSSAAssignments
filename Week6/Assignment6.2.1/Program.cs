namespace Assignment6._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.push(10);
            stack.push(20);
            stack.push(30);
            stack.Display();
            stack.pop();
            stack.pop();
            stack.push(50);
            stack.Display();
        }
    }
    internal class Stack
    {
        private int[] ints = new int[5];
        private int position = -1;

        public void push(int data)
        {
            if (position == ints.Length)
            {
                throw new Exception("Stack is full");
            }
            else
            {
                ints[++position] = data;
            }
        }
        public int pop()
        {
            int data = 0;
            if (position < 0)
            {
                throw new Exception("Stack is empty");
            }
            else
            {
                data = ints[position--];
            }
                return data;
        }
        public int peek()
        {
            return ints[position];
        }
        public void Display()
        {
            for (int i = position; i > -1; i--)
            {
                Console.WriteLine(ints[i]);
            }
        }
    }
}
