public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length!=t.Length) return false;
        int[] map = new int[26];
        int i;
        for(i=0;i<s.Length;i++)
        {
            map[s[i]-'a']++;
        }
        for(i=0;i<t.Length;i++)
        {
            map[t[i]-'a']--;
            if(map[t[i]-'a']==-1) return false;
        }
        for(i=0;i<26;i++){
            if(map[i]!=0) return false;
        }
        return true;
    }
}
