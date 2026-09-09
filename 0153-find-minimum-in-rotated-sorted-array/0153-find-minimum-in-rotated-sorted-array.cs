public class Solution {
    public int FindMin(int[] nums) {
        int left = 0;
        int right = nums.Length - 1;

        // Binary search for the inflecton point (minimum element)
        while(left < right) {
            int mid = left + (right - left) / 2;

            if(nums[mid] > nums[right]) {
                // The minimum element must lie strictly to the right of mid
                left = mid + 1;
            } else {
                // The minimum element is at mid or to the left of mid
                right = mid;
            }
        }

        // left == right points to the minimum element
        return nums[left];
    }
}