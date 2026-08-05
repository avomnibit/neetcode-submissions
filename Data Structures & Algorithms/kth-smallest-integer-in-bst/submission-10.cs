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
        Stack<TreeNode> s = new Stack<TreeNode>();
        TreeNode c = root;
        int n=0;
        while(c!= null || s.Count>0){
            while (c != null) {
                s.Push(c); 
                c = c.left;
            }
            c = s.Pop();
            n++;
            if (n==k) return c.val;
            c = c.right;
        }
        return -1;
    }
}
