public class Solution {
    public IList<string> StringMatching(string[] words) {
        List<string> result = new List<string>();

        for(int i = 0; i < words.Length; i++) {
            for(int j = 0; j < words.Length; j++) {
                // Don't compare a word with itself
                if(i == j) continue;

                // Check if words[i] is a substring of words[j]
                if(words[j].Contains(words[i])) {
                    result.Add(words[i]);
                    break; // Break early so we don't add the same word multiple times
                }
            }
        }
        return result;
    }
}