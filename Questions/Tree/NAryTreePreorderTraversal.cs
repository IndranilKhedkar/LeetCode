using Algorithms.Contracts;
using System.Collections.Generic;

namespace Tree
{
    /// <summary>
    /// Reference Link: https://leetcode.com/problems/n-ary-tree-preorder-traversal/
    /// Given an n-ary tree, return the preorder traversal of its nodes' values.
    /// Nary-Tree input serialization is represented in their level order traversal, each group of children is separated by the null value(See examples).
    /// Follow up:
    ///     Recursive solution is trivial, could you do it iteratively?
    /// </summary>
    public class Node
    {
        public int val;
        public IList<Node> children;

        public Node() { }

        public Node(int _val)
        {
            val = _val;
        }

        public Node(int _val, IList<Node> _children)
        {
            val = _val;
            children = _children;
        }
    }

    public class NAryTreePreorderTraversal : Question
    {
        readonly List<int> result = new List<int>();

        public IList<int> Preorder(Node root)
        {
            if (root == null)
            {
                return result;
            }

            result.Add(root.val);
            foreach (var node in root.children)
            {
                Preorder(node);
            }

            return result;
        }

        public IList<int> InterativePreorder(Node root)
        {
            if (root == null)
            {
                return result;
            }

            Stack<Node> nodeStack = new Stack<Node>();
            nodeStack.Push(root);

            while (nodeStack.Count != 0)
            {
                Node node = nodeStack.Pop();
                result.Add(node.val);
                int len = node.children.Count;

                for (int i = len - 1; i >= 0; i--)
                {
                    nodeStack.Push(node.children[i]);
                }
            }

            return result;
        }

        public override void Run()
        {

        }
    }
}
