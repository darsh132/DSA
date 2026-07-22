public class Solution {
    public int ScoreOfString(string s) {
        int totalScore = 0;

        // Loop up to s.Length - 1 to compare adjacent pairs (i and i + 1)
        for(int i = 0; i < s.Length - 1; i++) {
            // Calculate the absolute difference between adjacent ASCII value
            totalScore += Math.Abs(s[i] - s[i + 1]);
        }

        return totalScore;
    }
}