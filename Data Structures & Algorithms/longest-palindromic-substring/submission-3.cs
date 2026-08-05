public class Solution {
    public string LongestPalindrome(string s) {
        if(s.Length<=1) return s;
        int max=1, ind=0;
        var d = new bool[s.Length,s.Length];
        for(int i=s.Length-1;i>-1;i--){
            for(int j=i;j<s.Length;j++){
                if(s[i]==s[j] && (j-i<=2 || d[i+1,j-1]==true)){
                    d[i,j]=true;
                    if(j-i+1>max) {max = j-i+1;ind=i;}
                }
            }
        }
        return s.Substring(ind, max);
    }
}
