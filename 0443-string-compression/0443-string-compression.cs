public class Solution {
    public int Compress(char[] chars) {
        int write = 0;
        int read = 0;

        while(read < chars.Length) {
            char currentChar = chars[read];
            int count = 0;

            // Count the number of consecutive occurrence of the current character

            while(read < chars.Length && chars[read] == currentChar)
            {
                read++;
                count++;
            }

            // Write the character itself
            chars[write++] = currentChar;

            // If the group length is greater than 1, write its digits
            if(count > 1)
            {
                foreach(char digit in count.ToString())
                {
                    chars[write++] = digit;
                }
            }
        }

        return write;
    }
}