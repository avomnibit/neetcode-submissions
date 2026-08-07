public class Solution {
    public int MissingNumber(int[] nums) {
        HashSet<int> s = new HashSet<int>(nums);
        if(!s.Contains(0)) return 0;
        for(int i=0;i<nums.Length;i++){
            if(!s.Contains(i)) return i; 
        } 
        return nums.Length;
    }
}
