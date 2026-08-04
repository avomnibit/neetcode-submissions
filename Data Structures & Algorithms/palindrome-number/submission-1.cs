public class Solution {
    public bool IsPalindrome(int x) {
        if (x<0) return false;
        if (x/10==0) return true;
        return reverse(x,0,x);
    }

    private bool reverse(int nr, int rev, int l){
        if(l==0) return nr == rev;
        int aux = l%10;
        return reverse(nr, rev*10+aux,l/10); 
    }
}