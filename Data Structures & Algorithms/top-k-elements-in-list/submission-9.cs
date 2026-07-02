public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        //[2,2,2,2,2,4,4,4,4,4,4,0]
        int[] map = new int[2001];
        int i;
        for(i=0;i<nums.Length;i++){
            map[nums[i]+1000]++;
        }
        //      1000    1002  1004 1007
        //[0      1       5    6    5   ]
        List<int>[] secMap = new List<int>[nums.Length + 1];
        for(i=0;i<2001;i++){
            if(map[i]==0) {
                continue;
            }
            if(secMap[map[i]] == null) secMap[map[i]] = new List<int>();
            secMap[map[i]].Add(i-1000);
        }
        //    5  6  
        //[   2  4  ]
        i=nums.Length + 1;
        List<int> result = new List<int>();
        while(i-->0 && k > 0){
            if(secMap[i]==null) continue;
            for(int j=0;j<secMap[i].Count && k > 0;j++){
                result.Add(secMap[i][j]);
                k--;
            }

        }
        return result.ToArray();
    }
}
