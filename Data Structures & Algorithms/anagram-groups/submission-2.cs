public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string,List<string>> map = new Dictionary<string,List<string>>();
        int i;
        string anaMap;
        for(i=0;i<strs.Length;i++){
            anaMap = generateMap(strs[i]);
            if(map.ContainsKey(anaMap)) {
                map[anaMap].Add(strs[i]);
                continue;
            }
            map.Add(anaMap,new List<string>{strs[i]});
        }
        List<List<string>> result = new List<List<string>>();
        foreach(var key in map.Keys){
            result.Add(map[key]);
        }
        return result;
    }

    private string generateMap(string val){
        int[] result = new int[26];
        for(int i=0;i<val.Length;i++){
            result[val[i]-'a']++;
        }
        return string.Join(",", result);
    }
}