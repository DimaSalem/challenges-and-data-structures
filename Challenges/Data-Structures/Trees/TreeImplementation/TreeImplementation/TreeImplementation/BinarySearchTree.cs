﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeImplementation
{
    public class BinarySearchTree:BinaryTree
    {
        public BinarySearchTree(int value)
        {
            Root= new Node(value);
        }
        private void _AddHelper(Node node, int value)
        {
            if(value<node.Data)
            {
                if(node.Left==null)
                    node.Left=new Node(value);
                else
                    _AddHelper(node.Left, value);
            }
            else
            {
                if(node.Right==null)
                    node.Right=new Node(value);
                else
                    _AddHelper(node.Right, value);
            }
        }
        public void Add(int value)
        {
            _AddHelper(Root, value);
        }

        private bool _ContainsHelper(Node node, int value)
        {
            if (node == null) return false;
            if (value == node.Data) return true;

            if (value < node.Data)
                return _ContainsHelper(node.Left, value);
            else
                return _ContainsHelper(node.Right, value);
        }
        public bool Contains(int value)
        { 
           return _ContainsHelper(Root, value);
        }
        private int _GetMax(Node node)
        {
            if(node.Right==null)
                return node.Data;
            else
                return _GetMax(node.Right);
        }
         private Node _RemoveHelper(Node node, int value)
         {
            if (node == null) return node;
            else if (value < node.Data)
                node.Left = _RemoveHelper(node.Left, value);
            else if (value > node.Data)
                node.Right = _RemoveHelper(node.Right, value);

            else
            {
                if (node.Left == null)
                    return node.Right;
                else if (node.Right == null)
                    return node.Left;

                else
                {
                    node.Data = _GetMax(node.Left);
                    node.Left = _RemoveHelper(node.Left, node.Data);

                }
            }
            return node;
             
         }
        public void Remove(int value)
        {
            Root= _RemoveHelper(Root, value);
        }
    }
}
