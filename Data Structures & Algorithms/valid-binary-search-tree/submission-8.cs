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

public record StElement(TreeNode node,int min,int max);


public class Solution {
    public bool IsValidBST(TreeNode root) {
        Queue<StElement> queue = new Queue<StElement>();

        queue.Enqueue(new StElement(root, int.MinValue, int.MaxValue));
        int size,i;
        StElement aux;
        while(queue.Count>0){
            size = queue.Count;
            for(i=0;i<size;i++){
                aux = queue.Dequeue();
                if(aux.node.val<=aux.min || aux.node.val>=aux.max) return false;
                if(aux.node.right!=null) queue.Enqueue(new StElement(aux.node.right, aux.node.val, aux.max));
                if(aux.node.left!=null) queue.Enqueue(new StElement(aux.node.left, aux.min, aux.node.val));
            }
        }
        return true;
    }
}
