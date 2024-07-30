using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    public class StackWithReverse: Stack
    {
        public void ReverseStack()
        {
            Queue queue = new Queue();
            Stack reversedStack = new Stack();
            while(top != null)
            {
                queue.Enqueue(this.Pop());
            }
            while(!queue.IsEmpty())
            {
                this.Push(queue.Dequeue());
            }
        }
    }
}
