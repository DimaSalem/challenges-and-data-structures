using StackAndQueue;
using System.Collections.Generic;
namespace StackAndQueueTests
{
    public class StackTests
    {
        [Fact]
        public void PushNodeTest()
        {
            Stack stack = new Stack();
            stack.Push(10);

            string expectedOutput = "Top -> 10 -> Null";
            string actualOutput = stack.PrintStack();
            Assert.Equal(expectedOutput, actualOutput);
        }

        [Fact]
        public void PopNodeTest()
        {
            Stack stack = new Stack();
            stack.Push(10);
            stack.Push(5);

            stack.Pop();
            string expectedOutput = "Top -> 10 -> Null";
            string actualOutput = stack.PrintStack();
            Assert.Equal(expectedOutput, actualOutput);
        }

        [Fact]
        public void IsEmptyTest()
        {
            Stack stack = new Stack();

            bool expectedOutput= true;
            bool actualOutput= stack.IsEmpty();
            
            Assert.Equal(expectedOutput, actualOutput);
        }
    }
}