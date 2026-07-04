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
    public TreeNode InvertTree(TreeNode root) {
        if (root == null) return root;
        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(root);
        TreeNode c,aux;
        while(q.Count>0){
            c= q.Dequeue();
            aux = c.left;
            c.left=c.right;
            c.right = aux;
            if(c.right!=null) q.Enqueue(c.right);
            if(c.left!=null) q.Enqueue(c.left);
        }
        return root;
    }
}
