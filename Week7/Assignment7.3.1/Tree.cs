using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7._3._1
{
    public class Tree
    {
        public Node Root
        { get; set; }
        public Node Temp
        { get; set; }
        public void add(int newValue)
        {
            if(Root == null)
            {
                Root = new Node(newValue);
            }
            else
            {
                Root.add(newValue);
            }
        }
        public Node search(int searchTerm)
        {
            Temp = Root;
            while(Temp.left != null || Temp.right != null)
            {
                if(searchTerm == Temp.value)
                {
                    return Temp;
                }
                else if(searchTerm < Temp.value)
                {
                    Temp = Temp.left;
                }
                else
                {
                    Temp = Temp.right;
                }
            }
            return null;
        }
    }
    public class Node
    {
        public Node left
        { get; set; }
        public Node right
        { get; set; }
        public int value
        { get; set; }
        public void add(int newValue)
        {
            if (newValue < value)
            {
                if (left == null)
                {
                    left = new Node(newValue);
                }
                else
                {
                    left.add(newValue);
                }
            }
            else
            {
                if (right == null)
                {
                    right = new Node(newValue);
                }
                else
                {
                    right.add(newValue);
                }
            }
        }
        public Node(int passValue)
        {
            value = passValue;
        }
    }
}
