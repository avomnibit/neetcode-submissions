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
        if(root==null) return true;
        return validBST(root.val,int.MinValue,root.left) && validBST(int.MaxValue,root.val,root.right);
    }

    private bool validBST(int max, int min, TreeNode node){
        if(node==null) return true;
        if(node.val > min && node.val < max) return validBST(node.val,min,node.left) && validBST(max,node.val,node.right);
        return false;
    }
}
