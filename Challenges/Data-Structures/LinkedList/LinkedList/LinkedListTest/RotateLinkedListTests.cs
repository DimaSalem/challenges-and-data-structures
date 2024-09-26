using LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListTest
{
    public class RotateLinkedListTests
    {
        [Fact]
        public void TestRotatingByKZero()
        {
            clsLinkedList linkedlist = new clsLinkedList();

            linkedlist.Add(1);
            linkedlist.Add(2);
            linkedlist.Add(3);
            linkedlist.Add(4);
            linkedlist.Add(5);
            linkedlist.Add(6);

            linkedlist.RotateLinkedList(0);
            string expectedOutput = "Head -> 1 -> 2 -> 3 -> 4 -> 5 -> 6 -> Null";
            string actualOutput = linkedlist.PrintList();

            Assert.Equal(expectedOutput, actualOutput);
        }

        [Fact]  
        public void TestRotatingByKLargerThanLength()
        {
            clsLinkedList linkedlist = new clsLinkedList();

            linkedlist.Add(1);
            linkedlist.Add(2);
            linkedlist.Add(3);
            linkedlist.Add(4);
            linkedlist.Add(5);
            linkedlist.Add(6);

            linkedlist.RotateLinkedList(7);
            string expectedOutput = "Head -> 2 -> 3 -> 4 -> 5 -> 6 -> 1 -> Null";
            string actualOutput = linkedlist.PrintList();

            Assert.Equal(expectedOutput, actualOutput);
        }
    }
}
