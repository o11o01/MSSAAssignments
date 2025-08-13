using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment6._3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            q.Add(1234567890);
            q.Add(1234567891);
            q.Display();
            q.DeQueue();
            q.Display();

        }
    }
    internal class Queue
    {
        Node front;
        Node back;
        int count;
        public Queue()
        {
            count = 0;
        }
        public void Add(int data)
        {
            Node newNode = new Node(data);
            if (count == 0)
            {
                front = newNode;
                back = newNode;
            }
            else
            {
                back.Next = newNode;
                back = newNode;
            }
            count++;
    
        }
        public int DeQueue()
        {
            if (count != 0)
            {
                int temp = front.Data;
                front = front.Next;
                return temp;
            }
            else
            {
                Console.WriteLine("Call queue is empty");
                return 0;
            }
        }
        public void Display()
        {
            Node temp = front;
            while (temp != null)
            {
                Console.WriteLine(temp.Data);
                temp = temp.Next;
            }
        }
        internal class Node
        {
            public int Data
            { get; set; }
            public Node Next
            { get; set; }
            public Node(int data)
            {
                Data = data;
                Next = null;
            }
            public Node()
            {
                Next = null;
            }
        }
    }

}
