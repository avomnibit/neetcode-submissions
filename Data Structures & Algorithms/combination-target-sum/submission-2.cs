public class Solution {
    public List<List<int>> CombinationSum(int[] nums, int target) {
        List<List<int>> res = new();
        dfs(nums,0,target,res,0, new List<int>());
        return res;
    }

    private void dfs(int[] nums, int i, int target, List<List<int>> res, int sum, List<int> sol){
        if(sum==target) {res.Add(sol.ToList()); return;}
        if(sum>target || i>=nums.Length) return;
        sol.Add(nums[i]);
        dfs(nums,i,target,res,sum+nums[i],sol);
        sol.RemoveAt(sol.Count-1);
        dfs(nums,i+1,target,res,sum,sol);
    }
}
