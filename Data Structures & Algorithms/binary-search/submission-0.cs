public class Solution {
    public int Search(int[] nums, int target) {
        int l=0, r=nums.Length-1, mid=0;
        while (l<=r){
            mid=l+(r-l)/2;
            if(nums[mid]==target) return mid;
            if(nums[mid]>target) {r=mid-1;continue;} 
            l=mid+1;
        }
        return -1;
    }
}
