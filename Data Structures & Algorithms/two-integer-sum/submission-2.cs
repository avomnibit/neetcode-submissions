public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> map = new Dictionary<int,int>();
        for(int i=0;i<nums.Length;i++){
            if(map.ContainsKey(nums[i])) return new int[]{ map[nums[i]],i};
            map[target-nums[i]] = i;
        }
        return null;
    }
}
