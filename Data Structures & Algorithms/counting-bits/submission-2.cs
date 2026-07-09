public class Solution {
    public int[] CountBits(int n) {
        int[] result = new int[n+1];
        for(int i=0;i<n+1;i++){
            result[i] = count(i);
        }
        return result;
    }

    private int count(int nr){
        int result=0;
        while(nr>0){
            result+=nr&1;
            nr/=2;
        }
        return result;
    }
}
