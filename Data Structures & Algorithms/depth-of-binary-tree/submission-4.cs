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
    public record Pair(TreeNode T, int L);
    public int MaxDepth(TreeNode root) {
        if(root == null) return 0;
        Stack<Pair> s = new Stack<Pair>();
        s.Push(new Pair(root,1));
        Pair p;
        int max=0;
        while(s.Count>0){
            p= s.Pop();
            max=Math.Max(max,p.L);
            if(p.T.left!=null) s.Push(new Pair(p.T.left, p.L+1));
            if(p.T.right!=null) s.Push(new Pair(p.T.right, p.L+1));
        }
        return max;
    }
}
