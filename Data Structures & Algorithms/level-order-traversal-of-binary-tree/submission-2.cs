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
    public List<List<int>> LevelOrder(TreeNode root) {
        Queue<TreeNode> q = new Queue<TreeNode>();
        List<List<int>> result = new List<List<int>>();
        if(root!=null) q.Enqueue(root);
        TreeNode aux;
        int size,i;
        List<int> current;
        while (q.Count>0){
            size = q.Count;
            current = new List<int>();
            for(i=0;i<size;i++){
                aux = q.Dequeue();
                current.Add(aux.val);
                if(aux.left!=null) q.Enqueue(aux.left);
                if(aux.right!=null) q.Enqueue(aux.right);
            }
            result.Add(current);
        }
        return result;
    }
}
