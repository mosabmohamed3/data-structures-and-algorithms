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
// public class Solution {
//     public int GoodNodes(TreeNode root) {
//         if(root == null) return 0;

//         int count = 0;
//         var path = new List<int>();
//         path.Add(root.val);

//         dfs(root, ref count, path);

//         return count;
//     }

//     public void dfs(TreeNode node, ref int count, List<int> path)
//     {
//         if(node == null) return;

//         if(path.Max() <= node.val)
//             count++;

//         // new list from the old then add the value to it
//         var newPathLeft = new List<int>(path);
//         newPathLeft.Add(node.val);

//         var newPathRight = new List<int>(path);
//         newPathRight.Add(node.val);


//         dfs(node.left, ref count, newPathLeft);
//         dfs(node.right, ref count, newPathRight);
//     }
// }

public class Solution {
    public int GoodNodes(TreeNode root) {
        return Dfs(root, root.val);
    }

    private int Dfs(TreeNode node, int maxSoFar) {
        if (node == null) return 0;

        int count = 0;

        if (node.val >= maxSoFar)
            count++;

        maxSoFar = Math.Max(maxSoFar, node.val);

        count += Dfs(node.left, maxSoFar);
        count += Dfs(node.right, maxSoFar);
        return count;
    }
}
