public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        // Calculate the sum  of the first window of size k
        double currentSum = 0;
        for(int i = 0; i < k; i++) {
            currentSum += nums[i];
        }

        double maxSum = currentSum;

        // Slide the window across the array
        for(int i = k; i < nums.Length; i++) {
            currentSum += nums[i] - nums[i - k];
            if(currentSum > maxSum) {
                maxSum = currentSum;
            }
        }

        // return the maximum average
        return maxSum / k;
    }
}