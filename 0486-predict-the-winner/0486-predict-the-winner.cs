public class Solution {
    public bool PredictTheWinner(int[] nums) {
        int n = nums.Length;
        int[] dp = new int[n];

        // Base case : arrays of length 1
        for(int i = 0; i < n; i++) {
            dp[i] = nums[i];
        }

        // Fill DP table from bottom to top
        for(int i = n - 1; i >= 0; i--) {
            for(int j = i + 1;j < n; j++) {
                dp[j] = Math.Max(nums[i] - dp[j], nums[j] - dp[j - 1]);
            }
        }

        return dp[n - 1] >= 0;
    }
}