using Microsoft.VisualBasic;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Buffers.Text;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System;

namespace TreeImplementation
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

            //BinaryTree Btree = new BinaryTree();
            //Btree.Root = new Node(4);
            //Btree.Root.Left = new Node(8);
            //Btree.Root.Right = new Node(7);
            //Btree.Root.Left.Left = new Node(12);
            //Btree.Root.Left.Right = new Node(9);

            //List<int> originalInorder = Btree.InOrder(); // Output: [12, 8, 9, 4, 7]
            //foreach (int i in originalInorder)
            //{
            //    Console.Write(i+", ");
            //}
            //Console.WriteLine("\n");
            //Btree.Mirror();

            //List<int> mirroredInorder = Btree.InOrder(); // Output: [7, 4, 9, 8, 12]
            //foreach (int i in mirroredInorder)
            //{
            //    Console.Write(i + ", ");
            //}

            //BinaryTree Btree = new BinaryTree();
            //Btree.Root = new Node(10);
            //Btree.Root.Left = new Node(5);
            //Btree.Root.Right = new Node(20);
            //Btree.Root.Left.Left = new Node(3);
            //Btree.Root.Left.Right = new Node(7);
            //Btree.Root.Right.Left = new Node(15);
            //Btree.Root.Right.Right = new Node(25);

            //int secondMax = Btree.FindSecondMax(); // Output: 20
            //Console.WriteLine(secondMax);


            //BinaryTree Btree = new BinaryTree();
            //Btree.Root = new Node(9);
            //Btree.Root.Left = new Node(8);
            //Btree.Root.Right = new Node(12);
            //Btree.Root.Left.Left = new Node(3);
            //Btree.Root.Left.Right = new Node(7);
            //Btree.Root.Right.Left = new Node(17);
            //Btree.Root.Right.Right = new Node(23);
            //Btree.Root.Left.Left.Right = new Node(4);

            //int leafSum = Btree.SumOfLeafNodes(); // Output: 51
            //Console.WriteLine(leafSum);

            //BinaryTree Btree = new BinaryTree();
            //Btree.Root = new Node(5);
            //Btree.Root.Left = new Node(13);
            //Btree.Root.Right = new Node(7);
            //Btree.Root.Left.Left = new Node(3);
            //Btree.Root.Left.Right = new Node(7);
            //Btree.Root.Right.Left = new Node(12);
            //Btree.Root.Right.Right = new Node(20);
            //Btree.Root.Left.Left.Left = new Node(1);
            //Btree.Root.Left.Left.Right = new Node(4);
            //Btree.Root.Right.Left.Right = new Node(11);

            //List<int> largestValues = Btree.LargestValueEachLevel(); // Output: [5, 13, 20, 11]

            //foreach (int value in largestValues)
            //{
            //    Console.Write(value+", ");
            //}

            //BinaryTree Btree = new BinaryTree();
            //Btree.Root = new Node(2);
            //Btree.Root.Left = new Node(3);
            //Btree.Root.Right = new Node(5);
            //Btree.Root.Left.Left = new Node(4);
            //Btree.Root.Right.Right = new Node(6);
            //Btree.Root.Left.Left.Right = new Node(7);

            //Btree.PrintRightView();  // Output: 2 5 6 7

            //BinaryTree Btree = new BinaryTree();
            //Btree.Root = new Node(1);
            //Btree.Root.Left = new Node(2);
            //Btree.Root.Right = new Node(3);
            //Btree.Root.Left.Left = new Node(4);
            //Btree.Root.Left.Right = new Node(5);
            //Btree.Root.Right.Right = new Node(6);
            //Btree.Root.Left.Left.Left = new Node(7);

            //int maxLevel = Btree.FindMaxLevelNodes(); // Output: 2
            //Console.WriteLine(maxLevel);

            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(1);
            Btree.Root.Left = new Node(2);
            Btree.Root.Right = new Node(3);
            Btree.Root.Left.Left = new Node(4);
            Btree.Root.Left.Right = new Node(5);


            //        1
            //      /   \
            //  2     3
            // / \
            //4   5

            int minDepth = Btree.FindMinimumDepth(); // Output: 2
            Console.WriteLine(minDepth);

            //BinaryTree Btree = new BinaryTree();
            //Btree.Root = new Node(1);
            //Btree.Root.Left = new Node(2);
            //Btree.Root.Right = new Node(3);
            //Btree.Root.Left.Right = new Node(5);
            //Btree.Root.Right.Right = new Node(6);
            //int minDepth = Btree.FindMinimumDepth(); 
            //Console.WriteLine(minDepth); //output = 3

            //// The resulting tree will be:
            ////      1
            ////    /   \
            ////   2     3
            ////    \     \
            ////     5     6

        }
    }
}
