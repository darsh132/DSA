public class Solution {
    public int ThreeSumClosest(int[] nums, int target) {
        // Sort the array to use the two-pointer technique
        Array.Sort(nums);

        // Initialize with the sum of the first three elements
        int closestSum = nums[0] + nums[1] + nums[2];

        for(int i = 0; i < nums.Length - 2; i++)  {
            int left = i + 1;
            int right = nums.Length - 1;

            while(left < right) {
                int currentSum = nums[i] + nums[left] + nums[right];

                // If we find an exact match, return it immediately
                if(currentSum == target) {
                    return currentSum;
                }

                // Update closestSum if the current sum is closer to the target
                if(Math.Abs(currentSum - target) < Math.Abs(closestSum - target)) {
                    closestSum = currentSum;
                }

                // Move pointers based on how currentSum compares to target
                if(currentSum < target) {
                    left++;
                } else {
                    right--;
                }
            }
        }
        return closestSum;
    }
}