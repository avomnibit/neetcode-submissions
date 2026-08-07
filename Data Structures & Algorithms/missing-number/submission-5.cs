public class Solution {
    public int MissingNumber(int[] nums) {
        if(nums.Length==1) return nums[0]==0?nums[0]+1:0;
        Array.Sort(nums);
        for(int i=0;i<nums.Length-1;i++){
            if(nums[i]+1!=nums[i+1]) return nums[i]+1;
        } 
        return nums[0]==0?nums[nums.Length-1]+1:0;
    }
}
