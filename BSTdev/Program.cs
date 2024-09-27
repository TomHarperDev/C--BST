using System;
using System.Globalization;

namespace BSTdev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree testTree = new BinarySearchTree("root");


            testTree.AddValueToTree(testTree, testTree.root, 5, "left child");
            testTree.AddValueToTree(testTree, testTree.root, 14, "right child");

            Console.WriteLine(testTree.root.Name);
            Console.WriteLine(testTree.root.rightNode.Name);
            Console.WriteLine(testTree.root.leftNode.Name);
        }
    }
}