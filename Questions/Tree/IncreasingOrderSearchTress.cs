using Algorithms.Contracts;
using Tree.Models;

namespace Tree
{
    /// <summary>
    /// Reference Link: https://leetcode.com/problems/increasing-order-search-tree/
    /// </summary>
    public class IncreasingOrderSearchTress : Question
    {
        TreeNode result;
        TreeNode prevNode;

        public TreeNode IncreasingBST(TreeNode root)
        {
            InorderTraversal(root);
            return result;
        }

        private void InorderTraversal(TreeNode node)
        {
            if (node == null)
                return;

            InorderTraversal(node.left);

            if (result == null)
            {
                result = new TreeNode(node.val);
                prevNode = result;
            }
            else
            {
                prevNode.right = new TreeNode(node.val);
                prevNode = prevNode.right;
            }

            InorderTraversal(node.right);
        }

        public override void Run()
        {

        }
    }
}
