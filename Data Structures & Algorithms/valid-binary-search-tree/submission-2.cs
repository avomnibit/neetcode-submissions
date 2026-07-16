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
        return validBSTLeft(root.val,root.val,int.MinValue,root.left) && validBSTRight(root.val,int.MaxValue,root.val,root.right);
    }

    private bool validBSTRight(int val, int max, int min, TreeNode node){
        if(node==null) return true;
        if(node.val>val && node.val<max) return validBSTLeft(node.val,node.val,min,node.left) && validBSTRight(node.val,max,node.val,node.right);
        return false;
    }

    private bool validBSTLeft(int val, int max, int min, TreeNode node){
        if(node==null) return true;
        if(node.val < val && node.val > min) return validBSTLeft(node.val,node.val,min,node.left) && validBSTRight(node.val,max,node.val,node.right);
        return false;
    }
}
