using TreeImplementation;
using Xunit;


namespace TestProject1
{
    public class MaxLevelNodesTest
    {
        [Fact]
        public void Test_FindMaxLevelNodes_Example1()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(1);
            Btree.Root.Left = new Node(2);
            Btree.Root.Right = new Node(3);
            Btree.Root.Left.Left = new Node(4);
            Btree.Root.Left.Right = new Node(5);
            Btree.Root.Right.Right = new Node(6);
            Btree.Root.Left.Left.Left = new Node(7);

            // Act
            int maxLevel = Btree.FindMaxLevelNodes();

            // Assert
            Assert.Equal(2, maxLevel); // Level 2 has the most nodes (3 nodes)
        }

        [Fact]
        public void Test_FindMaxLevelNodes_Example2()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(1);
            Btree.Root.Left = new Node(2);
            Btree.Root.Right = new Node(3);
            Btree.Root.Left.Left = new Node(4);
            Btree.Root.Left.Right = new Node(5);
            Btree.Root.Right.Right = new Node(7);
            Btree.Root.Left.Left.Left = new Node(8);
            Btree.Root.Left.Right.Left = new Node(9);
            Btree.Root.Right.Right.Left = new Node(10);

            // Act
            int maxLevel = Btree.FindMaxLevelNodes();

            // Assert
            Assert.Equal(2, maxLevel); // Level 2 has the most nodes (3 nodes)
        }

        [Fact]
        public void Test_FindMaxLevelNodes_EmptyTree()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree();

            // Act
            int maxLevel = Btree.FindMaxLevelNodes();

            // Assert
            Assert.Equal(-1, maxLevel); // Expecting -1 for empty tree (you can customize this behavior)
        }

        [Fact]
        public void Test_FindMaxLevelNodes_SingleNodeTree()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(1);

            // Act
            int maxLevel = Btree.FindMaxLevelNodes();

            // Assert
            Assert.Equal(0, maxLevel); // Only one node at level 0
        }

        [Fact]
        public void Test_FindMaxLevelNodes_MultipleSameLevelMaxNodes()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(1);
            Btree.Root.Left = new Node(2);
            Btree.Root.Right = new Node(3);
            Btree.Root.Left.Left = new Node(4);
            Btree.Root.Right.Right = new Node(5);

            // Act
            int maxLevel = Btree.FindMaxLevelNodes();

            // Assert
            Assert.Equal(1, maxLevel); // Level 1 has the most nodes (2 nodes)
        }
    }

}
