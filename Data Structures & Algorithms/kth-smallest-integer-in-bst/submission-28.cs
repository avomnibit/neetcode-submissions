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
        int[] result = new int[1];
        dfs(root, ref k, result);
        return result[0];
    }

    private void dfs(TreeNode root, ref int k, int[] result){
        if(root==null) {return;}
        dfs(root.left,ref k, result); 
        k--;
        if (k==0)  { result[0] = root.val; return;}
        dfs(root.right,ref k, result);
    }
}
