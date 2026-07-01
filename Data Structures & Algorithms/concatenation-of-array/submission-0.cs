public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int[] newNums = new int[nums.Length*2];
        for(int i=0;i<nums.Length;i++){
            newNums[i]=nums[i];
            newNums[i+nums.Length]=nums[i];
        }
        return newNums;
    }
}