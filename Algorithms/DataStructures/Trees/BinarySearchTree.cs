using EdKo_Algorithms.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace EdKo_Algorithms.Trees
{
    public class BinarySearchTree<T> where T : IComparable<T>
    {
        private BinarySearchTreeNode<T> _root { get; set; }
        private Func<T,T,int> _compare { get; set; }
        public BinarySearchTree()
        {

        }

        public BinarySearchTree(BinarySearchTreeNode<T> root, IComparer<T> comparer)
        {
            _root = root;
        }

        public void Add(T item)
        {

        } 

        private BinarySearchTreeNode<T> FindNode(T item, BinarySearchTreeNode<T> current, EqualType type)
        {
            var resultOfCompare = item.CompareTo(current.Data);



        }
    }
}
