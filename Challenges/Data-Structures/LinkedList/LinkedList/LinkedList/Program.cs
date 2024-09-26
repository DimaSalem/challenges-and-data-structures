namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            clsLinkedList linkedlist= new clsLinkedList();

            linkedlist.Add(1);
            linkedlist.Add(2);
            linkedlist.Add(3);
            linkedlist.Add(4);
            linkedlist.Add(5);
            linkedlist.Add(6);

            Console.WriteLine("LinkedList before: "+ linkedlist.PrintList());
            linkedlist.RotateLinkedList(2);
            Console.WriteLine("LinkedList after: " + linkedlist.PrintList());



            //if (linkedlist.Includes(10))
            //    Console.WriteLine("value is found.");
            //else
            //    Console.WriteLine("value is not found");

            //if (linkedlist.Remove(5))
            //    Console.WriteLine("Value Removed Successfuly");
            //else
            //    Console.WriteLine("Remove Faild");

            //linkedlist.RemoveDuplicate();
            //Console.WriteLine("After remove duplicate values");
            //Console.WriteLine(linkedlist.PrintList());

        }
    }
}
