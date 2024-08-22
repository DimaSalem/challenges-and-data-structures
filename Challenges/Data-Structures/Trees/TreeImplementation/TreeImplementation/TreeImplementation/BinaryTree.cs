using System.Collections.Generic;

namespace TreeImplementation
{
    public class BinaryTree
    {
        public Node Root {  get; set; }

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
            _PreOrderHelper(Root, result);
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
            _InOrderHelper(Root, result);
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
            _PostOrderHelper(Root, result);
            return result;
        }

        private void _MirrorHelper(Node node)
        {
            if(node == null) return;
            Node temp= node.Right;
            node.Right = node.Left;
            node.Left = temp;
            _MirrorHelper(node.Right);
            _MirrorHelper(node.Left);
        }
        public void Mirror()
        {
            _MirrorHelper(Root);
        }

        class MaxValues
        {
            public int Max { get; set; }
            public int SecondMax { get; set; }
        }
        private int _FindSecondMaxHelper(ref int max, ref int secondMax, Node node)
        {
            if (node != null)
            {

                if (node.Right != null)
                {
                    if (node.Right.Data > max)
                    {
                        secondMax = max;
                        max = node.Right.Data;
                    }
                }
                if (node.Left != null)
                {
                    if (node.Left.Data > max)
                    {
                        secondMax = max;
                        max = node.Left.Data;
                    }
                }
                _FindSecondMaxHelper(ref max, ref secondMax, node.Right); 
                _FindSecondMaxHelper(ref max, ref secondMax, node.Left);
            }
            return secondMax;

        }
        public int FindSecondMax()
        {
            MaxValues maxValues = new MaxValues();
            int max = Root.Data, secondMax = 0;
            return _FindSecondMaxHelper(ref max, ref secondMax, Root);
        }


    }
}
