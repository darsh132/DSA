public class Solution {
    public int MaxDistance(int[] colors) {
        int n = colors.Length;
        int maxDist = 0;

        // Scan from the right end to pair with the leftmost house (index 0)
        for(int i = n - 1; i >= 0; i--) {
            if(colors[i] != colors[0]) {
                maxDist = Math.Max(maxDist, i);
                break;
            }
        }

        // Scan from the left end to pair with the rightmost house (index n)
        for(int i = 0; i < n; i++) {
            if(colors[i] != colors[n - 1]) {
                maxDist = Math.Max(maxDist, (n - 1) - i);
                break;
            }
        }

        return maxDist;
    }
}