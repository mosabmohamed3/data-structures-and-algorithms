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
    public IList<IList<int>> LevelOrder(TreeNode root) {
        Dictionary<int, List<int>> dic = new Dictionary<int, List<int>>();
        DFS(root, dic, 1);
return dic.Values.Select(v => (IList<int>)v).ToList();
    }

    private int DFS(TreeNode root, Dictionary<int, List<int>> dic, int level)
    {
        if (root == null) return -1;

        if (!dic.ContainsKey(level))
            dic[level] = new List<int>();
        dic[level].Add(root.val);

        level++;
        DFS(root.left, dic, level);
        DFS(root.right, dic, level);

        return -1;
    }
}