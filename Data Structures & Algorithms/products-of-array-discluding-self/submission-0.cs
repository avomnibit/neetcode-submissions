public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var prod = 1;
        int[] n2 = new int[nums.Length];
        int i;
        for(i=0;i<nums.Length;i++){
            n2[i]=prod;
            prod*=nums[i];
        } 
        //[1  1  2  8]
        prod=1;
        int aux;
        for(i=nums.Length-1;i>-1;i--){
            aux = nums[i];
            nums[i]=prod*n2[i];
            prod*=aux;
        }
        //[         8]
        return nums;
    }
}
