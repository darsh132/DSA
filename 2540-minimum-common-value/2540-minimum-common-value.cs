public class Solution {
    public int GetCommon(int[] nums1, int[] nums2) {
        int i = 0;
        int j = 0;

        // Traverse both sorted arrays using two pointers
        while(i < nums1.Length && j < nums2.Length) {
            if(nums1[i] == nums2[j]) {
                // First match encountered from the left is guaranteed to be the minimum
                return nums1[i];
            } else if(nums1[i] < nums2[j]) {
                i++;
            } else {
                j++;
            }
        }

        return -1;
    }
}