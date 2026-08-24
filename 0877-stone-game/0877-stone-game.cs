public class Solution {
    public bool StoneGame(int[] piles) {
        int n = piles.Length;
        int[] dp = (int[])piles.Clone();

        for(int length = 2; length <= n; length++) {
            for(int i = 0; i <= n - length; i++) {
                int j = i + length - 1;
                dp[i] = Math.Max(piles[i] - dp[i + 1], piles[j] - dp[i]);
            }
        }

        return dp[0] > 0;
    }
}