public class Solution {
    public int ClimbStairs(int n) {
        if(n==1) return 1;
        var c = new int[n+1];
        c[1]=1;
        c[2]=2;
        return DFS(n,c);
    }

    private int DFS(int n, int [] cache){
        if(cache[n]!=0 && n!=0) return cache[n];
        cache[n]= DFS(n-1, cache)+DFS(n-2, cache);
        return cache[n];
    }
}
