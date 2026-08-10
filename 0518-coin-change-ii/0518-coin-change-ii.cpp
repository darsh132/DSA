class Solution {
public:
    int change(int amount, vector<int>& coins) {
        // dp[i] will store the number of combinations to make amount i 
        vector<unsigned int> dp(amount + 1, 0);

        // Base case: 1 way to make amount 0 (by picking no coins)
        dp[0] = 1;

        // Outer loop iterates over each coin to avoid counting permutations
        for(int coin : coins) {
            for(int i = coin; i <= amount; ++i) {
                dp[i] += dp[i - coin];
            }
        }

        return dp[amount];
    }
};