public class Solution {
    public IList<string> CommonChars(string[] words) {
        // Array to store the minimum frequency of each character across all words
        int[] minFrequencies = new int[26];

        // Initialize with max values so we can take the minimum later
        Array.Fill(minFrequencies, int.MaxValue);

        // Count character frequencies for each word
        foreach(string word in words) {
            int[] currentFrequencies = new int[26];
            foreach(char c in word) {
                currentFrequencies[c - 'a']++;
            }

            // Update the global minimum frequencies
            for(int i = 0; i < 26; i++) {
                minFrequencies[i] = Math.Min(minFrequencies[i], currentFrequencies[i]);
            }
        }

        // Build the final result list
        IList<string> result = new List<string>();
        for(int i = 0; i < 26; i++) {
            while(minFrequencies[i] > 0) {
                result.Add(((char)(i + 'a')).ToString());
                minFrequencies[i]--;
            }
        }

        return result;
    }
}