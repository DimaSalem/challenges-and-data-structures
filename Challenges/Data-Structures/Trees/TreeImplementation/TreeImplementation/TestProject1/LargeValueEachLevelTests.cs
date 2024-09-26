using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeImplementation;

namespace TestProject1
{
    public class LargeValueEachLevelTests
    {
        [Fact]
        public void LargestValueEachLevel_SumOfLargestValues_IsCorrect()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(5);
            Btree.Root.Left = new Node(13);
            Btree.Root.Right = new Node(7);
            Btree.Root.Left.Left = new Node(3);
            Btree.Root.Left.Right = new Node(7);
            Btree.Root.Right.Left = new Node(12);
            Btree.Root.Right.Right = new Node(20);
            Btree.Root.Left.Left.Left = new Node(1);
            Btree.Root.Left.Left.Right = new Node(4);
            Btree.Root.Right.Left.Right = new Node(11);

            // Act
            List<int> largestValues = Btree.LargestValueEachLevel();
            int sumOfLargestValues = 0;
            foreach (int value in largestValues)
            {
                sumOfLargestValues += value;
            }

            // Assert
            Assert.Equal(49, sumOfLargestValues);
        }
    }
}
