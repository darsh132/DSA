public class Solution {
    public bool IsMatch(string s, string p) {
        int m = s.Length;
        int n = p.Length;

        // db[i][j] represents if s[i...] matches p[j...]
        bool[,] dp = new bool[m + 1, n + 1];

        // Base case: empty string mateches empty pattern
        dp[m, n] = true;

        // Fill the DP table from bottom-up
        for(int i = m; i >= 0; i--) {
            for(int j = n - 1; j >= 0; j--) {

                // Check if current characters match
                bool firstMatch = (i < m && (s[i] == p[j] || p[j] == '.'));

                // Case 1: The next character in pattern is '*'
                if(j + 1 < n && p[j + 1] ==  '*') {
                    // Two options:
                    // 1. Skip the '*' property (count as 0 matches of p[j]) -> dp[i, j+2]
                    // 2. Consume one character of s if it matches -> firstMatch && dp[i+1, j]
                    dp[i, j] = dp[i, j + 2] || (firstMatch && dp[i + 1, j]);
                }
                // Case 2: Standard match with no '*' following
                else {
                    dp[i, j] = firstMatch && dp[i + 1, j + 1];
                }
            }
        }
        return dp[0, 0];
    }
}