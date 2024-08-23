namespace DataStructuresDotNet
{
    internal class BinaryTree<T>
    {
        //Node cannot contain more than two children
        //Contains zero, one, or, two child nodes
        //three types of traversal orders - pre-order, in-order, post-order
        public BinaryTreeNode<T> Root { get; set; }
        public int Count { get; set; }

        public List<BinaryTreeNode<T>> Traverse(TraversalEnum mode)
        {
            List<BinaryTreeNode<T>> nodes = new List<BinaryTreeNode<T>>();
            switch(mode)
            {
                case TraversalEnum.PREORDER:
                    TraverseInOrder(Root, nodes);
                    break;
                case TraversalEnum.INORDER:
                    TraverseInOrder(Root, nodes);
                    break;
                case TraversalEnum.POSTORDER:
                    TraversePostOrder(Root, nodes);
                    break;

            }
            return nodes;
        }

        public int GetHeight()
        {
            int height = 0;
            foreach (BinaryTreeNode<T> node in Traverse(TraversalEnum.PREORDER))
            {
                height = Math.Max(height, node.GetHeight());
            }
            return height;
        }

        private void TraversePreOrder(BinaryTreeNode<T> node, List<BinaryTreeNode<T>> result)
        {
            if(node != null)
            {
                result.Add(node);
                TraversePreOrder(node.Left, result);
                TraversePreOrder(node.Right, result);
            }
        }
        private void TraverseInOrder(BinaryTreeNode<T> node, List<BinaryTreeNode<T>> result)
        {
            if (node != null)
            {
                TraverseInOrder(node.Left, result);
                result.Add(node);
                TraverseInOrder(node.Right, result);
            }
        }

        private void TraversePostOrder(BinaryTreeNode<T> node, List<BinaryTreeNode<T>> result)
        {
            if (node != null)
            {
                TraversePostOrder(node.Left, result);
                TraversePostOrder(node.Right, result);
                result.Add(node);
            }
        }
    }

    public enum TraversalEnum
    {
        PREORDER,
        INORDER,
        POSTORDER
    }
}
