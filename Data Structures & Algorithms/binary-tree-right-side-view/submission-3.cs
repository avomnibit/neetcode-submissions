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
    public List<int> RightSideView(TreeNode root) {
        List<int> res = new List<int>();
        if(root==null) return res;
        Queue<TreeNode> s = new Queue<TreeNode>();
        s.Enqueue(root);
        int l=0, size =0,i;
        TreeNode aux;
        while(s.Count>0){
            size = s.Count;
            for(i=0;i<size;i++){
                aux = s.Dequeue();
                if(res.Count==l) res.Add(aux.val);
                else res[l]=aux.val;
                if(aux.left!=null) s.Enqueue(aux.left);
                if(aux.right!=null) s.Enqueue(aux.right);
            }
            l++;
        }
        return res;
    }
}
