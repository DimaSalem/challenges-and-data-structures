using System.Collections.Generic;
using Xunit;

namespace TreeImplementation.Tests
{
    public class BinarySearchTreeTests
    {
        [Fact]
        public void TestPreOrderTraversal()
        {
            // Arrange
            var tree = new BinarySearchTree(10);
            tree.Add(5);
            tree.Add(15);
            tree.Add(3);
            tree.Add(7);

            var expected = new List<int> { 10, 5, 3, 7, 15 };

            // Act
            var result = tree.PreOrder();

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestInOrderTraversal()
        {
            // Arrange
            var tree = new BinarySearchTree(10);
            tree.Add(5);
            tree.Add(15);
            tree.Add(3);
            tree.Add(7);

            var expected = new List<int> { 3, 5, 7, 10, 15 };

            // Act
            var result = tree.InOrder();

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestPostOrderTraversal()
        {
            // Arrange
            var tree = new BinarySearchTree(10);
            tree.Add(5);
            tree.Add(15);
            tree.Add(3);
            tree.Add(7);

            var expected = new List<int> { 3, 7, 5, 15, 10 };

            // Act
            var result = tree.PostOrder();

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestAddNode()
        {
            // Arrange
            var tree = new BinarySearchTree(10);
            tree.Add(5);
            tree.Add(15);
            tree.Add(3);
            tree.Add(7);

            // Act & Assert
            Assert.True(tree.Contains(5));
            Assert.True(tree.Contains(15));
            Assert.True(tree.Contains(3));
            Assert.True(tree.Contains(7));
            Assert.False(tree.Contains(20));
        }

        [Fact]
        public void TestContainsNode()
        {
            // Arrange
            var tree = new BinarySearchTree(10);
            tree.Add(5);
            tree.Add(15);

            // Act & Assert
            Assert.True(tree.Contains(10));
            Assert.True(tree.Contains(5));
            Assert.True(tree.Contains(15));
            Assert.False(tree.Contains(7));
        }

        [Fact]
        public void TestRemoveNode()
        {
            // Arrange
            var tree = new BinarySearchTree(10);
            tree.Add(5);
            tree.Add(15);
            tree.Add(3);
            tree.Add(7);

            // Act
            tree.Remove(5);

            // Assert
            Assert.False(tree.Contains(5));
   
        }

        [Fact]
        public void TestRemoveNodeWithTwoChildren()
        {
            // Arrange
            var tree = new BinarySearchTree(10);
            tree.Add(5);
            tree.Add(15);
            tree.Add(3);
            tree.Add(7);
            tree.Add(12);
            tree.Add(18);

            // Act
            tree.Remove(15);

            // Assert
            Assert.False(tree.Contains(15));
     
        }
    }
}
