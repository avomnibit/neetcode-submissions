public class Solution {
    public int[] ReplaceElements(int[] arr) {
        int max =arr[arr.Length-1];
        arr[arr.Length-1]= -1;
        int t=0;
        for(int i = arr.Length-2;i>-1;i--){
            t = arr[i];
            arr[i]=max;
            if(max<t) max = t;            
        }
        return arr;
    }
}