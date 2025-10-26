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
        if (root == null) return true;

        bool res = true;
        DFS(root, ref res);
        return res;
    }

    public int DFS(TreeNode root, ref bool res)
    {
        if (root == null) return 0;
        int leftLevel = DFS(root.left, ref res);
        int rightLevel = DFS(root.right, ref res);

        if(Math.Abs(leftLevel - rightLevel) > 1)
            res = false;

        return 1 + Math.Max(leftLevel, rightLevel);
    }
}