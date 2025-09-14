namespace Programming.LeetCode.AugustPractics
{

    public class UnivaluedBinaryTree
    {
        int val;
        bool isUnival = true;
        public bool IsUnivalTree(TreeNode root)
        {
            val = root.val;
            Traverse(root);
            return isUnival;
        }

        private void Traverse(TreeNode treeNode)
        {
            if (treeNode == null || !isUnival) return;

            isUnival = treeNode.val == val;
            if (!isUnival) return;

            Traverse(treeNode.left);
            if (!isUnival) return;

            Traverse(treeNode.right);
        }
    }
}
