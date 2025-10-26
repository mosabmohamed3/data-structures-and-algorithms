/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public bool IsBalanced(TreeNode root) {
        return DFS(root) != -1;
    }

    public int DFS(TreeNode root)
    {
        if (root == null) return 0;

        int leftLevel = DFS(root.left);
        if (leftLevel == -1) return -1;

        int rightLevel = DFS(root.right);
        if (rightLevel == -1) return -1;

        if(Math.Abs(leftLevel - rightLevel) > 1)
            return -1;

        return 1 + Math.Max(leftLevel, rightLevel);
    }
}