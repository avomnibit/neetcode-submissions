public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        int l = strs[0].Length;
        for(int i=1;i<strs.Length;i++) {
            if( l > strs[i].Length) l = strs[i].Length;
            for(int j=0;j<l;j++) {
                if(strs[0][j]!=strs[i][j]) {
                    l=j; 
                    break;
                }
            }
        }
        return l==0 ? "":strs[0][0..l];
    }
}