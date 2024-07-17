using LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListTest
{
    public class RemoveDuplicatesTests
    {
        [Fact]
        public void NoDuplicateListTest()
        {
            clsLinkedList linkedlist1 = new clsLinkedList();

            linkedlist1.Add(1);
            linkedlist1.Add(2);
            linkedlist1.Add(3);
            linkedlist1.Add(4);

            linkedlist1.RemoveDuplicate();
            string expectedOutput = "Head -> 1 -> 2 -> 3 -> 4 -> Null";
            string actualOutput = linkedlist1.PrintList();

            Assert.Equal(expectedOutput, actualOutput);
        }

        [Fact]
        public void OnlyDuplicateRemovedTest()
        {
            clsLinkedList linkedlist1 = new clsLinkedList();

            linkedlist1.Add(1);
            linkedlist1.Add(2);
            linkedlist1.Add(3);
            linkedlist1.Add(2);
            linkedlist1.Add(4);
            linkedlist1.Add(3);

            linkedlist1.RemoveDuplicate();
            string expectedOutput = "Head -> 1 -> 2 -> 3 -> 4 -> Null";
            string actualOutput = linkedlist1.PrintList();

            Assert.Equal(expectedOutput, actualOutput);
        }

        [Fact]
        public void AllNodesDuplicateTest()
        {
            clsLinkedList linkedlist1 = new clsLinkedList();

            linkedlist1.Add(7);
            linkedlist1.Add(7);
            linkedlist1.Add(7);
            linkedlist1.Add(7);

            linkedlist1.RemoveDuplicate();
            string expectedOutput = "Head -> 7 -> Null";
            string actualOutput = linkedlist1.PrintList();

            Assert.Equal(expectedOutput, actualOutput);
        }
    }
}
