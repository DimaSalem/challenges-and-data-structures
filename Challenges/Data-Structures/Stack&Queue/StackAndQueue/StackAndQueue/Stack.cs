using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    public class Stack
    {
        private Node? top;
        public void Push(int data)
        {
            Node newNode = new Node(data);
            newNode.Next = top;
            top = newNode;
        }
        public int Pop()
        {
            if(top == null)
                throw new Exception("Stack is Empty");
            int data = top.Data;
            top = top.Next;
            return data;
        }
        public bool IsEmpty()
        {
            return top == null;
        }
        public int Peek()
        {
            if (top == null)
                throw new Exception("Stack is Empty");
            return top.Data;
        }
        public string PrintStack()
        {
            Node current = top;
            string stack = "Top" + " -> ";
            while (current != null)
            {
                stack += current.Data.ToString() + " -> ";
                current = current.Next;
            }
            stack += "Null";
            return stack;
        }
    }
}
