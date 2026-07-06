public class Solution {
    private readonly int[][] directions = new int[][]
    {
        new int[]{0,1}, new int[]{1,0},
        new int[]{-1,0}, new int[]{0,-1},
    };

    public int NumIslands(char[][] grid) {
        int rows = grid.Length;
        int cols = grid[0].Length;
        int result=0;
        for(int i=0;i<rows;i++){
            for(int j=0;j<cols;j++){
                if(grid[i][j]=='1') {
                    dfs(grid,rows, cols,i,j);
                    result++;
                }
            }
        }
        return result;
    }

    private void dfs(char[][] g,int rows,int cols,int i,int j){
        g[i][j]='0';
        foreach(var dir in directions){
            int k=i+dir[0],l=j+dir[1];
            if(k<rows && l<cols && k>-1 && l>-1 && g[k][l]=='1') dfs(g,rows,cols,k,l);
        }
    }
}
