public class Solution {
    public int ClimbStairs(int n) {
        int[] cache = new int[n];
        for(int i=0;i<n;i++){
            cache[i] = -1;
        }
        return dfs(cache,n,0);
    }

    private int dfs(int[] c,int n, int p){
        if(p>n) return 0;
        if(p==n) return 1;
        if (c[p] != -1) return c[p];
        return c[p]= dfs(c,n,p+1)+dfs(c,n,p+2);
    }
}
