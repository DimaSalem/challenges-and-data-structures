using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackAndQueue;

namespace StackAndQueueTests
{
    public class QueueTests
    {
        [Fact]
        public void EnqueueNodeTest()
        {
            Queue queue = new Queue();
            queue.Enqueue(10);

            string expectedOutput = "Front -> 10 -> Null";
            string actualOutput = queue.PrintQueue();
            Assert.Equal(expectedOutput, actualOutput);
        }

        [Fact]
        public void DequeueNodeTest()
        {
            Queue queue = new Queue();
            queue.Enqueue(10);
            queue.Enqueue(5);

            queue.Dequeue();
            string expectedOutput = "Front -> 5 -> Null";
            string actualOutput = queue.PrintQueue();
            Assert.Equal(expectedOutput, actualOutput);
        }

        [Fact]
        public void IsEmptyTest()
        {
            Queue queue = new Queue();

            bool expectedOutput = true;
            bool actualOutput = queue.IsEmpty();

            Assert.Equal(expectedOutput, actualOutput);
        }
    }
}
