public class Solution {
    public string IntToRoman(int num) {
        int[] values = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        string[] symbols = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I"};

        StringBuilder roman = new StringBuilder();

        // Loop through each value-symbol pair
        for(int i = 0; i < values.Length; i++) {
            // while the current number is greater than or equal to the Roman value
            while (num >= values[i]) {
                num -= values[i]; // Deduct the value
                roman.Append(symbols[i]); // Append the symbol
            }
        }

        return roman.ToString();
    }
}