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
    public int DiameterOfBinaryTree(TreeNode root) {
      var res=0;
      d(root,0, ref res);
      return res;  
    }

    private int d(TreeNode root, int h, ref int res){
        if(root==null) return 0;
        int l=d(root.left,h+1, ref res),r=d(root.right,h+1, ref res);
        res = Math.Max(Math.Max(l+r,res),h);
        return Math.Max(l,r)+1;
    }
}
