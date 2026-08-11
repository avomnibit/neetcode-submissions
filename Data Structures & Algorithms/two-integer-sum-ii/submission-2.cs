public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int l=0,r=numbers.Length-1, sum=0;
        while(l<r){
            sum=numbers[l]+numbers[r];
            if(sum==target) return new int[]{l+1,r+1};
            if(sum<target) {l++; continue;}
            r--;
        }
        return new int[]{-1,-1};
    }
}
