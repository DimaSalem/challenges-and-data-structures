using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeImplementation;

namespace TestProject1
{
    public class MinimumDepthTests
    {
        [Fact]
        public void TestMinimumDepth_MultipleNodes_VaryingDepths()
        {
            // Arrange: Create a tree like this:
            //      1
            //    /   \
            //   2     3
            //    \     \
            //     5     6
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(1);
            Btree.Root.Left = new Node(2);
            Btree.Root.Right = new Node(3);
            Btree.Root.Left.Right = new Node(5);
            Btree.Root.Right.Right = new Node(6);

            // Act: Calculate minimum depth
            int minDepth = Btree.FindMinimumDepth();

            // Assert: Minimum depth should be 2 (path 1 -> 3)
            Assert.Equal(3, minDepth);
        }

        [Fact]
        public void TestMinimumDepth_EmptyTree()
        {
            // Arrange: Create an empty tree
            BinaryTree Btree = new BinaryTree();

            // Act: Calculate minimum depth
            int minDepth = Btree.FindMinimumDepth();

            // Assert: Minimum depth should be 0 for an empty tree
            Assert.Equal(0, minDepth);
        }
    }
}
