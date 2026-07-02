public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if(s.Length<2) return s.Length;
        if(s.Length==2 && s[0]==s[1]) return 1;
        HashSet<char> set= new HashSet<char>(){s[0]};
        int l=0, r=1, max=1;
        while(r<s.Length){
            if(set.Contains(s[r])) {
                set.Remove(s[l]);
                l++;
                continue;
            }
            set.Add(s[r]);
            max=Math.Max(max,r-l+1);
            r++;
        }
        return max; 
    }
}
