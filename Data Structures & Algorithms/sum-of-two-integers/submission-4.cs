public class Solution {
    public int GetSum(int a, int b) {
        int c = 0, res = 0, b1=0,b2=0,r=0;
        for(int i=0;i<32;i++){
            b1 = (a>>i) & 1;
            b2 = (b>>i) & 1;
            r=b1^b2^c;
            res |= (r<<i);
            c = (b1&b2) | (b1&c) | (b2&c);
        }
        return res;
    }
}
