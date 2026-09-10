public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        Dictionary<int,int> d = new();
        Stack<int> s = new();
        s.Push(0);
        int pIndex=0;
        int [] res = new int[temperatures.Length];
        for(int i=1;i<temperatures.Length;i++){
            while (s.Count>0 && s.TryPeek(out pIndex) && temperatures[i]>temperatures[pIndex]) {
                s.Pop();
                res[pIndex]=i-pIndex;
            }
            s.Push(i);
        }
        return res;
    }
}
