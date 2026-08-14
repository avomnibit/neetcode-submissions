public class Solution {
    public List<List<int>> Subsets(int[] nums) {
        List<List<int>> result = new ();
        string binaryString;
        List<int> aux;
        for(int i=0;i<Math.Pow(2,nums.Length);i++){
            binaryString = Convert.ToString(i, 2).PadLeft(nums.Length, '0');
            aux = new();
            for(int j=0;j<binaryString.Length;j++){
                if(binaryString[j]=='1') aux.Add(nums[j]);
            }
            result.Add(aux);
        }
        return result;
    }
}
