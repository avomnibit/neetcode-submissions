public class Solution {
    private int INF = int.MaxValue;

    public void islandsAndTreasure(int[][] grid) {
        int r = grid.Length;
        int c = grid[0].Length;
        Queue<int> q = new Queue<int>();

        for (int i = 0; i < r; i++) {
            for (int j = 0; j < c; j++) {
                if (grid[i][j] == 0) {
                    q.Enqueue(i*c+j);
                }
            }
        }

        int d=0;
        int size, aux, cr,cc;
        while(q.Count>0){
            size = q.Count;
            for(int k = 0;k<size;k++){
                aux = q.Dequeue();
                cr=aux/c;
                cc=aux%c;
                if(cr>0 && grid[cr-1][cc]==INF) {grid[cr-1][cc]=grid[cr][cc]+1; q.Enqueue((cr-1)*c+cc);}
                if(cr<r-1 && grid[cr+1][cc]==INF) {grid[cr+1][cc]=grid[cr][cc]+1;q.Enqueue((cr+1)*c+cc);}
                if(cc>0 && grid[cr][cc-1]==INF) {grid[cr][cc-1]=grid[cr][cc]+1;q.Enqueue(cr*c+cc-1);}
                if(cc<c-1 && grid[cr][cc+1]==INF) {grid[cr][cc+1]=grid[cr][cc]+1;q.Enqueue(cr*c+cc+1);}
            }
        }
    }
}