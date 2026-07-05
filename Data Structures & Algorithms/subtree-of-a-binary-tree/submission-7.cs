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
    public bool IsSubtree(TreeNode root, TreeNode subRoot) {
        if(subRoot ==null) return true;
        if(root == null) return false;
        if(same(root, subRoot)) return true;
        return IsSubtree(root.left,subRoot) || IsSubtree(root.right,subRoot);
    }

    private bool same(TreeNode r, TreeNode sr){
        if(sr == null && r == null) return true;
        if(sr != null && r != null && sr.val==r.val) return same(r.left,sr.left) && same(r.right, sr.right);
        return false;
    }
}
