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
    public List<int> vals = new List<int>();

    public int KthSmallest(TreeNode root, int k) {
        Dfs(root);
        vals.Sort();
        return vals[k-1];
    }

    public void Dfs(TreeNode node)
    {
        if (node is null) return;

        vals.Add(node.val);

        Dfs(node.left);
        Dfs(node.right);
    }
}