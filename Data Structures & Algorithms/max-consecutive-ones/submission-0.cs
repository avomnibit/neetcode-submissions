public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        var max = 0;
        var current = 0;
        for(int i=0;i<nums.Length;i++){
            if(nums[i] == 0) {
                current =0; 
                continue;
            }
            current++;
            if(max<current) max = current;
        }
        return max;
    }
}