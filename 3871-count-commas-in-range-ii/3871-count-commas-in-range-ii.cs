public class Solution {
    public long CountCommas(long n) {
        long totalCommas = 0;
        long threshold = 1000L;

        // Add 1 comma for each threshold crossed by numbers in [1, n]
        while(threshold <= n) {
            totalCommas += (n - threshold + 1);

            // Guard against 64-bit signed integer overflow before multiplying by 1000
            if(threshold > long.MaxValue / 1000) {
                break;
            }
            threshold *= 1000L;
        }

        return totalCommas;
    }
}