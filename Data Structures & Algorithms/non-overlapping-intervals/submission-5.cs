public class Solution {
    public int EraseOverlapIntervals(int[][] intervals) {
        Array.Sort(intervals,(a,b)=> a[0].CompareTo(b[0]));
        int result=0;
        int[] prev= intervals[0];
        for(int i=1;i<intervals.Length;i++){
            if(intervals[i][0]>=prev[1]) {
                prev=intervals[i];
                continue;
            }
           if(intervals[i][1]>prev[1]){
            result++;
            continue;
           }
           result++;
           prev=intervals[i];
        }
        return result;
    }
}
