using System.Collections.Generic;
using TreeImplementation;
using Xunit;

namespace TestProject1
{
    public class BinaryTreeTests
    {
        [Fact]
        public void TestConvertToBST()
        {
            // Arrange: Create the specified binary tree
            BinaryTree bTree = new BinaryTree();
            bTree.Root = new Node(35);
            bTree.Root.Left = new Node(20);
            bTree.Root.Right = new Node(50);
            bTree.Root.Left.Left = new Node(10);
            bTree.Root.Left.Right = new Node(40);
            bTree.Root.Right.Right = new Node(60);
            bTree.Root.Left.Left.Left = new Node(5);

            // Act: Convert the binary tree to a binary search tree
            bTree.ConvertToBST();

            // Assert: Check the expected values after conversion
            List<int> expectedValues = new List<int> { 5, 10, 20, 35, 40, 50, 60 };
            List<int> actualValues = bTree.InOrder();

            Assert.Equal(expectedValues, actualValues);
        }

        [Fact]
        public void TestConvertToBST_LeftSkewedTree()
        {
            // Arrange: Create a left-skewed binary tree
            BinaryTree bTree = new BinaryTree();
            bTree.Root = new Node(5);
            bTree.Root.Left = new Node(4);
            bTree.Root.Left.Left = new Node(3);
            bTree.Root.Left.Left.Left = new Node(2);

            // Act: Convert the binary tree to a binary search tree
            bTree.ConvertToBST();

            // Assert: Check the expected values after conversion
            List<int> expectedValues = new List<int> { 2, 3, 4, 5 };
            List<int> actualValues = bTree.InOrder();

            Assert.Equal(expectedValues, actualValues);
        }

        [Fact]
        public void TestConvertToBST_RightSkewedTree()
        {
            // Arrange: Create a right-skewed binary tree
            BinaryTree bTree = new BinaryTree();
            bTree.Root = new Node(1);
            bTree.Root.Right = new Node(2);
            bTree.Root.Right.Right = new Node(3);
            bTree.Root.Right.Right.Right = new Node(4);

            // Act: Convert the binary tree to a binary search tree
            bTree.ConvertToBST();

            // Assert: Check the expected values after conversion
            List<int> expectedValues = new List<int> { 1, 2, 3, 4 };
            List<int> actualValues = bTree.InOrder();

            Assert.Equal(expectedValues, actualValues);
        }

        [Fact]
        public void TestConvertToBST_MixedOneSidedTree()
        {
            // Arrange: Create a mixed one-sided tree (left and right)
            BinaryTree bTree = new BinaryTree();
            bTree.Root = new Node(30);
            bTree.Root.Left = new Node(20);
            bTree.Root.Right = new Node(40);
            bTree.Root.Left.Left = new Node(10);
            bTree.Root.Right.Right = new Node(50);
            bTree.Root.Left.Left.Left = new Node(5);

            // Act: Convert the binary tree to a binary search tree
            bTree.ConvertToBST();

            // Assert: Check the expected values after conversion
            List<int> expectedValues = new List<int> { 5, 10, 20, 30, 40, 50 };
            List<int> actualValues = bTree.InOrder();

            Assert.Equal(expectedValues, actualValues);
        }
    }
}
