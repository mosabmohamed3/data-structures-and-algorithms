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
    public bool IsValidBST(TreeNode root) {
        return IsValid(root, long.MaxValue, long.MinValue);
        // if (root is null) return true;

        // IsValidBST(root.left);
        // IsValidBST(root.right);

        // if (root.left is not null && root.val <= root.left.val) return false;
        // if (root.right is not null && root.val >= root.right.val) return false;
        
        // return true;
    }

    public bool IsValid(TreeNode node, long max, long min)
    {
        if (node is null) return true;

        if (node.val >= max || node.val <= min) return false;

        return 
            IsValid(node.left, node.val, min) &&
            IsValid(node.right, max, node.val);
    }
}