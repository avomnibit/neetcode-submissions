public class Solution {
    public int MaxSubArray(int[] nums) {
        int max=nums[0],l=0,r=0,s=nums[0];

        while(r++<nums.Length-1){
            if(s<0){ l=r; s=0;}
            s+=nums[r];
            max=Math.Max(max,s);
        }
        return max;
    }
}
