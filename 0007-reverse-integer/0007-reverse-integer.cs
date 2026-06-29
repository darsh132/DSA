public class Solution {
    public int Reverse(int x) {
        int rev = 0;

        while (x != 0) {
            int pop = x % 10;
            x /= 10;

            // Check for overflow before multiplying by 10
            // int.MaxValue is 2147483647
            if (rev > int.MaxValue / 10 || (rev == int.MaxValue / 10 && pop > 7)) {
                return 0;
            }

            // Check for underflow before multiplying by 10
            // int.MinValue is -2147483648
            if(rev < int.MinValue / 10 || (rev == int.MinValue / 10 && pop < -8)) {
                return 0;
            }

            rev = rev * 10 + pop;
        }

        return rev;
    }
}