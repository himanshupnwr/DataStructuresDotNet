using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresDotNet
{
    internal class BinaryTreeNode<T> : TreeNode<T>
    {
        public BinaryTreeNode() => Children = new List<TreeNode<T>>() { null, null };
        public BinaryTreeNode<T> Left {
            get { return (BinaryTreeNode<T>)Children[0]; }
            set { Children[0] = value; }
        }
        public BinaryTreeNode<T> Right
        {
            get { return (BinaryTreeNode<T>)Children[1]; }
            set { Children[1] = value; }
        }

        public int GetHeight()
        {
            int height = 1;
            BinaryTreeNode<T> current = this;
            while (current.Parent != null) { 
                height++;
                current = (BinaryTreeNode<T>)current.Parent;
            }
            return height;
        }
    }
}
