using System;
using System.Collections.Generic;

namespace StackAndQueue
{
    public class MinStack : Stack
    {
        private Stack minStack= new Stack();

        
        public override void Push(int x)
        {
            base.Push(x);
            if (minStack.Count == 0 || x <= minStack.Peek())
            {
                minStack.Push(x);
            }
        }

        public override int Pop()
        {
            int poppedElement = base.Pop();
            if (poppedElement == minStack.Peek())
            {
                minStack.Pop();
            }

            return poppedElement;
        }

        public int GetMin()
        {
            if (minStack.Count == 0)
                throw new InvalidOperationException("MinStack is empty");

            return minStack.Peek();
        }
    }

}

