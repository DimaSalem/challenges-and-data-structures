using LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListTest
{
    public class MergeSortedLinkedLists
    {
        [Fact]
        public void MergeListWithEmptyOneTest()
        {
            clsLinkedList linkedlist1 = new clsLinkedList();
            clsLinkedList linkedlist2 = new clsLinkedList();
            clsLinkedList mergedList;

            linkedlist1.Add(1);
            linkedlist1.Add(2);
            linkedlist1.Add(3);

            mergedList = clsLinkedList.MergeSortedLists(linkedlist1, linkedlist2);
            string expectedOutput = "Head -> 1 -> 2 -> 3 -> Null";
            string actualOutput = mergedList.PrintList();

            Assert.Equal(expectedOutput, actualOutput);
        }

        [Fact]
        public void MergingTwoEmptyListsTest()
        {
            clsLinkedList linkedlist1 = new clsLinkedList();
            clsLinkedList linkedlist2 = new clsLinkedList();
            clsLinkedList mergedList;

            mergedList = clsLinkedList.MergeSortedLists(linkedlist1, linkedlist2);
            string expectedOutput = "Head -> Null";
            string actualOutput = mergedList.PrintList();

            Assert.Equal(expectedOutput, actualOutput);
        }

        [Fact]
        public void MergingTwoListsTest()
        {
            clsLinkedList linkedlist1 = new clsLinkedList();
            clsLinkedList linkedlist2 = new clsLinkedList();
            clsLinkedList mergedList;

            linkedlist1.Add(5);
            linkedlist1.Add(10);
            linkedlist1.Add(15);

            linkedlist2.Add(2);
            linkedlist2.Add(3);
            linkedlist2.Add(20);

            mergedList = clsLinkedList.MergeSortedLists(linkedlist1, linkedlist2);
            string expectedOutput = "Head -> 2 -> 3 -> 5 -> 10 -> 15 -> 20 -> Null";
            string actualOutput = mergedList.PrintList();

            Assert.Equal(expectedOutput, actualOutput);
        }
    }
}
