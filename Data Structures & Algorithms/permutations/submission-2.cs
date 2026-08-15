public class Solution {
    public List<List<int>> Permute(int[] nums) {
        List<List<int>> result = new (); 
        back(result, nums, new bool[nums.Length], new List<int>());
        return result;
    }

    private void back(List<List<int>> res, int[] nums, bool[] c, List<int> sol){
        if(sol.Count==nums.Length){
            res.Add(sol.ToList());
            return;
        }
        for(int i=0;i<nums.Length;i++){
            if(!c[i]){
                c[i]=true;
                sol.Add(nums[i]);
                back(res,nums,c,sol);
                sol.RemoveAt(sol.Count-1);
                c[i]= false;
            }
        }
    }
}
