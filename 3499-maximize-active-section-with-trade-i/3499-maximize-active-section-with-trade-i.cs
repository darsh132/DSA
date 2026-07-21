public class Solution {
    public int MaxActiveSectionsAfterTrade(string s) {
        int initialOnes = 0;
        foreach(char c in s) {
            if(c == '1') initialOnes++;
        }

        // Augment the string as specifiedd by the problem
        string t = "1" + s + "1";

        // List to store pairs of (type, length) where type: 0 for '0', 1 for '1'
        List<(int type, int len)> groups = new List<(int type, int len)>();

        int n = t.Length;
        int i = 0;
        while(i < n) {
            int j = i;
            while(j < n && t[j] == t[i]) {
                j++;
            }
            groups.Add((t[i] - '0', j - i));
            i = j;
        }

        int maxDelta = 0;

        // Traverse groups to look for a '1' group flanked by '0' groups
        // e.g., groups[k-1] is 0, groups[k] is 1, groups[k+1] is 0
        for (int k = 1; k < groups.Count - 1; k++) {
            if (groups[k].type == 1 && groups[k - 1].type == 0 && groups[k + 1].type == 0) {
                int zeroLeft = groups[k - 1].len;
                int zeroRight = groups[k + 1].len;

                // The delta is the sum of the zeros that turn into ones
                int delta = zeroLeft + zeroRight; 
                if (delta > maxDelta) {
                    maxDelta = delta;
                }
            }
        }

        return initialOnes + maxDelta;
        
    }
}