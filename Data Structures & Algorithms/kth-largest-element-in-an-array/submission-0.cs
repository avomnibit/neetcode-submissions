public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        PriorityQueue<int,int> p = new();
        for(int i=0;i<nums.Length;i++){
            p.Enqueue(nums[i],nums[i]);
            if(p.Count>k) p.Dequeue();
        }
        return p.Peek();
    }
}
