using System.Collections.Generic;

namespace TreeImplementation
{
    public class BinaryTree
    {
        protected Node root;
        public BinaryTree(int value)
        {
            root = new Node(value);
        }

        private void _PreOrderHelper(Node node, List<int> result)
        {
            if (node == null) return;
            result.Add(node.Data);  // Root
            _PreOrderHelper(node.Left, result);
            _PreOrderHelper(node.Right, result);
        }
        public List<int> PreOrder()
        {
            var result = new List<int>();
            _PreOrderHelper(root, result);
            return result;
        }

        private void _InOrderHelper(Node node, List<int> result)
        {
            if (node == null) return;
            _InOrderHelper(node.Left, result);
            result.Add(node.Data);  // Root
            _InOrderHelper(node.Right, result);
        }
        public List<int> InOrder()
        {
            var result = new List<int>();
            _InOrderHelper(root, result);
            return result;
        }

        private void _PostOrderHelper(Node node, List<int> result)
        {
            if (node == null) return;
            _PostOrderHelper(node.Left, result);
            _PostOrderHelper(node.Right, result);
            result.Add(node.Data);  // Root
        }
        public List<int> PostOrder()
        {
            var result = new List<int>();
            _PostOrderHelper(root, result);
            return result;
        }
    }
}
