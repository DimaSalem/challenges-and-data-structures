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
        public int Count {set; get;}
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
            Count++;
        }
        public Node Top()
        {
            return head;
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
                Count--;
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
        public void RemoveDuplicate()
        {
            Node current= head;
            while(current != null)
            {
                Node index = current.Next;
                Node preIndex = current;
                while (index != null)
                {
                    if (index.Data == current.Data)
                        preIndex.Next = index.Next;
                    else
                        preIndex = index;

                    index = index.Next;
                }
                current= current.Next;
            }
        }
        static public clsLinkedList MergeSortedLists(clsLinkedList list1, clsLinkedList list2)
        {
            clsLinkedList mergedList = new clsLinkedList();
            Node current1 = list1.Top();
            Node current2 = list2.Top();

            while (current1 != null && current2 != null)
            {
                if (current1.Data <= current2.Data)
                {
                    mergedList.Add(current1.Data);
                    current1 = current1.Next;
                }
                else
                {
                    mergedList.Add(current2.Data);
                    current2 = current2.Next;
                }
            }

            while (current1 != null)
            {
                mergedList.Add(current1.Data);
                current1 = current1.Next;
            }

            while (current2 != null)
            {
                mergedList.Add(current2.Data);
                current2 = current2.Next;
            }

            return mergedList;
        }
        public void RotateLinkedList(int k)
        {
            //to improve the performance
            if (k == Count)
                k = 0;
            else if (k > Count)
                k = k - Count;

            for(int i=0; i<k; i++)
            {
                if(head!=null)
                {
                    Add(head.Data);
                    head = head.Next;
                }

            }
        }
    }
}

