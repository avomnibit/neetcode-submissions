public class Solution {
    public int MaxArea(int[] heights) {
        var max=Math.Min(heights[0],heights[1]);
        int l,r,w;
        for(l=0;l<heights.Length-2;l++){
            r=heights.Length-1;
            while(l<r){
                w=Math.Min(heights[l],heights[r])*(r-l);
                if(w>max) max = w;
                r--;
            }
        }
        return max;
    }
}
