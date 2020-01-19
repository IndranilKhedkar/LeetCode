using Algorithms.Contracts;
using Tree.Models;

namespace Tree
{
    /// <summary>
    /// Reference Link: https://leetcode.com/problems/symmetric-tree/
    /// Given a binary tree, check whether it is a mirror of itself (ie, symmetric around its center).
    /// For example, this binary tree [1,2,2,3,4,4,3] is symmetric:
    ///            1
    ///           / \
    ///          2   2
    ///         / \ / \
    ///        3  4 4  3
    /// But the following[1, 2, 2, null, 3, null, 3] is not:
    ///            1
    ///           / \
    ///          2   2
    ///           \   \
    ///           3    3
    /// </summary>
    public class SymmetricTree : Question
    {
        public bool IsSymmetric(TreeNode root)
        {
            if (root == null)
                return true;

            return IsSymmetricTree(root.left, root.right);
        }

        private bool IsSymmetricTree(TreeNode node1, TreeNode node2)
        {
            if (node1 == null && node2 == null)
            {
                return true;
            }
            if (node1 == null || node2 == null)
            {
                return false;
            }
            else
            {
                return node1.val == node2.val
                    && IsSymmetricTree(node1.left, node2.right)
                    && IsSymmetricTree(node1.right, node2.left);
            }
        }

        public override void Run()
        {
            throw new System.NotImplementedException();
        }

    }
}
