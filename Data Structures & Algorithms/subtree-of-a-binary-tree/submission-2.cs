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
        if((root == null && subRoot == null) || (root != null && subRoot == null)) return true;
        if(root == null && subRoot != null) return false;
        Queue<TreeNode> q = new Queue<TreeNode>();
        TreeNode t;
        q.Enqueue(root);
        int level = 0, size =0, i=0;
        while(q.Count>0){
            size = q.Count;
            level++;
            for(i=0;i<size;i++){
                t=q.Dequeue();
                if(valid(t,subRoot)) return true;
                else{
                    if(t.left!=null) q.Enqueue(t.left);
                    if(t.right!=null) q.Enqueue(t.right);
                }
            }
        }
        return false;
    }

    private bool valid(TreeNode t, TreeNode st){
        if(t.val!=st.val) return false;
        bool v= true;
        if(t.right!=null && st.right!=null) v &= valid(t.right,st.right);
        if((t.right!=null && st.right==null) || (t.right==null && st.right!=null)) return false; 
        if(t.left!=null && st.left!=null) v &= valid(t.left,st.left);
        if((t.left!=null && st.left==null) || (t.left==null && st.left!=null)) return false;
        return v;
    }
}
