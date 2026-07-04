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
    public int MaxDepth(TreeNode root) {
        if(root==null) return 0;
        int level=0, size=1,i=0;
        TreeNode aux;
        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(root);
        while(q.Count>0){
            level++;
            size = q.Count;
            for(i=0;i<size;i++){
                aux = q.Dequeue();
                if(aux.left!=null) q.Enqueue(aux.left);
                if(aux.right!=null) q.Enqueue(aux.right);
            }
        }
        return level;
    }
}
