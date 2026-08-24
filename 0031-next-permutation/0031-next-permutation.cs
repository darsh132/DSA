public class Solution {
    public void NextPermutation(int[] nums) {
        int n = nums.Length;
        int i = n - 2;

        // 1. Find the first decreasing element from the right
        while (i >= 0 && nums[i] >= nums[i + 1]) {
            i--;
        }

        // 2. Swap with the smallest element larger than nums[i] to its right
        if (i >= 0) {
            int j = n - 1;
            while (nums[j] <= nums[i]) {
                j--;
            }
            Swap(nums, i, j);
        }

        // 3. Reverse the suffix to get the smallest lexicographical order
        Reverse(nums, i + 1, n - 1);
    }

    private void Swap(int[] nums, int i, int j) {
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }

    private void Reverse(int[] nums, int start, int end) {
        while (start < end) {
            Swap(nums, start, end);
            start++;
            end--;
        }
    }
}