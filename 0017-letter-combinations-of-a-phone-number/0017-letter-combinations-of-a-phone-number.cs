public class Solution {
    // Keypad mapping where index represents the digit character minus '0'
    private static readonly string[] Keypad = new string[] {
        "",     // 0
        "",     // 1
        "abc",  // 2
        "def",  // 3
        "ghi",  // 4
        "jkl",  // 5
        "mno",  // 6
        "pqrs", // 7
        "tuv",  // 8
        "wxyz"  // 9
    };

    public IList<string> LetterCombinations(string digits) {
        List<string> result = new List<string>();

        if(string.IsNullOrEmpty(digits)){
            return result;
        }

        Backtrack(digits, 0, new StringBuilder(), result);
        return result;
    }

    private void Backtrack(string digits, int index, StringBuilder current, List<string> result) {
        // Base case: If the combination matches the input digits length
        if(index == digits.Length) {
            result.Add(current.ToString());
            return;
        }

        // Get the letters corresponding to the current digit
        string letters = Keypad[digits[index] - '0'];

        for(int i = 0; i < letters.Length; i++) {
            current.Append(letters[i]); // Choose
            Backtrack(digits, index + 1, current, result); // Explore
            current.Length--; // Unchoose (Backtrack)
        }
    }
}