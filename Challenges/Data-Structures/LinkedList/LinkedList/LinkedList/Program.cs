namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            clsLinkedList linkedlist1= new clsLinkedList();

            linkedlist1.Add(1);
            linkedlist1.Add(2);
            linkedlist1.Add(3);
            linkedlist1.Add(2);
            linkedlist1.Add(4);
            linkedlist1.Add(3);

            Console.WriteLine(linkedlist1.PrintList());
            

            //if (linkedlist1.Includes(10))
            //    Console.WriteLine("value is found.");
            //else
            //    Console.WriteLine("value is not found");

            //if (linkedlist1.Remove(5))
            //    Console.WriteLine("Value Removed Successfuly");
            //else
            //    Console.WriteLine("Remove Faild");

            linkedlist1.RemoveDuplicate();
            Console.WriteLine("After remove duplicate values");
            Console.WriteLine(linkedlist1.PrintList());

        }
    }
}
