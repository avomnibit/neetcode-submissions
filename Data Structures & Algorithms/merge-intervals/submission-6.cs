public class Solution {
    public int[][] Merge(int[][] intervals) {
        //initialize result
        Array.Sort(intervals, (i1, i2) => i1[0].CompareTo(i2[0]));
        List<int[]> result = new List<int[]>();
        if(intervals == null || intervals.Length <= 1) return intervals;
        // make prev intervals[0]
        int l=intervals[0][0], r = intervals[0][1];
        // with prev compare to new interval
        for(int i=0;i<intervals.Length;i++){
            // if(r<int[i][0]) -> write prev in result
            // prev = min, max
            if(r<intervals[i][0]) {
                result.Add(new int[]{l,r});
                l = intervals[i][0];
                r = intervals[i][1];
            } else {
                l = Math.Min(intervals[i][0],l);
                r = Math.Max(intervals[i][1],r);
            }
        }
        result.Add(new int[]{l,r});
        return result.ToArray();
        // return result
    }
}
