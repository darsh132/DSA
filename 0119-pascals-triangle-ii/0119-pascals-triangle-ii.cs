public class Solution {
    public IList<int> GetRow(int rowIndex) {
        int[] row = new int[rowIndex + 1];
        row[0] = 1;

        for(int i = 1; i <= rowIndex; i++) {
            // Update backward to avoid overwriting values needed for the next computation
            for(int j = i; j > 0; j--) {
                row[j] += row[j - 1];
            }
        }

        return row;
    }
}