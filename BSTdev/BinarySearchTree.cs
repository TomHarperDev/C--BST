using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSTdev
{
    internal class BinarySearchTree
    {
        public Node root;

        public BinarySearchTree(string name)
        {
            this.root = new Node(10, name);
        }

        public void AddValueToTree(BinarySearchTree currentTree, Node CurrentNode, int value, string name)
        {
            if (currentTree.root == null) 
            {
                Console.WriteLine("Tree is null");
                return;
            }
            if (CurrentNode == null)
            {
                CurrentNode = new Node(value, name);
                return;
            }


            if (CurrentNode.value < value) 
            {
                AddValueToTree(currentTree, CurrentNode.rightNode, value, name);
            }
            if (CurrentNode.value > value)
            {
                AddValueToTree(currentTree, CurrentNode.leftNode, value, name);
            }
        }
    }

    public class Node
    {
        
        public int value;
        public string Name;

        public Node leftNode;
        public Node rightNode;



        public Node(int value, string name)
        {
            this.value = value;
            this.Name = name;
        }
    }
}
