public class Solution {
    public IList<IList<int>> ShiftGrid(int[][] grid, int k) {
        int m = grid.Length;
        int n =  grid[0].Length;
        int total = m * n;
        
        // Effective shifts needed
        k = k % total;

        // Initialize the result list matrix with placeholders
        int[][] resultArray = new int[m][];
        for(int i = 0; i < m; i++) {
            resultArray[i] = new int[n];
        }

        // Map each element directly to its new position
        for(int i = 0; i < m; i++) {
            for(int j = 0; j < n; j++) {
                int oldIdx = i * n + j;
                int newIdx = (oldIdx +  k) % total;

                int newRow = newIdx / n;
                int newCol = newIdx % n;

                resultArray[newRow][newCol] = grid[i][j];
            }
        }

        // Convert the jagged array to the required IList<IList<int>> return type
        IList<IList<int>> result = new List<IList<int>>();
        for(int i = 0; i < m; i++) {
            result.Add(new List<int>(resultArray[i]));
        }

        return result;
    }
}