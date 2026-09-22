public class Solution {
    public int ClimbStairs(int n) {
        if(n==1) return 1;
        int prevL=1,last=2,aux=0;
        for(int i=3;i<=n;i++){
            aux=last;
            last+=prevL;
            prevL=aux;
        }
        return last;
    }
}
