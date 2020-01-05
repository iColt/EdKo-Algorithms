namespace EdKo_Algorithms.Trees
{
    public class BinarySearchTreeNode<T>
    {
        public T Data { get; set; }
        private BinarySearchTreeNode<T> _left { get; set; }
        private BinarySearchTreeNode<T> _right { get; set; }

        public BinarySearchTreeNode(BinarySearchTreeNode<T> left, BinarySearchTreeNode<T> right)
        {
            _left = left;
            _right = right;
        }
    }
}
