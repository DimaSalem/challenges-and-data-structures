using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeImplementation;

namespace TestProject1
{
    public class SumOfLeafNodesTests
    {
        [Fact]
        public void Test_LeafSum_With_Example_Tree()
        {
            // Arrange
            BinaryTree btree = new BinaryTree();
            btree.Root = new Node(9);
            btree.Root.Left = new Node(8);
            btree.Root.Right = new Node(12);
            btree.Root.Left.Left = new Node(3);
            btree.Root.Left.Right = new Node(7);
            btree.Root.Right.Left = new Node(17);
            btree.Root.Right.Right = new Node(23);
            btree.Root.Left.Left.Right = new Node(4);

            // Act
            int leafSum = btree.SumOfLeafNodes();

            // Assert
            Assert.Equal(51, leafSum);
        }

        [Fact]
        public void Test_LeafSum_With_Negative_Leaf_Values()
        {
            // Arrange
            BinaryTree btree = new BinaryTree();
            btree.Root = new Node(10);
            btree.Root.Left = new Node(-5);
            btree.Root.Right = new Node(20);
            btree.Root.Left.Left = new Node(-7);
            btree.Root.Left.Right = new Node(-2);
            btree.Root.Right.Left = new Node(15);
            btree.Root.Right.Right = new Node(-3);

            // Act
            int leafSum = btree.SumOfLeafNodes();

            // Assert
            Assert.Equal(3, leafSum); // Leaf nodes are -7, -2, 15, -3. Sum = -7 - 2 + 15 - 3 = 3
        }
    }
}
