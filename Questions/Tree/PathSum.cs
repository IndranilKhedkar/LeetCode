using Algorithms.Contracts;
using Algorithms.Helpers.Attibutes;
using Algorithms.Helpers.Enums;
using Tree.Models;

namespace Tree
{
    /// <summary>
    /// Reference Link: https://leetcode.com/problems/path-sum/
    /// </summary>
    [RelatedTopic(Topic.Tree)]
    [RelatedTopic(Topic.DFS)]
    public class PathSum : Question
    {
        public bool HasPathSum(TreeNode root, int sum)
        {
            return HasPathSumDFS(root, 0, sum);
        }

        public override void Run()
        {
            throw new System.NotImplementedException();
        }

        private bool HasPathSumDFS(TreeNode node, int sum, int target)
        {
            if (node == null)
                return false;

            sum = sum + node.val;
            if (node.left == null && node.right == null && target == sum)
                return true;

            return HasPathSumDFS(node.left, sum, target) || HasPathSumDFS(node.right, sum, target);
        }

    }
}
