public class KthLargest {
    PriorityQueue<int,int> pq;
    int kValue;

    public KthLargest(int k, int[] nums) {
        pq = new PriorityQueue<int,int>();
        kValue = k; 
        for(int i=0;i<nums.Length;i++){
            pq.Enqueue(nums[i], nums[i]);
        }
        while(pq.Count>k) pq.Dequeue();
    }
    
    public int Add(int val) {
        pq.Enqueue(val, val);
        
        while(pq.Count>kValue) pq.Dequeue();
        return pq.Peek();
    }
}
