public class Solution {  
    public List<string> GenerateParenthesis(int n) {
        HashSet<string> h = new();
        h.Add("()");
        for(int i=1;i<n;i++){
            var h2 = new HashSet<string>();
            foreach(var hj in h){
                for(int k=0;k<=hj.Length;k++){
                    h2.Add(hj.Insert(k,"()"));
                }
            }
            h=h2;
        }
        return h.ToList();
    }
}
