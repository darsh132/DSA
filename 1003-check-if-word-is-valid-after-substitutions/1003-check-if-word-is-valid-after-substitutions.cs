public class Solution {
    public bool IsValid(string s) {
        // Use StringBuilder as a stack for optimal performance and indexing
        StringBuilder stack = new StringBuilder();

        foreach(char c in s) {
            stack.Append(c);

            // Check if the last 3 characters form "abc"
            if(stack.Length >= 3 &&
               stack[stack.Length - 1] == 'c' &&
               stack[stack.Length - 2] == 'b' && 
               stack[stack.Length - 3] ==
               'a') {
                
               // Remove the "abc" triplet
               stack.Length -= 3;
            }
        }

        // If the stack is empty, the string is valid
        return stack.Length == 0;
    }
}