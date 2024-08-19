

using TreeImplementation;

namespace TestProject1
{
    public class MirrorTreeTest
    {
        private BinaryTree CreateSampleTree()
        {
            var tree = new BinaryTree();
            tree.Root = new Node(1);
            tree.Root.Left = new Node(2);
            tree.Root.Right = new Node(3);
            tree.Root.Left.Left = new Node(4);
            tree.Root.Left.Right = new Node(5);
            return tree;
        }

        [Fact]
        public void Test_Mirror_And_InorderTraversal()
        {
            // Arrange
            var tree = CreateSampleTree();

            // Act
            tree.Mirror();
            var result = tree.InOrder();

            // Assert
            var expected = new List<int> { 3, 1, 5, 2, 4 };
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test_SingleNodeTree_Mirror()
        {
            // Arrange
            var tree = new BinaryTree();
            tree.Root = new Node(1);

            // Act
            tree.Mirror();
            var result = tree.InOrder();

            // Assert
            var expected = new List<int> { 1 };
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test_EmptyTree_Mirror()
        {
            // Arrange
            var tree = new BinaryTree();

            // Act
            tree.Mirror();
            var result = tree.InOrder();

            // Assert
            var expected = new List<int>(); // Empty tree, so expected result is an empty list
            Assert.Equal(expected, result);
        }

    }
}
