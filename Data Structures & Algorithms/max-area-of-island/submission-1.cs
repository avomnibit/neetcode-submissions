public class Solution {
    public int MaxAreaOfIsland(int[][] grid) {
        int max = 0, current=0, cMax=0, cr,cc;
        HashSet<int> h = new HashSet<int>();
        Stack<int> s = new Stack<int>();
        int r=grid.Length,c = grid[0].Length;
        for(int i=0;i<r;i++){
            for(int j=0;j<c;j++){
                if(h.Contains(i*c+j)) continue;
                if(grid[i][j]==1){
                    //get island
                    s.Push(i*c+j);
                    h.Add(i*c+j);
                    cMax=0;
                    while(s.Count>0){
                        current=s.Pop();

                        cr=current/c;
                        cc=current%c;
                        if(cr>0 && !h.Contains((cr-1)*c+cc) && grid[cr-1][cc]==1) { s.Push((cr-1)*c+cc); h.Add((cr-1)*c+cc); }
                        if(cr<r-1 && !h.Contains((cr+1)*c+cc) && grid[cr+1][cc]==1) { s.Push((cr+1)*c+cc); h.Add((cr+1)*c+cc); }
                        if(cc>0 && !h.Contains(cr*c+cc-1) && grid[cr][cc-1]==1) { s.Push(cr*c+cc-1); h.Add(cr*c+cc-1); }
                        if(cc<c-1 && !h.Contains(cr*c+cc+1) && grid[cr][cc+1]==1) { s.Push(cr*c+cc+1); h.Add(cr*c+cc+1); }
                        cMax++;
                    }
                    max= Math.Max(cMax,max);
                }
            }
        }
        return max;
    }
}
