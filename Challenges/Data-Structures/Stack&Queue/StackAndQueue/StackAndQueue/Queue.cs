using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    public class Queue
    {
        private Node front;
        private Node back;
        public void Enqueue(int data)
        {
            Node newNode= new Node(data);
            if (back == null)
                front = back = newNode;
            else
            {
                back.Next = newNode;
                back = newNode;
            }

        }
        public int Dequeue()
        {
            if (front == null)
                throw new Exception("Queue is Empty");
            int data= front.Data;
            front= front.Next;
            return data;
        }
        public int Peek()
        {
            if (front == null)
                throw new Exception("Queue is Empty");
            return front.Data;
        }
        public bool IsEmpty()
        {
            return front == null;
        }
        public string PrintQueue()
        {
            Node current = front;
            string queue = "Front" + " -> ";
            while (current != null)
            {
                queue += current.Data.ToString() + " -> ";
                current = current.Next;
            }
            queue += "Null";
            return queue;
        }

    }
}
