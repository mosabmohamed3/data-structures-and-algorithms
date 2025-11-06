// public class Solution {
//     public bool IsSubtree(TreeNode root, TreeNode subRoot) {
//         if (root == null)
//             return false;

//         // Use DFS to traverse the main tree
//         return DFS(root, subRoot);
//     }

//     public bool DFS (TreeNode root, TreeNode subRoot)
//     {
//         if (root == null) return false;

//         if(isIt(root, subRoot)) return true;

//         return DFS(root.left, subRoot) || DFS(root.right, subRoot);
//     }

//     public bool isIt(TreeNode root, TreeNode sub)
//     {
//         if (root.val == sub.val &&
        
//             root.left.val == sub.left.val &&
//             root.right.val == sub.right.val &&

//             root.left.left == sub.left.left &&
//             root.left.right == sub.left.right &&     
                
//             root.right.left == sub.right.left &&
//             root.right.right == sub.right.right
//         )
//             return true;
//         return false;
//     }
// }

public class Solution {
    public bool IsSubtree(TreeNode root, TreeNode subRoot) {
        if (root == null) return false;

        return 
            IsSameTree(root, subRoot) ||
            IsSubtree(root.left, subRoot) ||
            IsSubtree(root.right, subRoot);
    }

    public bool IsSameTree(TreeNode root, TreeNode subRoot)
    {
        if (root == null && subRoot == null) return true;
        if (root == null || subRoot == null) return false;
        if (root.val != subRoot.val) return false;

        return 
            IsSameTree(root.left, subRoot.left) &&
            IsSameTree(root.right, subRoot.right);
    }
}
