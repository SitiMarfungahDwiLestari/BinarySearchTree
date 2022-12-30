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
    //A node class consists os three things, the information, references to the right child, and the reference to the left child
    class BinaryTree
    {
        public Node ROOT;
        public BinaryTree()
        {
            ROOT = null; //Initializing ROOT to the null
        }
        public void insert(string element) //insert a node in the binary search tree
        {
            Node tmp, parent = null, currentNode = null;
            Search(element, ref parent, ref currentNode);
            if (currentNode != null) //check if the node to be inserted already inserted or not
            {
                Console.WriteLine("Duplicate words not allowed");
                return;
            }
            else //if the specified node is not parent 
            {
                tmp = new Node(element, null, null); //creates a node
                if (parent == null) //if the trees is empty
                {
                    ROOT = tmp;
                }
                else if (string.Compare(element, parent.info) > 0)
                {
                    parent.leftchild = tmp;
                }
                else
                {
                    parent.rightchild = tmp;
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
