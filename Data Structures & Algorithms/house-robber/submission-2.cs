public class Solution {
    public int Rob(int[] nums) {
        int n = nums.Length;
        if(n==0) return 0;
        if(n==1) return nums[0];
        int[] c = new int[n];
        c[0] = nums[0];
        c[1] = Math.Max(nums[0], nums[1]);
        for(int i=2;i<n;i++){
            c[i]= Math.Max(c[i-1],nums[i]+c[i-2]); 
        }
        return c[n-1];
    }
}
