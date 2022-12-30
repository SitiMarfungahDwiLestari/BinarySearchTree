using System;

namespace BinarySearchTree
{
    class Node
    {
        public string info;
        public Node leftchild;
        public Node rightchild;
        
        //Constructor for the node class
        public Node (string i, Node l, Node r)
        {
            info = i;
            leftchild = l;
            rightchild = r;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
