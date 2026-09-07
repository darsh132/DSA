public class Solution {
    public int MaxDistance(int[] nums1, int[] nums2) {
        int i = 0;
        int j = 0;
        int maxDist = 0;

        while(i < nums1.Length && j < nums2.Length) {
            if(nums1[i] <= nums2[j]) {
                maxDist = Math.Max(maxDist, j - i);
                j++; // Try to extend the distance
            } else {
                i++; // nums1[i] is too large, move to a smaller value in nums1
            }
        }

        return maxDist;
    }
}