public class Solution {
    public string SmallestSubsequence(string s) {
        // Array to store the last index of each character 
        int[] lastIndex = new int[26];
        for(int i = 0; i < s.Length; i++) {
            lastIndex[s[i] - 'a'] = i;
        }

        // Array to track if a character is currently in the stack
        bool[] inStack = new bool[26];

        // Use a StringBuilder as a stack for each string construction
        StringBuilder stack = new StringBuilder();

        for(int i = 0; i < s.Length; i++) {
            char c = s[i];
            int idx = c - 'a';

            // If character is already in the stack, skip it
            if(inStack[idx]) continue;

            // Maintain the monotonic property: pop characterss if they are
            // lexicographically greater than current char and appear later
            while(stack.Length > 0 && stack[stack.Length - 1] > c && lastIndex[stack[stack.Length - 1] - 'a'] > i) {
                char removed = stack[stack.Length - 1];
                inStack[removed - 'a'] = false;
                stack.Remove(stack.Length - 1, 1);
            }

            // Push current character
            stack.Append(c);
            inStack[idx] = true;
        }

        return stack.ToString();
    }
}