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



            //checks if the node needs to go to the right of the current node, then checks if the node can be placed the current nodes child
            if (CurrentNode.value < value) 
            {
                if (CurrentNode.rightNode == null)
                {
                    CurrentNode.rightNode = new Node(value, name);
                }
                else
                {
                    AddValueToTree(currentTree, CurrentNode.rightNode, value, name);
                }
            }

            //same same but different
            if (CurrentNode.value > value)
            {
                if (CurrentNode.leftNode == null)
                {
                    CurrentNode.leftNode = new Node(value, name);
                }
                else
                {
                    AddValueToTree(currentTree, CurrentNode.leftNode, value, name);
                }
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
            leftNode = null;
            rightNode = null;
        }
    }
}
