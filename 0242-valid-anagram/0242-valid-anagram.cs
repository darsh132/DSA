public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
            return false;
        
        int[] freq = new int[26];
        
        for(int i = 0; i < s.Length; i++)
        {
            freq[s[i] - 'a']++;
            freq[t[i] - 'a']--;
        }
        
        foreach(int count in freq)
        {
            if(count != 0)
                return false;
        }
        
        return true;
    }
}