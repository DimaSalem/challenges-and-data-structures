﻿namespace TreeImplementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree bst = new BinarySearchTree(2);

            //// Add nodes to the BST
            //bst.Add(10);
            //bst.Add(5);
            //bst.Add(15);
            //bst.Add(7);

            //// Check if a node exists
            //bool contains = bst.Contains(7); // contains: true
            //Console.WriteLine(contains);
            //// Remove a node
            //bst.Remove(5);

            //// Check if the node is removed
            //contains = bst.Contains(5); // contains: false
            //Console.WriteLine(contains);

            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(4);
            Btree.Root.Left = new Node(8);
            Btree.Root.Right = new Node(7);
            Btree.Root.Left.Left = new Node(12);
            Btree.Root.Left.Right = new Node(9);

            List<int> originalInorder = Btree.InOrder(); // Output: [12, 8, 9, 4, 7]
            foreach (int i in originalInorder)
            {
                Console.Write(i+", ");
            }
            Console.WriteLine("\n");
            Btree.Mirror();

            List<int> mirroredInorder = Btree.InOrder(); // Output: [7, 4, 9, 8, 12]
            foreach (int i in mirroredInorder)
            {
                Console.Write(i + ", ");
            }
        }
    }
}