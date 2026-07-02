public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> set = new HashSet<int>(nums);
        int currentLength=0, currentValue=0, longest =0;
        for(int i=0; i< nums.Length;i++){
            if (set.Contains(nums[i]-1)) continue;
            currentLength=0;
            currentValue = nums[i];
            while(set.Contains(currentValue++)){
                currentLength++;
            }
            if (longest<currentLength) longest=currentLength;
        } 
        return longest;
    }
}
