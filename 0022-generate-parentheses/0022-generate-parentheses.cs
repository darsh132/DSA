public class Solution {
    public IList<string> GenerateParenthesis(int n) {
        List<string> result = new List<string>();

        Backtrack(result, "", 0, 0, n);

        return result;
    }

    private void Backtrack(List<string> result, string current, int open, int close, int n)
    {
        if (current.Length == 2 * n)
        {
            result.Add(current);
            return;
        }

        // Add '('
        if (open < n)
        {
            Backtrack(result, current + "(", open + 1, close, n);
        }

        // Add ')'
        if (close < open)
        {
            Backtrack(result, current + ")", open, close + 1, n);
        }
    }
}