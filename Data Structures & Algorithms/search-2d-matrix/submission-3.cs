public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int l=0, r=matrix.Length*matrix[0].Length-1, mid=0;
        while(l<=r){
            mid=l+(r-l)/2;
            if(get(matrix,mid)==target) return true;
            if(get(matrix,mid)>target) {r=mid-1;continue;}
            l=mid+1;
        }
        return false;
    }

    private int get(int[][] matrix, int index)
    => matrix[index/matrix[0].Length][index%matrix[0].Length];
}
