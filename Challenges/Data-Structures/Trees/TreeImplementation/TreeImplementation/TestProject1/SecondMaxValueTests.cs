using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeImplementation;

namespace TestProject1
{
    public class SecondMaxValueTests
    {
        [Fact]
        public void FindSecondMax_StandardTree_ReturnsSecondMax()
        {
            // Arrange
            BinaryTree btree = new BinaryTree();
            btree.Root = new Node(10);
            btree.Root.Left = new Node(5);
            btree.Root.Right = new Node(20);
            btree.Root.Left.Left = new Node(3);
            btree.Root.Left.Right = new Node(7);
            btree.Root.Right.Left = new Node(15);
            btree.Root.Right.Right = new Node(25);

            // Act
            int secondMax = btree.FindSecondMax();

            // Assert
            Assert.Equal(20, secondMax);
        }
        [Fact]
        public void FindSecondMax_TreeWithOneNode_ReturnsZero()
        {
            // Arrange
            BinaryTree btree = new BinaryTree();
            btree.Root = new Node(10);

            // Act
            int secondMax = btree.FindSecondMax();

            // Assert
            Assert.Equal(0, secondMax); // Assuming the method returns 0 if there is no second max
        }

        [Fact]
        public void FindSecondMax_TreeWithTwoIdenticalNodes_ReturnsZero()
        {
            // Arrange
            BinaryTree btree = new BinaryTree();
            btree.Root = new Node(10);
            btree.Root.Left = new Node(10);

            // Act
            int secondMax = btree.FindSecondMax();

            // Assert
            Assert.Equal(0, secondMax); // Assuming the method returns 0 if there is no second max
        }
        [Fact]
        public void FindSecondMax_TreeWithNegativeValues_ReturnsSecondMax()
        {
            // Arrange
            BinaryTree btree = new BinaryTree();
            btree.Root = new Node(-10);
            btree.Root.Left = new Node(-20);
            btree.Root.Right = new Node(-5);
            btree.Root.Left.Left = new Node(-30);
            btree.Root.Left.Right = new Node(-15);
            btree.Root.Right.Right = new Node(-1);

            // Act
            int secondMax = btree.FindSecondMax();

            // Assert
            Assert.Equal(-5, secondMax);
        }

    }
}
