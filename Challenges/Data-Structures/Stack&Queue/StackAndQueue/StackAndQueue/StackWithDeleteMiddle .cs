using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    public class StackWithDeleteMiddle:Stack 
    {
        public void DeleteMiddle()
        {
            if (this.Count == 0 ) return;
            int midIndex = (Count % 2 == 0 ? Count / 2 - 1 : Count / 2);
            int iterations = Count - midIndex;
            int count = 0;
            Stack stack = new Stack();
            while(this.top != null)
            {
                count++;
                if(count != iterations)
                    stack.Push(this.Pop());
                else 
                    this.Pop();
            }
            while (stack.Count > 0)
            {
                this.Push(stack.Pop()); 
            }
        }
    }
}
