public class Solution {
    public bool IsValidSudoku(char[][] board) {
        bool[,] lin = new bool[9,9];
        bool[,] cols = new bool[9,9];
        bool[,] squares = new bool[9,9];
        int v=0, sql=0,sqc=0;
        for(int i=0;i<9;i++){
            for(int j=0;j<9;j++){
                if(board[i][j]=='.') continue;
                v= board[i][j]-'1';
                if(lin[i,v]==true) return false;
                else lin[i,v]=true;
                if(cols[j,v]==true) return false;
                else cols[j,v]=true;
                sql=i/3;
                sqc=j/3;
                if(squares[sql*3+sqc,v]==true) return false;
                else squares[sql*3+sqc,v]=true;
            }
        }
        return true;
    }
}
