public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int left = 0;
        int right = numbers.Length - 1;

        while(left < right) {
            int currentSum = numbers[left] + numbers[right];

            if(currentSum == target) {
                return new int[] {left + 1, right + 1};
            } else if(currentSum < target) {
                left++; // Move towords larget values
            } else {
                right--; // Move towards smaller values
            }
        }

        // The problem guarentees exactly one solution, so this point is unreachable
        return new int[] { -1, -1};
    }
}