public class Solution {
    public int FindMin(int[] nums) {
        if(nums[0]<=nums[nums.Length-1]) return nums[0];
        int l=0,r=nums.Length, mid=0;
        while (l+1<r){
            mid = (r+l)/2;
            if(nums[mid]>=nums[l]) l=mid;
            else r=mid;
        }
        return nums[r];
    }
}
