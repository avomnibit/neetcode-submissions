public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        Dictionary<int,int> d = new();
        Stack<int> s = new();
        s.Push(0);
        int pIndex=0;
        for(int i=1;i<temperatures.Length;i++){
            while (s.Count>0 && s.TryPeek(out pIndex) && temperatures[i]>temperatures[pIndex]) {
                s.Pop();
                d.Add(pIndex,i-pIndex);
                //0,1
            }
            s.Push(i);
        }
        int [] res = new int[temperatures.Length];
        for(int i=temperatures.Length-2;i>-1;i--){
            if(d.ContainsKey(i)) res[i]=d[i];
        }
        return res;
    }
}
