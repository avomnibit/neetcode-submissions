public class Solution {
    public int MissingNumber(int[] nums) {
        HashSet<int> s = new HashSet<int>();
        int max=-1;
        for(int i=0;i<nums.Length;i++){
            s.Add(nums[i]);
            if(nums[i]>max) max=nums[i];
        } 
        if(!s.Contains(0)) return 0;
        for(int i=0;i<nums.Length;i++){
            if(!s.Contains(nums[i]+1) && nums[i] != max) return nums[i]+1; 
        } 
        return max+1;
    }
}
