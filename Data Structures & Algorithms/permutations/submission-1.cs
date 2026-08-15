public class Solution {
    public List<List<int>> Permute(int[] nums) {
        List<List<int>> result = new (); 
        result.Add(new List<int>());
        for(int i=0;i<nums.Length;i++){
            List<List<int>> res = new (); 
            for(int j=0;j<result.Count;j++){
                for(int k=0;k<=result[j].Count;k++){
                    List<int> aux = result[j].ToList();
                    aux.Insert(k, nums[i]);
                    res.Add(aux);
                }
            }
            result = res;
        }
        return result;
    }
}
