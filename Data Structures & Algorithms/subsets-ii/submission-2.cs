public class Solution {
    public List<List<int>> SubsetsWithDup(int[] nums) {
        Array.Sort(nums);
        List<List<int>> res = new();
        back(nums, res, new List<int>(),0);
        return res;
    }

    private void back(int[] nums,List<List<int>> r, List<int> sol, int i){
        if(i==nums.Length){
            r.Add(sol.ToList());
            return;
        }
        sol.Add(nums[i]);
        back(nums,r,sol,i+1);
        sol.RemoveAt(sol.Count-1);
        while(i+1<nums.Length && nums[i]==nums[i+1]){i++;}
        back(nums,r,sol,i+1);
    }
}
