public class Solution {
    public bool IsValidSudoku(char[][] board) {
        HashSet<char>[] row = new HashSet<char>[9];
        HashSet<char>[] col = new HashSet<char>[9];
        HashSet<char>[] box = new HashSet<char>[9];

        for(var i=0; i<9; i++)
        {
            row[i] = new HashSet<char>();
            col[i] = new HashSet<char>();
            box[i] = new HashSet<char>();
        }

        for(var r=0; r<9; r++) // for rows
        {
            for(var c=0; c<9; c++) // for columns
            {
                if (board[r][c] == '.')
                    continue;

                if(!row[r].Add(board[r][c]))
                    return false;

                if(!col[c].Add(board[r][c]))
                    return false;

                var b = 3 * (r/3) + (c/3);
                if(!box[b].Add(board[r][c]))
                    return false;
            }
        }

        return true;
    }
}
        
    // private void Validate(char c, HashSet<char> hash)
    // {
    //     if (!hashSet.Contains(c) && int.TryParse(c))
    //         hashSet.Add(c);
    //     else if(hashSet.Contains(c) && int.TryParse(c))
    //         return false;
    // }
