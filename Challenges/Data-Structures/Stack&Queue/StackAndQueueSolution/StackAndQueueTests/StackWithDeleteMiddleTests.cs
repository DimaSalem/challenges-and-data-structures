using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackAndQueue;


namespace StackAndQueueTests
{
    public class StackWithDeleteMiddleTests
    {
        [Fact]
        public void DeleteMiddleOddStackTest()
        {
            StackWithDeleteMiddle stack = new StackWithDeleteMiddle();
            stack.Push(7);
            stack.Push(14);
            stack.Push(3);
            stack.Push(8);
            stack.Push(5);

            stack.DeleteMiddle();
            string expectedOutput= "Top -> 5 -> 8 -> 14 -> 7 -> Null";
            string actualOutput = stack.PrintStack().ToString();

            Assert.Equal(expectedOutput, actualOutput);
        }

        [Fact]
        public void DeleteMiddleEvenStackTest()
        {
            StackWithDeleteMiddle stack = new StackWithDeleteMiddle();
            stack.Push(7);
            stack.Push(14);
            stack.Push(3);
            stack.Push(8);

            stack.DeleteMiddle();
            string expectedOutput = "Top -> 8 -> 3 -> 7 -> Null";
            string actualOutput = stack.PrintStack().ToString();

            Assert.Equal(expectedOutput, actualOutput);
        }
    }
}
