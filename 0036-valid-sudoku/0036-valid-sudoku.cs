public class Solution {
    public bool IsValidSudoku(char[][] board) {
        bool[,] rows = new bool[9,9];
        bool[,] cols = new bool[9,9];
        bool[,] boxes = new bool[9,9];

        for(int r = 0; r < 9; r++) {
            for(int c = 0; c < 9; c++) {
                char ch = board[r][c];
                if(ch == '.') continue;

                int num = ch - '1'; // Map '1'-'9' to indices 0-8
                int boxIndex = (r / 3) * 3 + (c / 3);

                if(rows[r, num] || cols[c, num] || boxes[boxIndex, num]) {
                    return false;
                }

                rows[r, num] = true;
                cols[c, num] = true;
                boxes[boxIndex, num] =  true;
            }
        }

        return true;
    }
}