public class Solution {
    public int RomanToInt(string s) {
        // Map Roman characters to their integer values
        Dictionary<char, int> romanMap = new Dictionary<char, int>() {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        int total = 0;
        int n = s.Length;

        for(int i = 0; i < n; i++) {
            int currentVal = romanMap[s[i]];

            // If this is not the last character and the current value is less than the next value
            if(i < n - 1 && currentVal < romanMap[s[i+1]]) {
               total -= currentVal; // Subtraction rule (e.g., IV = -1 + 5 = 4)
            } else {
                total += currentVal; // Normal addition rule
            }
        }

        return total;
    }
}