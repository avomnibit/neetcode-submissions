public class Solution {
    public int MaxArea(int[] heights) {
        int max=0;
        int l=0,r=heights.Length-1,w=0;
        while(l<r){
                w=Math.Min(heights[l],heights[r])*(r-l);
                max=Math.Max(max,w);
                if(heights[l]<=heights[r]) l++;
                else r--;
            }
        return max;
    }
}
