using StackAndQueue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueueTests
{
    public class MinStackTests
    {
        [Fact]
        public void PushThenGetMinTest()
        {
            MinStack minStack = new MinStack();
            minStack.Push(15);
            minStack.Push(7);  
            minStack.Push(12);
            minStack.Push(3);

            int expectedOutput = 3;
            int actualOutput = minStack.GetMin();
            Assert.Equal(expectedOutput, actualOutput);
        }

        [Fact]
        public void PopThenGetMinTest()
        {
            MinStack minStack = new MinStack();
            minStack.Push(15);
            minStack.Push(7);
            minStack.Push(12);
            minStack.Push(3);
            minStack.Pop();

            int expectedOutput = 7;
            int actualOutput = minStack.GetMin();
            Assert.Equal(expectedOutput, actualOutput);
        }

    }
}
