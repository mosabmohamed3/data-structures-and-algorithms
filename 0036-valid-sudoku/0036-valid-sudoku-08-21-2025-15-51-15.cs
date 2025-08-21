public class Solution {
    public bool IsValidSudoku(char[][] board) {
        HashSet<char>[] rows = new HashSet<char>[9];
        HashSet<char>[] columns = new HashSet<char>[9];
        HashSet<char>[] boxes = new HashSet<char>[9];

        for(var i=0; i<9; i++)
        {
            rows[i] = new HashSet<char>();
            columns[i] = new HashSet<char>();
            boxes[i] = new HashSet<char>();
        }

        for(var r=0; r<9; r++)
        {
            for(var c=0; c<9; c++)
            {
                if(board[r][c] == '.')
                    continue;
                
                if(!rows[r].Add(board[r][c]))
                    return false;

                if(!columns[r].Add(board[r][c]))
                    return false;

                var p = 3 * (r/3) + (c/3);
                if(!boxes[p].Add(board[r][c]))
                    return false;
            }
        }

        return true;
    }
}