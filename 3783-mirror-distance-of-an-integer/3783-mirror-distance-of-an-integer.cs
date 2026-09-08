public class Solution {
    public int MirrorDistance(int n) {
        long original = n;
        long reversed = 0;
        long temp = n;

        // Reverse the digits of n
        while(temp > 0) {
            reversed = reversed * 10 + (temp % 10);
            temp /= 10;
        }

        // Return the absolute difference
        return (int)Math.Abs(original - reversed);
    }
}