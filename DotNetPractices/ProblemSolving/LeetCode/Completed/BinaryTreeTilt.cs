using System;

namespace Programming.LeetCode.AugustPractics
{
    public class BinaryTreeTilt
    {
        int tilt = 0;
        public int FindTilt(TreeNode root)
        {

            PostOrderTraverse(root);
            return tilt;
        }

        private int PostOrderTraverse(TreeNode node)
        {
            if (node == null) return 0;

            var left = PostOrderTraverse(node.left);
            var right = PostOrderTraverse(node.right);

            tilt += Math.Abs(left - right);
            return left + right + node.val;
        }
    }
}
