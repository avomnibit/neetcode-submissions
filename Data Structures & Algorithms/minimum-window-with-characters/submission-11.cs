public class Solution {
    public string MinWindow(string s, string t) {
        Dictionary<char,int> mapS = new Dictionary<char,int>();
        Dictionary<char,int> mapT = new Dictionary<char,int>();
        int min = int.MaxValue, l=0,r=0;
        string result = "";

        foreach (var c in t){
            if(!mapT.ContainsKey(c)) mapT[c]=1;
            else mapT[c]++;
            mapS[c]=0;
        }
        for(r=0;r<s.Length;r++){
            if(mapS.ContainsKey(s[r])) mapS[s[r]]++;
            while(valid(mapS, mapT) && l<=r) 
            {
                if(min>r-l+1){
                    min = r-l+1;
                    result = s.Substring(l, min);
                }
                if(mapS.ContainsKey(s[l])) mapS[s[l]]--;
                l++;
            }
        }
        return result;
    }

    private bool valid(Dictionary<char,int> mapS, Dictionary<char,int> mapT){
        foreach(var key in mapT.Keys){
            if(mapT[key]>mapS[key]) return false;
        }
        return true;
    }
}