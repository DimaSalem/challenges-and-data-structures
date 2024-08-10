namespace StackAndQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
             //Console.WriteLine("Stack Example");
             //Stack stack = new Stack();

             //// Push nodes onto the stack
             //stack.Push(10); // Stack: Top -> 10
             //Console.WriteLine("push 10");
             //stack.Push(5);  // Stack: Top -> 5 -> 10
             //Console.WriteLine("push 5");

             //Console.WriteLine(stack.PrintStack());
             //// Pop a node from the stack
             //int popped = stack.Pop(); // popped: 5
             //Console.WriteLine("popped= " + popped);

             //// Peek the top node
             //int peeked = stack.Peek(); // peeked: 10
             //Console.WriteLine("peeked= " + peeked);

             //// Check if the stack is empty
             //bool isEmpty = stack.IsEmpty(); // isEmpty: false        
             //Console.WriteLine("isEmpty= " + isEmpty);



             //Console.WriteLine("\n\nQueue Example");
             //Queue queue = new Queue();

             //queue.Enqueue(10);
             //Console.WriteLine("enqueue 10");

             //queue.Enqueue(5);
             //Console.WriteLine("enqueue 5");

             //Console.WriteLine(queue.PrintQueue());

             //int dequeued = queue.Dequeue();
             //Console.WriteLine("dequeued= " + dequeued);

             //int peekedQueue = queue.Peek(); 
             //Console.WriteLine("peeked= " + peekedQueue);

             //bool isEmptyQueue = queue.IsEmpty(); // isEmpty: false        
             //Console.WriteLine("isEmpty= " + isEmptyQueue);


             //StackWithReverse stack = new StackWithReverse();
             //stack.Push(1);
             //stack.Push(2);
             //stack.Push(3);
             //stack.Push(4);
             //stack.Push(5);

             //Console.WriteLine("stack before reverse: " + stack.PrintStack());
             //stack.ReverseStack();
             //Console.WriteLine("stack after reverse: " + stack.PrintStack());
             //stack.Push(6);
             //stack.Push(7);
             //Console.WriteLine("stack before second reverse: " + stack.PrintStack());
             //stack.ReverseStack();
             //Console.WriteLine("stack after second reverse: " + stack.PrintStack());


             //StackWithDeleteMiddle stack = new StackWithDeleteMiddle();
             //stack.Push(7);
             //stack.Push(14);
             //stack.Push(3);
             //stack.Push(8);
             //stack.Push(5);

             //Console.WriteLine(stack.PrintStack()); // Stack: Top -> 5 -> 8 -> 3 -> 14 -> 7
             //stack.DeleteMiddle();
             //Console.WriteLine(stack.PrintStack()); // Stack: Top -> 5 -> 8 -> 14 -> 7

             //stack.Push(2);
             //stack.Push(9);
             //stack.Push(11);
             //Console.WriteLine(stack.PrintStack()); // Stack: Top -> 11 -> 9 -> 2 -> 5 -> 8 -> 14 -> 7
             //stack.DeleteMiddle();
             //Console.WriteLine(stack.PrintStack()); // Stack: Top -> 11 -> 9 -> 2 -> 8 -> 14 -> 7
            */

            MinStack minStack = new MinStack();

            // Push elements
            minStack.Push(15); // Top -> 15 (min: 15)
            minStack.Push(7);  // Top -> 7 -> 15 (min: 7) 
            minStack.Push(12); // Top -> 12 -> 7 -> 15 (min: 7)
            minStack.Push(3);  // Top -> 3 -> 12 -> 7 -> 15 (min: 3) 

            // Print the stack
            minStack.PrintStack(); // Output: Top -> 3 -> 12 -> 7 -> 15

            // Get the minimum element
            int min = minStack.GetMin(); // min: 3
            Console.WriteLine("min= " + min);

            // Pop a node from the stack
            int popped = minStack.Pop(); // popped: 3
            minStack.PrintStack(); // Output: Top -> 12 -> 7 -> 15

            // Get the new minimum element
            min = minStack.GetMin(); // min: 7
            Console.WriteLine("min= " + min);
            // Peek the top node
            int peeked = minStack.Peek(); // peeked: 12

            // Push another element
            minStack.Push(2);  // Top -> 2 -> 12 -> 7 -> 15 (min: 2)
            minStack.PrintStack(); // Output: Top -> 2 -> 12 -> 7 -> 15

            // Get the new minimum element
            min = minStack.GetMin(); // min: 2
            Console.WriteLine("min= " + min);

            // Check if the stack is empty
            bool isEmpty = minStack.IsEmpty(); // isEmpty: false

        }
    }
}