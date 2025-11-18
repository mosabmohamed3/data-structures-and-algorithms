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
    int count = 0;
    int answer = 0;

    public int KthSmallest(TreeNode root, int k) {
        Dfs(root, k);
        return answer;
        // vals.Sort();
        // return vals[k-1];
    }

    public void Dfs(TreeNode node, int k)
    {
        if (node is null) return;

        Dfs(node.left, k);
        
        count++;
        if(count == k)
        {
            answer = node.val;
            return;
        }

        Dfs(node.right, k);
    }
}