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
    public bool IsBalanced(TreeNode root) {
        if(root==null) return true;
        bool balanced = true;
        int l=getH(root.left, ref balanced),r=getH(root.right, ref balanced);
        if(l==r || l+1==r || r+1==l) return balanced && true;
        return false;
    }

    private int getH(TreeNode root, ref bool b){
        if(root==null) return 0;
        int l = getH(root.left, ref b),r=getH(root.right, ref b);
        if(l!=r && l+1!=r && r+1!=l) b=false;
        return Math.Max(l,r)+1;
    }
}
