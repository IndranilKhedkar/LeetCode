using Algorithms.Contracts;
using System;
using System.Collections.Generic;
using Tree.Models;

namespace Tree
{
    /// <summary>
    /// Reference Link: https://leetcode.com/problems/minimum-depth-of-binary-tree/
    /// Given a binary tree, find its minimum depth.
    /// The minimum depth is the number of nodes along the shortest path from the root node down to the nearest leaf node.
    /// Note: A leaf is a node with no children.
    /// Example:
    /// Given binary tree[3, 9, 20, null, null, 15, 7],
    ///        3
    ///       / \
    ///      9  20
    ///        /  \
    ///       15   7
    /// Return its minimum depth = 2.
    /// </summary>
    public class MinimumDepthofBinaryTree : Question
    {
        // Using BFS
        public int MinDepthBFS(TreeNode root)
        {
            if (root == null)
                return 0;

            int result = 1;
            Queue<TreeNode> treeNodesQueue = new Queue<TreeNode>();
            treeNodesQueue.Enqueue(root);

            while (treeNodesQueue.Count > 0)
            {
                int levelNodeCount = treeNodesQueue.Count;

                while (levelNodeCount-- > 0)
                {
                    TreeNode node = treeNodesQueue.Dequeue();

                    if (node.left == null && node.right == null)
                        return result;

                    if (node.left != null)
                        treeNodesQueue.Enqueue(node.left);

                    if (node.right != null)
                        treeNodesQueue.Enqueue(node.right);
                }

                result++;
            }

            return result;
        }

        public override void Run()
        {

        }
    }
}
