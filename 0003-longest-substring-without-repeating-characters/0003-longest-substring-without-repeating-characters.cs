public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int n = s.Length;
        int maxLength = 0;

        // Array to store the last seen index of each character (ASCII extended)
        int[] lastSeen = new int[128];
        // Initialize all positions to -1 indicating they haven't been yet
        Array.Fill(lastSeen, -1);

        int left = 0;

        // 'right' expands the window scanning across the string
        for(int right = 0; right < n; right++) {
            char currentChar = s[right];

            // If we've seen the character before AND it sits inside our current window
            if(lastSeen[currentChar] >= left) {
                // Shrink the window by jumping 'left' right past the old duplicate's position
                left = lastSeen[currentChar] + 1;
            }

            // Record or update the last seen position of the current characters
            lastSeen[currentChar] = right;

            // Calculate the current window size (right - left + 1) and track the max
            maxLength = Math.Max(maxLength, right - left + 1);
        }

        return maxLength;        
    }
}