using System.Collections.Generic;
using System.Collections.Specialized;

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
            int max = Root.Data, secondMax = 0;
            return _FindSecondMaxHelper(ref max, ref secondMax, Root);
        }
        private int _SumOfLeafNodesHelper(Node node)
        {
            if (node != null)
            {
                if (node.Right == null && node.Left == null)
                    return node.Data;

                return _SumOfLeafNodesHelper(node.Right) + _SumOfLeafNodesHelper(node.Left);                
            }
            return 0;                      
        }
        public int SumOfLeafNodes()
        {
            return _SumOfLeafNodesHelper(Root);
        }
        public int FindMaxValueInQueue(Queue<Node> queue)
        {
            if (queue == null || queue.Count == 0)
            {
                return 0;
            }

            int maxValue = int.MinValue;

            foreach (var node in queue)
            {
                if (node.Data > maxValue)
                {
                    maxValue = node.Data;
                }
            }

            return maxValue;
        }
        private void _LargesValueEachLevelHelper(Queue<Node> queue1, Queue<Node> queue2,
            List<int> result)
        {
            if (queue1.Count == 0) return;

            while (queue1.Count != 0)
            {
                Node current = queue1.Dequeue();
                if (current.Right != null) queue2.Enqueue(current.Right);
                if (current.Left != null) queue2.Enqueue(current.Left);            
            }

            if(queue2.Count == 0) return;
            result.Add(FindMaxValueInQueue(queue2));
            _LargesValueEachLevelHelper(queue2, queue1, result);
        }
        public List<int> LargestValueEachLevel()
        {
            Queue<Node> queue1 = new Queue<Node>();
            Queue<Node> queue2 = new Queue<Node>();
            List<int> result = new List<int>();
            if (Root != null)
            {
                result.Add(Root.Data);
                queue1.Enqueue(Root);
                _LargesValueEachLevelHelper(queue1, queue2, result);
            }
            return result;
        }

        private void _PrintRightViewHelper(List<int> rightView, Node node)
        {
            if (node == null) return;
            if(node.Right != null)
            {
                rightView.Add(node.Right.Data);
                _PrintRightViewHelper(rightView, node.Right);
            }
            _PrintRightViewHelper(rightView, node.Left);
        }
        public string PrintRightView()
        {
            List<int> rightView = new List<int>();
            if(Root != null)
            {
                rightView.Add(Root.Data);
                _PrintRightViewHelper(rightView, Root);
            }
            foreach (int node in rightView)
            {
                Console.Write(node + " ");
            }
            return rightView.ToString();
        }

        private void _FindMaxLevelNodes(Queue<Node> parentNodes, Queue<Node> childNodes, List<int> levelNodes)
        {
            levelNodes.Add(parentNodes.Count());
            while (parentNodes.Count > 0)
            {
                Node current = parentNodes.Dequeue();
                if (current.Right != null) childNodes.Enqueue(current.Right);
                if (current.Left != null) childNodes.Enqueue(current.Left);
            }
            if(childNodes.Count > 0) 
                _FindMaxLevelNodes(childNodes, parentNodes, levelNodes);

        }
        public int FindMaxLevelNodes()
        {
            Queue<Node> parentNodes = new Queue<Node>();
            Queue<Node> childNodes = new Queue<Node>();

            List<int> levelNodes= new List<int>();
            if(Root != null)
            {
                parentNodes.Enqueue(Root);
                _FindMaxLevelNodes(parentNodes, childNodes, levelNodes);
                return levelNodes.IndexOf(levelNodes.Max());
            }
            return -1; 
        }

        private void _FindMinimumDepthHelper(Node node, ref int depth, ref bool isFound)
        {
            if (node == null)
            {
                isFound = true;
                return;
            }
            depth++;
            if (!isFound) _FindMinimumDepthHelper(node.Right,ref depth, ref isFound);
            if (!isFound) _FindMinimumDepthHelper(node.Left,ref depth, ref isFound);
        }
        public int FindMinimumDepth()
        {
            int depth = 0;
            bool isFound = false;
            _FindMinimumDepthHelper(Root, ref depth, ref isFound);
            return depth;

        }
    }
}
