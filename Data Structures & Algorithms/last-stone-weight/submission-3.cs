public class Solution {
    public int LastStoneWeight(int[] stones) {
        PriorityQueue<int, int> pq = new PriorityQueue<int,int>();
        for(int i=0;i<stones.Length;i++){
            pq.Enqueue(stones[i],-stones[i]);
        }
        int e1,e2; 
        while(pq.Count>0){
            if(pq.Count==1) return pq.Dequeue();
            e1 = pq.Dequeue();
            e2 = pq.Dequeue();
            if(e1!=e2) pq.Enqueue(e1-e2,-(e1-e2));
        }
        return 0;
    }
}
