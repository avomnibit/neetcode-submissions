public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int p=0;
        for(int i=0;i<nums.Length;i++) {
            if(nums[i]==val) continue;
            nums[p]= nums[i];
            p++;
        }
        return p;
    }
}