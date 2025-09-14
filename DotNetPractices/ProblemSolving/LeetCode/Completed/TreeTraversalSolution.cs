using Programming.LeetCode.AugustPractics;
using System.Collections.Generic;

namespace Programming.LeetCode.OctoberPractics
{
    public class TreeTraversalSolution
    {
        public IList<int> PreorderTraversal(TreeNode root)
        {
            if (root == null) return new List<int>();


            var nodeItems = new Stack<TreeNode>();
            nodeItems.Push(root);

            var nodeValues = new List<int>();
            while (nodeItems.Count > 0)
            {
                var node = nodeItems.Pop();
                nodeValues.Add(node.val);
                if (node.right != null) nodeItems.Push(node.right);
                if (node.left != null) nodeItems.Push(node.left);
            }
            return nodeValues;
        }

        public IList<int> InorderTraversal(TreeNode root)
        {
            if (root == null) return new List<int>();

            var nodeItems = new Stack<TreeNode>();
            nodeItems.Push(root);

            var nodeValues = new List<int>();
            while (nodeItems.Count > 0)
            {
                var node = nodeItems.Pop();
                if (node.right != null) nodeItems.Push(node.right);

                if (node.left == null) nodeValues.Add(node.val);
                else
                {
                    nodeItems.Push(new TreeNode(node.val));
                    nodeItems.Push(node.left);
                }
            }
            return nodeValues;
        }

        public IList<int> PostorderTraversal(TreeNode root)
        {
            if (root == null) return new List<int>();

            var nodeItems = new Stack<TreeNode>();
            nodeItems.Push(root);

            var nodeValues = new List<int>();
            while (nodeItems.Count > 0)
            {
                var node = nodeItems.Pop();
                if (node.left != null || node.right != null)
                {
                    nodeItems.Push(new TreeNode(node.val));
                    if (node.right != null) nodeItems.Push(node.right);
                    if (node.left != null) nodeItems.Push(node.left);
                }
                else nodeValues.Add(node.val);
            }
            return nodeValues;
        }

    }
}
