namespace TreeImplementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree bst = new BinarySearchTree(2);

            // Add nodes to the BST
            bst.Add(10);
            bst.Add(5);
            bst.Add(15);
            bst.Add(7);

            // Check if a node exists
            bool contains = bst.Contains(7); // contains: true
            Console.WriteLine(contains);
            // Remove a node
            bst.Remove(5);

            // Check if the node is removed
            contains = bst.Contains(5); // contains: false
            Console.WriteLine(contains);

        }
    }
}
