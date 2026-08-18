public class Solution {
    public int ClimbStairs(int n) {
        if(n<3) return n;
        int[] d = new int[n+1];
        d[0]=0;
        d[1]=1;
        d[2]=2;
        for(int i=3;i<n+1;i++){
            d[i]=d[i-1]+d[i-2];
        }
        return d[n];
    }
}
