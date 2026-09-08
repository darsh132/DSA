public class Solution {
    public int FurthestDistanceFromOrigin(string moves) {
        int lCount = 0;
        int rCount = 0;
        int blankCount = 0;

        foreach(char c in moves) {
            if (c == 'L') {
                lCount++;
            } else if (c == 'R') {
                rCount++;
            } else {
                blankCount++;
            }
        }

        // Maximizing distance means turning all '_' in the direction that already has more moves
        return Math.Abs(lCount - rCount) + blankCount;
    }
}