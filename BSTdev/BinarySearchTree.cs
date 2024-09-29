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

        public void AddValueToTree( Node CurrentNode, int value, string name)
        {
            //checks if the node needs to go to the right of the current node, then checks if the node can be placed the current nodes child
            if (CurrentNode.value < value) 
            {
                if (CurrentNode.rightNode == null)
                {
                    CurrentNode.rightNode = new Node(value, name);
                }
                else
                {
                    AddValueToTree(CurrentNode.rightNode, value, name);
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
                    AddValueToTree(CurrentNode.leftNode, value, name);
                }
            }
        }

        public void EditTreeNode(Node CurrentNode, int value, string name)
        {
            if (CurrentNode.Name == name)
            {
                Console.WriteLine($"The node you are searching for has been found {CurrentNode.Name}");
                Console.WriteLine("Please enter its new name:");

                string newName = Console.ReadLine();

                CurrentNode.Name = newName;
                return;
            }

            if (CurrentNode.value < value)
            {
                if (CurrentNode.rightNode == null)
                {
                    CurrentNode.rightNode = new Node(value, name);
                }
                else
                {
                    EditTreeNode(CurrentNode.rightNode, value, name);
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
                    EditTreeNode(CurrentNode.leftNode, value, name);
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
