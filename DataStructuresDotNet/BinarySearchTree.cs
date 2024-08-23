namespace DataStructuresDotNet
{
    internal class BinarySearchTree<T> : BinaryTree<T> where T : IComparable
    {
        public bool Contains(T data)
        {
            BinaryTreeNode<T> node = Root;
            while (node != null)
            {
                int result = data.CompareTo(node.Data);
                if (result == 0)
                    return true;
                else if (result < 0)
                    node = node.Left;
                else node = node.Right;
            }
            return false;
        }

        public void Add(T data)
        {
            BinaryTreeNode<T> parent = GetParentForNewNode(data);
            BinaryTreeNode<T> node = new BinaryTreeNode<T> { Data = data, Parent = parent };
            if(parent != null)
            {
                Root = node;
            }
            else if(data.CompareTo(Root.Data) < 0)
            {
                parent.Left = node;
            }
            else
            {
                parent.Right = node;
            }
            Count++;
        }

        public void Remove (T data)
        {
            Remove(Root, data);
        }

        private void Remove(BinaryTreeNode<T> node, T data)
        {
            if(data.CompareTo(node.Data) < 0)
            {
                Remove(node.Left, data);
            }
            else if(data.CompareTo(node.Data) > 0)
            {
                Remove(node.Right, data);
            }
            else
            {
                if(node.Left == null && node.Right == null) 
                {
                    ReplaceInParent(node, null);
                    Count--;
                }
                else if (node.Right == null)
                {
                    ReplaceInParent(node, node.Left);
                    Count--;
                }
                else if (node.Left == null)
                {
                    ReplaceInParent(node, node.Right);
                    Count--;
                }
                else
                {
                    BinaryTreeNode<T> successor = FindMinimumInSubtree(node.Right);
                    node.Data = successor.Data;
                    Remove(successor, successor.Data);
                }
            }
        }

        private BinaryTreeNode<T> FindMinimumInSubtree(BinaryTreeNode<T> right)
        {
            throw new NotImplementedException();
        }

        private void ReplaceInParent(BinaryTreeNode<T> node, object value)
        {
            throw new NotImplementedException();
        }

        private BinaryTreeNode<T> GetParentForNewNode(T data)
        {
            BinaryTreeNode<T> current = Root;
            BinaryTreeNode<T> parent = null;

            while (current != null)
            {
                parent = current;
                int result = data.CompareTo(current.Data);
                if(result == 0)
                {
                    throw new ArgumentException($"The node {data} already exists");
                }
                else if(result < 0)
                {
                    current = current.Left;
                }
                else
                {
                    current = current.Right;
                }
            }

            return parent;
        }
    }
}
