public class Solution {
    public List<List<int>> CombinationSum2(int[] candidates, int target) {
        Array.Sort(candidates);
        List<List<int>> res = new();
        back(candidates,0,target,res,0, new List<int>());
        return res;
    }

    private void back(int[] nums, int i, int target, List<List<int>> res, int sum, List<int> sol){
        if(sum==target) { res.Add(sol.ToList()); return; }
        if(sum>target || i>=nums.Length) return;
        sol.Add(nums[i]);
        back(nums,i+1,target,res,sum+nums[i],sol);
        sol.RemoveAt(sol.Count-1);
        while(i + 1 < nums.Length && nums[i] == nums[i+1]) i++;
        back(nums,i+1,target,res,sum,sol);
    }
}
