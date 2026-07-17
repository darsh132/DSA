public class Solution {
    public int BitwiseComplement(int n) {
        // Edge case : if n is 0, the complement is 1
        if(n == 0) return 1;

        int mask = 0;
        int temp = n;

        // Build a mask of 1s matching the length of n's binary representation
        while(temp > 0) {
            mask = (mask << 1) | 1;
            temp >>= 1; // Shift right to process the next bit
        }

        // XORing n with the mask flips all of its bits
        return n^mask;
    }
}