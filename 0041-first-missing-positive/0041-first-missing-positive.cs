public class Solution {
    public int FirstMissingPositive(int[] nums) {
        int n = nums.Length;

        // Place each number x in its correct index (x - 1), if 1 <= x <= n
        for(int i = 0; i < n; i++) {
            while(nums[i] >= 1 && nums[i] <= n && nums[nums[i] - 1] != nums[i]) {
                int correctIdx = nums[i] - 1;
                // Swap nums[i] with nums[correctIdx]
                int temp = nums[i];
                nums[i] = nums[correctIdx];
                nums[correctIdx] = temp;
            }
        }

        // Find the first index where nums[i] != i + 1
        for(int i = 0; i < n; i++) {
            if(nums[i] != i + 1) {
                return i + 1;
            }
        }

        // If all numbers from 1 to n are present
        return n + 1;
    }
}