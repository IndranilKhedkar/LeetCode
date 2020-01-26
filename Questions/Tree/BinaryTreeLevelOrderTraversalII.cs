using Algorithms.Contracts;
using System.Collections.Generic;
using Tree.Models;

namespace Tree
{
    /// <summary>
    /// Reference Link: https://leetcode.com/problems/binary-tree-level-order-traversal-ii/
    /// Given a binary tree, return the bottom-up level order traversal of its nodes' values. (ie, from left to right, level by level from leaf to root).
    /// For example:
    /// Given binary tree[3, 9, 20, null, null, 15, 7],
    ///       3
    ///      / \
    ///     9  20
    ///       /  \
    ///      15   7
    /// Return its bottom-up level order traversal as:
    ///   [
    ///     [15,7],
    ///     [9,20],
    ///     [3]
    ///   ]
    /// </summary>
    public class BinaryTreeLevelOrderTraversalII : Question
    {
        public IList<IList<int>> LevelOrderBottom(TreeNode root)
        {
            IList<IList<int>> result = new List<IList<int>>();

            if (root == null)
                return result;

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                List<int> levelNodes = new List<int>();
                int levelNodeCount = queue.Count;

                while (levelNodeCount-- > 0)
                {
                    TreeNode node = queue.Dequeue();
                    levelNodes.Add(node.val);

                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                    }
                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                    }
                }

                result.Insert(0, levelNodes);
            }

            return result;
        }

        public override void Run()
        {
            // Example 1
            TreeNode root = new TreeNode(3)
            {
                left = new TreeNode(9),
                right = new TreeNode(20) { left = new TreeNode(15), right = new TreeNode(7) }
            };

            var result = LevelOrderBottom(root);
        }
    }
}
