public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int i,max=0;
        for(i=0;i<piles.Length;i++){
            if(max<piles[i]) max=piles[i];
        }
        int l=1,r=max, mid, lmin=0;
        long minh;
        while(l<=r && r!=0) {
            mid=l+(r-l)/2;
            minh=0;
            for(i=0;i<piles.Length;i++){
                minh+=(long)(piles[i]+mid-1)/mid;
            }
            if(minh<=h) {
                lmin = mid;
                r=mid-1;
            } else {
                l=mid+1;
            }
        }
        return lmin;
    }
}
