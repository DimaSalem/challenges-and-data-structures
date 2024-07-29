namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            clsLinkedList linkedlist1= new clsLinkedList();
            clsLinkedList linkedlist2 = new clsLinkedList();

            linkedlist1.Add(10);
            linkedlist1.Add(20);
            linkedlist1.Add(30);
            linkedlist2.Add(5);
            linkedlist2.Add(15);
            linkedlist2.Add(25);
            linkedlist2.Add(35);

            Console.WriteLine("LinkedList1: "+ linkedlist1.PrintList());
            Console.WriteLine("LinkedList2: "+ linkedlist2.PrintList());

            Console.WriteLine("After merge: "+ clsLinkedList.MergeSortedLists(linkedlist1, linkedlist2).PrintList());
            

            //if (linkedlist1.Includes(10))
            //    Console.WriteLine("value is found.");
            //else
            //    Console.WriteLine("value is not found");

            //if (linkedlist1.Remove(5))
            //    Console.WriteLine("Value Removed Successfuly");
            //else
            //    Console.WriteLine("Remove Faild");

            //linkedlist1.RemoveDuplicate();
            //Console.WriteLine("After remove duplicate values");
            //Console.WriteLine(linkedlist1.PrintList());

        }
    }
}
