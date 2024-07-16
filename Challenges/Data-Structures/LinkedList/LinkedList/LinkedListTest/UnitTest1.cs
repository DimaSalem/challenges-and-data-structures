using LinkedList;

namespace LinkedListTest
{
    public class UnitTest1
    {
        [Fact]
        public void RemoveFromEndTest()
        {
            clsLinkedList linkedlist1 = new clsLinkedList();

            linkedlist1.Add(5);
            linkedlist1.Add(10);
            linkedlist1.Add(20);
            linkedlist1.Add(30);

            bool success= linkedlist1.Remove(30);
            Assert.True(success);
        }

        [Fact]
        public void PrintListTest()
        {
            clsLinkedList linkedlist1 = new clsLinkedList();

            linkedlist1.Add(5);
            linkedlist1.Add(10);
            linkedlist1.Add(20);
            linkedlist1.Add(30);

            var output= new StringWriter();
            Console.SetOut(output);

            string expectedOutput = "Head -> 5 -> 10 -> 20 -> 30 -> Null";
            string actualOutput = linkedlist1.PrintList();

            Assert.Equal(expectedOutput, actualOutput);
        }
    }
}