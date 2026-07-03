public class Solution {
    public int CharacterReplacement(string s, int k) {
        Dictionary<char, int> map = new Dictionary<char,int>();
        int l=0, r=0;
        int max =0;
        while(r<s.Length){
            if(map.ContainsKey(s[r])) map[s[r]]++;
            else map[s[r]]=1;
            if(valid(map,k)) {
                max= Math.Max(max,r-l+1);
                r++;
                continue;
            }
            if(map[s[l]]==1) map.Remove(s[l]);
            else map[s[l]]--;
            l++;
            r++;
        }
        return max;
    }
    private bool valid(Dictionary<char, int> m, int k){
        int max=0, total =0;
        foreach(var val in m.Values){
            max = Math.Max(max,val);
            total+=val;
        }
        return total-max<=k;
    }
}
