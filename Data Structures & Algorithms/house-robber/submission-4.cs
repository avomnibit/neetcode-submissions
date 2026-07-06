public class Solution {
    public int Rob(int[] nums) {
        int n = nums.Length;
        if(n==0) return 0;
        if(n==1) return nums[0];
        int[] c = new int[n+1];
        c[1] = nums[0];
        c[2] = Math.Max(nums[0], nums[1]);
        for(int i=3;i<n+1;i++){
            c[i]= Math.Max(c[i-1],nums[i-1]+c[i-2]); 
        }
        return c[n];
    }
}
