public class Solution {
    public uint ReverseBits(uint n) {
        uint r=0;
        for(int i=0;i<32;i++){
            r=r*2+n%2;
            n/=2;
        }
        return r;
    }
}
