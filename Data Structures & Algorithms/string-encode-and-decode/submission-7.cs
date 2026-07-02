public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder sb = new StringBuilder();
        for(int i=0;i<strs.Count;i++){
            sb.Append(strs[i].Length);
            sb.Append('|');
            sb.Append(strs[i]);
        }
        return sb.ToString();
    }

    public List<string> Decode(string s) {
        var result = new List<string>();
        int i=0, j, len;
        while(i<s.Length){
            j=s.IndexOf("|",i);
            len=int.Parse(s[i..j]);
            result.Add(s[(j+1)..(j+1+len)]);
            i=j+1+len;
        } 
        return result;
   }
}
