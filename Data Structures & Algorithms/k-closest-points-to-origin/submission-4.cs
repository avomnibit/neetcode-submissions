public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        var pq = new PriorityQueue<int[],double>();
        for(int i=0;i<points.Length;i++){
            pq.Enqueue(points[i], Math.Sqrt(points[i][0]*points[i][0]+points[i][1]*points[i][1]));
        }
        int[] c;
        List<int[]> result = new List<int[]>();
        while(pq.Count>0 && k>0) {
            c = pq.Dequeue();    
            result.Add(c);
            k--;
        }
        return result.ToArray();
    }
}
