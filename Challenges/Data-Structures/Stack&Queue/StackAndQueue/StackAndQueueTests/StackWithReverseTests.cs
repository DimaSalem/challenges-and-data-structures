using StackAndQueue;

namespace StackAndQueueTests
{
    public class StackWithReverseTests
    {
        [Fact]
        public void ReverseStackTest()
        {        
            StackWithReverse stack = new StackWithReverse();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.ReverseStack();
            string expectedOutput = "Top -> 1 -> 2 -> 3 -> 4 -> 5 -> Null";
            string actualOutput = stack.PrintStack();
            Assert.Equal(expectedOutput, actualOutput);
        }

        [Fact]
        public void ReverseStackWithOneNodeTest()
        {
            StackWithReverse stack = new StackWithReverse();
            stack.Push(1);

            stack.ReverseStack();
            string expectedOutput = "Top -> 1 -> Null";
            string actualOutput = stack.PrintStack();
            Assert.Equal(expectedOutput, actualOutput);
        }

        [Fact]
        public void ReverseEmptyStackTest()
        {
            StackWithReverse stack = new StackWithReverse();

            stack.ReverseStack();
            string expectedOutput = "Top -> Null";
            string actualOutput = stack.PrintStack();
            Assert.Equal(expectedOutput, actualOutput);
        }

    }
}
