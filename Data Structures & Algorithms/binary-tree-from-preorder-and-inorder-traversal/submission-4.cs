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
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        if(preorder.Length==0) return null;
        var i = Array.IndexOf(inorder, preorder[0]);
        return  new TreeNode(preorder[0],BuildTree(preorder[1..(i+1)],inorder[..i]), BuildTree(preorder[(i+1)..],inorder[(i+1)..]));
    }
}
