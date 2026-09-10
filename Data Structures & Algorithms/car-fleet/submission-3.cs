public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        Dictionary<int,float> d = new();
        for(int i=0;i<position.Length;i++){
            d.TryAdd(position[i],((target-position[i])/(float)speed[i]));
        }
        Array.Sort(position);
        int res=1;
        float s=d[position[position.Length-1]];
        for(int i=position.Length-2;i>-1;i--){
            if(d[position[i]]<=s) continue;
            res++;
            s=d[position[i]];
        }
        return res;
    }
}
