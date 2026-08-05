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
    public int KthSmallest(TreeNode root, int k) {
        List<int> arr = new List<int>();
        dfs(root,arr);
        arr.Sort();
        return arr[k-1];
    }

    private void dfs(TreeNode root, List<int> arr){
        if(root==null) return; 
        arr.Add(root.val);
        dfs(root.left,arr);
        dfs(root.right,arr);
    }
}
