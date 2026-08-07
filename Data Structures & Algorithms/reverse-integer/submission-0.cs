public class Solution {
    public int Reverse(int x) {
        // 2^31 - int.MaxValue
        // a*10 + b > int.MaxValue
        // a > (int.MaxValue-b)/10
        int result=0, b=0;
        bool neg = x<0;
        if(neg) x*=-1;
        while(x>0){
            b = x%10;
            if((int.MaxValue-b)/10<result) return 0;
            result= result*10 + b;
            x/=10;
        }
        return neg? result*-1:result;
    }
}
