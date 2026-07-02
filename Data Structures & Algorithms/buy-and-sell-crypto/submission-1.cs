public class Solution {
    public int MaxProfit(int[] prices) {
        int max=0,l=0,r=1,a=0;
        while(r<prices.Length){
            a = prices[r]-prices[l];
            max = Math.Max(max,a);
            if(a<=0){
                l=r;
            }
            r++;
        }
        return max;
    }
}
