public class Solution {
    public int MaxVowels(string s, int k) {
        int currentCount = 0;

        // Count vowels in the first window of size k
        for(int i = 0; i < k; i++) {
            if(IsVowel(s[i])) {
                currentCount++;
            }
        }

        int maxCount = currentCount;

        // Slide the window across the rest of the string
        for(int i = k; i < s.Length; i++) {
            // Early exit if the maximum possible vowels in a window is reached
            if(maxCount == k) return k;

            if(IsVowel(s[i])) currentCount++;
            if(IsVowel(s[i - k])) currentCount--;

            if(currentCount > maxCount) {
                maxCount = currentCount;
            }
        }

        return maxCount;
    }

    private bool IsVowel(char c) {
        return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
    }
}