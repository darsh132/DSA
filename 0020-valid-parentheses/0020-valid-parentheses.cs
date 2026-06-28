public class Solution {
    public bool IsValid(string s) {
        // An odd length string can never be completely balanced
        if(s.Length % 2 !=  0) return false;

        Stack<char> stack = new Stack<char>();

        foreach(char c in s) {
            // Push opening brackets onto the stack
            if(c == '(' || c == '{' || c == '[') {
                stack.Push(c);
            }
            else { // Handle closing brackets
                // If we hit a closing bracket but the stack is empty, it's invalid
                if(stack.Count == 0) return false;
                
                char top = stack.Pop();

                // Check if the popped opening bracket matches the current closing bracket
                if(c == ')' && top != '(') return false;
                if(c == '}' && top != '{') return false;
                if(c == ']' && top != '[') return false;
            }
        }

        // If the stack is empty, all brackets were matched correctly
        return stack.Count == 0;
    }
}