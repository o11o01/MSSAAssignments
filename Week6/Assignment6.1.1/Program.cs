using System.ComponentModel.DataAnnotations;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;

namespace Assignment6._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Llist data = new Llist();
            House newHouse = new House(1, "1 Easy Way", typeHome.Colonial);
            House newHouse1 = new House(2, "2 Easy Way", typeHome.Colonial);
            House newHouse2 = new House(3, "3 Easy Way", typeHome.Colonial);

            data.AddFirst(newHouse);
            data.AddFirst(newHouse1);
            data.AddFirst(newHouse2);
            Console.WriteLine(data.search(3));
            data.RemoveFirst();
            Console.WriteLine(data.search(3));

        }
    }
    public enum typeHome
    {
        Default,
        Ranch,
        Colonial,
        TownHome,
        Apartment


    }
    public class House
    {
        public int Number { get; set; }
        public string Address { get; set; }

       public  typeHome Type { get; set; }
        public House()
        {
            Number = 0;
            Address = "";
            Type = typeHome.Default;
        }
        public House(int number, string address, typeHome type)
        {
            Number = number;
            Address = address;
            Type = type;
        }
        public void Print()
        {
            Console.WriteLine($"{Number}\n{Address}\n{Type}");
        }

    }
    public class Llist
    {
        private int length;
        private Node head;
        
        public Llist()
        {
            head = null;
            length = 0;
        }
        public class Node
        {
            public House Data { get; set; }
            public Node Next { get; set; }
            public Node(House data)
            {
                Data = data;
                Next = null;
            }
        }
        public void AddFirst(House data)
        {
            Node newNode = new Node(data);
            if(length == 0 )
            {
                head = newNode;
            }
            else
            {
                newNode.Next = head;
                head = newNode;
            }
            length++;
        }
        public void RemoveFirst()
        {
            if(length == 0 )
            {
                throw new Exception("No data to remove");
            }
            else
            {
                head = head.Next;
                length--;
            }
        }
        public bool search(int searchTerm)
        {
            Node temp = head;
            while (temp != null)
            {
                if (temp.Data.Number == searchTerm)
                {
                    temp.Data.Print();
                    return true;
                }
                temp = temp.Next;
            }
            return false;
        }

    }
}
