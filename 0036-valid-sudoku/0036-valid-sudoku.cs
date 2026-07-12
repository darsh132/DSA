public class Solution {
    public bool IsValidSudoku(char[][] board) {
        HashSet<string> seen = new HashSet<string>();
        
        for(int r = 0; r < 9; r++)
        {
            for(int c = 0; c < 9; c++)
            {
                char num = board[r][c];
                
                if(num == '.')
                    continue;
                
                string rowKey = num + " in row " + r;
                string colKey = num + " in col " + c;
                string boxKey = num + " in box " + (r / 3) + "-" + (c / 3);
                
                if(!seen.Add(rowKey) || !seen.Add(colKey) || !seen.Add(boxKey))
                    return false;
            }
        }
        
        return true;
    }
}