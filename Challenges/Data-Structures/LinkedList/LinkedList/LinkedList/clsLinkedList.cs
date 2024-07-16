using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class clsLinkedList
    {
        private Node? head;
        private Node? tail;

        public void Add(int Data)
        {
            Node newNode = new Node();
            newNode.Data = Data;
            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.Next = newNode;
                tail= newNode;
            }
        }
        public bool Includes(int data)
        {
            Node current = head;
            while (current != null)
            {
                if(current.Data == data)
                    return true;
                current = current.Next;
            }
            return false;
        }
        public bool Remove(int data)
        {
            if(head != null)
            {
                if (head.Data == data)
                {
                    head = head.Next;
                    return true;
                }
                else
                {
                    Node current = head;
                    while (current.Next != null)
                    {
                        if (current.Next.Data == data)
                        {
                            current.Next = current.Next.Next;
                            return true;
                        }
                        current = current.Next;
                    }
                }
            }
           return false;
        }
        public string PrintList()
        {
            Node node = head;
            string list = "Head -> ";

            while (node != null)
            {
                list += node.Data.ToString() + " -> ";
                node = node.Next;
            }
            list += "Null";
            return list;
        }

    }
}
