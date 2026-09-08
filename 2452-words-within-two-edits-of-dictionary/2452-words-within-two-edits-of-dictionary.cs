public class Solution {
    public IList<string> TwoEditWords(string[] queries, string[] dictionary) {
        var result = new List<string>();

        foreach(string query in queries) {
            foreach(string word in dictionary) {
                int diffCount = 0;

                for(int i = 0; i < query.Length; i++) {
                    if(query[i] != word[i]) {
                        diffCount++;
                        if(diffCount > 2) {
                            break;
                        }
                    }
                }

                // If within 2 edits, this query matches a dictionary word
                if(diffCount <= 2) {
                    result.Add(query);
                    break; // Move to the next query word
                }
            }
        }

        return result; 
    }
}