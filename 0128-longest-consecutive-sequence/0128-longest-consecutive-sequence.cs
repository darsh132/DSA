public class Solution {
    public int LongestConsecutive(int[] nums) {
        if(nums == null || nums.Length == 0) {
            return 0;
        }

        // Insert all numbers into a HashSet for O(1) lookups
        HashSet<int> numSet = new HashSet<int>(nums);
        int longestStreak = 0;

        foreach(int num in numSet) {
            // Check if 'num' is the start of a sequence
            if(!numSet.Contains(num -1)) {
                int currentNum = num;
                int currentStreak = 1;

                // Expand the sequence forwards
                while(numSet.Contains(currentNum + 1)) {
                    currentNum += 1;
                    currentStreak += 1;
                }

                // Update the maximum streak found so far
                longestStreak = Math.Max(longestStreak, currentStreak);
            }
        }
        return longestStreak;
    }
}