public class Solution {
    public string Convert(string s, int numRows) {
        // Base case: If numRows is 1 or greater than/equal to string length,
        // no zigzagging is needed.
        if(numRows == 1 || numRows >= s.Length) {
            return s;
        }

        // Initialize a StringBuilder for each row
        StringBuilder[] rows = new StringBuilder[numRows];
        for(int i = 0; i < numRows; i++) {
            rows[i] = new StringBuilder();
        }

        int currentRow = 0;
        bool goingDown = false;

        // Iterate through each character in the string 
        foreach (char c in s) {
            rows[currentRow].Append(c);

            // Turn around when we reach the top or bottom row
            if(currentRow == 0 || currentRow == numRows - 1) {
                goingDown = !goingDown;
            }

            // Move up or down to the next row
            currentRow += goingDown ? 1 : -1;
        }

        // Combine all rows into a single string
        StringBuilder result = new StringBuilder();
        foreach(StringBuilder row in rows) {
            result.Append(row);
        }

        return result.ToString();
    }
}