using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeImplementation;

namespace TestProject1
{
    public class RightViewtest
    {
        [Fact]
        public void TestRightView_WithGivenExample()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(2);
            Btree.Root.Left = new Node(3);
            Btree.Root.Right = new Node(5);
            Btree.Root.Left.Left = new Node(4);
            Btree.Root.Right.Right = new Node(6);
            Btree.Root.Left.Left.Right = new Node(7);

            // Capture console output
            var output = new StringWriter();
            Console.SetOut(output);

            // Act
            Btree.PrintRightView();

            // Assert
            string expectedOutput = "2 5 6 7 ";
            Assert.Equal(expectedOutput, output.ToString());
        }


        [Fact]
        public void TestRightView_WithNodesOnRightSide()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(1);
            Btree.Root.Right = new Node(2);
            Btree.Root.Right.Right = new Node(3);
            Btree.Root.Right.Right.Right = new Node(4);

            // Capture console output
            var output = new StringWriter();
            Console.SetOut(output);

            // Act
            Btree.PrintRightView();

            // Assert
            string expectedOutput = "1 2 3 4 ";
            Assert.Equal(expectedOutput, output.ToString());
        }
    }
}
