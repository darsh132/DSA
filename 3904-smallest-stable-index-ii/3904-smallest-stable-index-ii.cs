public class Solution {
    public int FirstStableIndex(int[] nums, int k) {
        int n = nums.Length;
        int[] suffMin = new int[n];

        suffMin[n - 1] = nums[n - 1];
        for(int i = n - 2; i >= 0; i--) {
            suffMin[i] = Math.Min(nums[i], suffMin[i + 1]);
        }

        int curMax = int.MinValue;
        for(int i = 0; i < n; i++) {
            curMax = Math.Max(curMax, nums[i]);
            if((long)curMax - suffMin[i] <= k) {
                return i;
            }
        }

        return -1;
    }
}