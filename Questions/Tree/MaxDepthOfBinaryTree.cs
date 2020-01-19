using Algorithms.Contracts;
using System.Collections.Generic;
using Tree.Models;

namespace Tree
{
    /// <summary>
    /// Reference Link: https://leetcode.com/problems/maximum-depth-of-binary-tree/
    /// Given a binary tree, find its maximum depth.
    /// The maximum depth is the number of nodes along the longest path from the root node down to the farthest leaf node.
    /// Note: A leaf is a node with no children.
    /// Example:
    ///     Given binary tree[3, 9, 20, null, null, 15, 7],   
    ///                3
    ///               / \
    ///              9  20
    ///                /  \
    ///               15   7
    ///     Output: Return its depth = 3.
    /// </summary>
    public class MaxDepthOfBinaryTree : Question
    {
        int maxDepth = 0;

        public int MaxDepth(TreeNode root)
        {
            return GetMaxDepth(root, 1);
        }

        private int GetMaxDepth(TreeNode node, int currentNodeDepth)
        {
            if (node == null)
            {
                return 0;
            }

            if (currentNodeDepth > maxDepth)
            {
                maxDepth = currentNodeDepth;
            }

            GetMaxDepth(node.left, currentNodeDepth + 1);
            GetMaxDepth(node.right, currentNodeDepth + 1);

            return maxDepth;
        }

        public override void Run()
        {

        }
    }
}
