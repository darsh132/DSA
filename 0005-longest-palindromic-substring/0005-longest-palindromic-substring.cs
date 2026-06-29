public class Solution {
    public string LongestPalindrome(string s) {
        if (string.IsNullOrEmpty(s)) return "";

        int start = 0;
        int maxLength = 0;

        for(int i = 0; i < s.Length; i++) {
            // Case 1: Odd length palindrome (e.g., "aba", center is 'b')
            int len1 = ExpandAroundCenter(s, i, i);

            // Case 2: Even length palindrome (e.g., "cbbd", center is between 'b' and 'b')
            int len2 = ExpandAroundCenter(s, i, i + 1);

            int len = Math.Max(len1, len2);

            // If we found a longer palindrome, update our tracking indices
            if(len > maxLength) {
                maxLength = len;
                // Calculate the starting index of the palindrome substring
                start = i - (len - 1) / 2;
            }
        }

        return s.Substring(start, maxLength);
    }

    private int ExpandAroundCenter(string s, int left, int right) {
        while(left >= 0 && right < s.Length && s[left] == s[right]) {
            left--;
            right++;
        }

        // Returns the length of the palindrome found
        return right - left - 1;
    }
}