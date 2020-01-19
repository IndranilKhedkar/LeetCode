using Algorithms.Contracts;
using Tree.Models;

namespace Tree
{
    /// <summary>
    /// Reference Link: https://leetcode.com/problems/univalued-binary-tree/
    /// A binary tree is univalued if every node in the tree has the same value.
    /// Return true if and only if the given tree is univalued.
    /// </summary>
    public class UnivaluedBinaryTree : Question
    {
        public bool IsUnivalTree(TreeNode root)
        {
            if (root == null)
                return false;

            return IsUnivaluedTree(root, root.val);
        }

        private bool IsUnivaluedTree(TreeNode node, int val)
        {
            if (node == null)
                return true;

            if (node.val != val)
                return false;

            return IsUnivaluedTree(node.left, node.val) && IsUnivaluedTree(node.right, node.val);
        }

        public override void Run()
        {

        }
    }
}
