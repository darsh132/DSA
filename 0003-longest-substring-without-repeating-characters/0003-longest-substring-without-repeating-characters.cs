public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if(string.IsNullOrEmpty(s)) {
            return 0;
        }

        Dictionary<char, int> lastSeen = new Dictionary<char, int>();
        int left = 0;
        int maxLength = 0;

        for(int right = 0; right < s.Length; right++) {
            char current = s[right];

            if(lastSeen.TryGetValue(current, out int prevIndex) && prevIndex >= left) {
                left = prevIndex + 1;
            }

            lastSeen[current] = right;
            maxLength = Math.Max(maxLength, right - left + 1);
        }

        return maxLength;
    }
}