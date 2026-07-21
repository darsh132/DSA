public class Solution {
    public int OrangesRotting(int[][] grid) {
        if(grid == null || grid.Length == 0) return 0;

        int rows = grid.Length;
        int cols = grid[0].Length;
        Queue<(int r, int c)> queue = new Queue<(int, int)>();
        int freshOranges = 0;

        // Step 1: Find all initial rotten oranges and count fresh ones
        for(int r = 0; r < rows; r++) {
            for(int c = 0; c < cols; c++) {
                if(grid[r][c] == 2) {
                    queue.Enqueue((r,c));
                } else if(grid[r][c] == 1) {
                    freshOranges++;
                }
            }
        }

        // If there are no fresh oranges to begin with, 0 minutes have elapsed 
        if(freshOranges == 0) return 0;

        int minutes = 0;
        // 4-directional offsets: Up, Down, Left, Right
        int[][] directions = new int[][] {
            new int[] {-1, 0}, new int[] {1,0},
            new int[] {0, -1}, new int[] {0,1}
        };

        // Step 2: Process the queue layer by layer
        while(queue.Count > 0 && freshOranges > 0) {
            int size = queue.Count;
            minutes++;

            for(int i = 0; i < size; i++) {
                var (r, c) = queue.Dequeue();

                foreach(var dir in directions) {
                    int newRow = r + dir[0];
                    int newCol = c + dir[1];

                    // Check boundaries and if the neighboring orange is fresh
                    if(newRow >= 0 && newRow < rows && newCol >= 0 && newCol < cols && grid[newRow][newCol] == 1) {

                        // Infect the fresh orange
                        grid[newRow][newCol] = 2;
                        freshOranges--;
                        queue.Enqueue((newRow, newCol));
                    }
                }
            }
        }

        // Step 3: If fresh oranges remain, it's impossible to rot them all
        return freshOranges == 0 ? minutes : -1;
    }
}