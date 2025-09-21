public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int rows = matrix.Length;
        int columns = matrix[0].Length;
        
        int r = rows * columns - 1; // 8
        int l = 0;

        while(l <= r)
        {
            int mid = l + (r - l) / 2;
            int row = mid / columns;   // which row mid belongs to
            int column = mid % columns; // which column inside that row

            if(target > matrix[row][column])
                l = mid + 1;
            else if(target < matrix[row][column])
                r = mid - 1;
            else
                return true;
        }
        
        return false;
        // for(int i = 0; i < matrix.Length; i++)
        // {
        //     for(int j = 0; j < matrix[i].Length; j++)
        //     {
        //         if(matrix[i][j] == target)
        //             return true;
        //     }
        // }
        // return false;
    }
}