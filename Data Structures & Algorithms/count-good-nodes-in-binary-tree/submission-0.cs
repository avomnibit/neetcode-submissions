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
    public int GoodNodes(TreeNode root) {
        int res=0;
        ch(root,int.MinValue,ref res);
        return res;
    }

    private void ch(TreeNode root, int max, ref int res){
        if(root == null) return;
        if(max<=root.val) res++;
        ch(root.left, Math.Max(max,root.val), ref res);
        ch(root.right, Math.Max(max,root.val), ref res);
    }
}
