public class Solution {
    public bool WinnerSquareGame(int n) {
        bool[] dp = new bool[n + 1];

        for(int i = 1; i <= n; i++) {
            for(int k = 1; k * k <= i; k++) {
                if(!dp[i - k * k]) {
                    dp[i] = true;
                    break; // Found a winning move, no need to check further
                }
            }
        }

        return dp[n];
    }
}