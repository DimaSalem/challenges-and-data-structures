namespace StackAndQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stack Example");
            Stack stack = new Stack();

            // Push nodes onto the stack
            stack.Push(10); // Stack: Top -> 10
            Console.WriteLine("push 10");
            stack.Push(5);  // Stack: Top -> 5 -> 10
            Console.WriteLine("push 5");

            Console.WriteLine(stack.PrintStack());
            // Pop a node from the stack
            int popped = stack.Pop(); // popped: 5
            Console.WriteLine("popped= " + popped);

            // Peek the top node
            int peeked = stack.Peek(); // peeked: 10
            Console.WriteLine("peeked= " + peeked);

            // Check if the stack is empty
            bool isEmpty = stack.IsEmpty(); // isEmpty: false        
            Console.WriteLine("isEmpty= " + isEmpty);



            Console.WriteLine("\n\nQueue Example");
            Queue queue = new Queue();

            queue.Enqueue(10);
            Console.WriteLine("enqueue 10");

            queue.Enqueue(5);
            Console.WriteLine("enqueue 5");

            Console.WriteLine(queue.PrintQueue());

            int dequeued = queue.Dequeue();
            Console.WriteLine("dequeued= " + dequeued);

            int peekedQueue = queue.Peek(); 
            Console.WriteLine("peeked= " + peekedQueue);

            bool isEmptyQueue = queue.IsEmpty(); // isEmpty: false        
            Console.WriteLine("isEmpty= " + isEmptyQueue);

        }
    }
}