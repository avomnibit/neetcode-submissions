public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if(s2.Length<s1.Length) return false;
        int[] fs1= new int[26];
        int[] fs2;
        int i,j,ind;
        bool found;
        for(i=0;i<s1.Length;i++){
            fs1[s1[i]-'a']++;
        }
        for(i=0;i<s2.Length-s1.Length+1;i++){
            if(fs1[s2[i]-'a']==0) continue;
            fs2=new int[26];
            found = true;
            for(j=i;j<i+s1.Length;j++){
                ind = s2[j]-'a';
                fs2[ind]++;
                if(fs1[ind]==0 || fs2[ind]>fs1[ind]) {found = false;break;}
            }
            if(found) return true;
        }
        return false;
    }
}
