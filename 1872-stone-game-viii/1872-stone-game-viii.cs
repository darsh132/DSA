public class Solution {
    public int StoneGameVIII(int[] stones) {
        int n = stones.Length;

        // Compute prefix sums in-place
        for(int i = 1; i < n; i++) {
            stones[i] += stones[i - 1];
        }

        // Base case: if forced to pick all n stones (index n - 1)
        int maxDiff = stones[n - 1];

        // Traverse backwards from n - 2 down to 1
        for(int i = n - 2; i >= 1; i--) {
            maxDiff = Math.Max(maxDiff, stones[i] - maxDiff);
        }

        return maxDiff;
    }
}