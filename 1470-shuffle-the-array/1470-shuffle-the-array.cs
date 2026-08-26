public class Solution {
    public int[] Shuffle(int[] nums, int n) {
        int[] result = new int[2 * n];

        for(int i = 0; i < n; i++) {
            result[2 * i] = nums[i]; // Place xi at even indices
            result[2 * i + 1] = nums[i + n]; // Place yi at odd indices
        }

        return result;
    }
}