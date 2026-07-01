public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> dup = new HashSet<int>();
        for (int i=0;i<nums.Length;i++){
            if (dup.Contains(nums[i])) return true;
            dup.Add(nums[i]);
        }
        return false;
    }
}