public class Solution {
    public List<List<int>> SubsetsWithDup(int[] nums) {
        Array.Sort(nums);
        List<List<int>> res = new();
        HashSet<string> h = new HashSet<string>();
        res.Add(new List<int>());
        for(int i=0;i<nums.Length;i++){
            int s = res.Count;
            for (int j =0;j<s;j++){
                var r = res[j].ToList();
                r.Add(nums[i]);
                var ss = string.Join(',',r);
                if(!h.Contains(ss)){
                    h.Add(ss);
                    res.Add(r);
                }
            }
        }
        return res;
    }
}
