public class Solution {
    public int Trap(int[] height) {
        int[] right = new int[height.Length];
        int[] left = new int[height.Length];
        int level=0,i=0,min=0;
        for (i=0;i<height.Length;i++){
            if(height[i]>level) level = height[i];
            right[i]=level;
        }
        level=0;
        for (i=height.Length-1;i>-1;i--){
            if(height[i]>level) level = height[i];
            left[i]=level;
        }
        level=0;
        for (i=0;i<height.Length;i++){
            level += Math.Min(left[i], right[i]) - height[i];
        }
        return level;
    }
}
