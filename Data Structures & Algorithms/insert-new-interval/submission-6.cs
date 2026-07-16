public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval) {
       List<int[]> result= new List<int[]>();
       int l = newInterval[0],r= newInterval[1];
       bool add= false;
       for(int i=0;i<intervals.Length;i++){
            if(add || l>intervals[i][1]) 
            { 
                result.Add(intervals[i]);
            }
            else if(intervals[i][0]>r) 
            { 
                result.Add(new int[]{l,r});
                add = true;
                result.Add(intervals[i]);
            }
            else {
                l = Math.Min(l,intervals[i][0]);
                r = Math.Max(r,intervals[i][1]);
            } 
       }
       if (!add) result.Add(new int[]{l, r});
       return result.ToArray<int[]>(); 
    }
}
