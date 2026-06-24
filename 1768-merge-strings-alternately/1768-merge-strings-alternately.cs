public class Solution {
    public string MergeAlternately(string word1, string word2) {
        StringBuilder result = new StringBuilder();
        int maxLength = Math.Max(word1.Length, word2.Length);

        for(int i = 0; i < maxLength; i++)
        {
            if(i < word1.Length)
            {
                result.Append(word1[i]);
            }
            
            if(i < word2.Length)
            {
                result.Append(word2[i]);
            }
        }

        return result.ToString();
    }
}